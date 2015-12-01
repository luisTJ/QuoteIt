using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.IO;
using System.Security.Cryptography;

[assembly: InternalsVisibleToAttribute("QuoteIt_Test")]
namespace QuoteIt
{
    class Util
    {
        //TODO: maybe add anothe level of menu?

        private const string QUOTE_IT_EDITOR_KEY_NAME = "~~QuoteIt Editor~~";
        private const string QUOTE_IT_EDITOR_MENU_NAME = "QuoteIt Editor";
        private const string REGISTRY_ROOT = @"HKEY_CURRENT_USER\"; // current_user is for individual, classes_root for shared (admin right needed)
        private readonly string[] PATHS_TO_QUOTE_IT = { @"Software\Classes\*\shell\", @"Software\Classes\Directory\shell\", @"Software\Classes\Directory\Background\shell\" }; // Right click @ [at all files, at folders, at any background]
        private const String QUOTE_IT_REGISTRY_STRUCTURE = @"QuoteIt\shell\";
        public const string ICON_FOLDER = "ico";

        public string AddQuote(Input input)
        {
            if (input == null || String.IsNullOrEmpty(input.Text))
                return null;
            try
            {
                var tokens = input.Text.Split(input.getTokenizer(), StringSplitOptions.RemoveEmptyEntries);
                StringBuilder sb = new StringBuilder();//TODO: maybe compute size?
                sb.Append(input.Prefix);
                foreach (var token in tokens)
                {
                    sb.AppendFormat("{0}{1}{2}{3}", input.LeftQuote,token,input.RightQuote,input.Seperator);
                }
                sb.Remove(sb.Length - input.Seperator.Length, input.Seperator.Length);
                sb.Append(input.Suffix);
                return sb.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SortedDictionary<String,String> getCurrentContextMenuItem()
        {
            var menuItems = new SortedDictionary<string, string>();
            try
            {
                using (var quoteItKey = Registry.CurrentUser.OpenSubKey(PATHS_TO_QUOTE_IT[0] + QUOTE_IT_REGISTRY_STRUCTURE))
                {
                    if (quoteItKey == null)
                        return menuItems;

                    foreach (String name in quoteItKey.GetSubKeyNames())
                    {
                        try
                        {
                            if (String.Equals(QUOTE_IT_EDITOR_KEY_NAME, name, StringComparison.OrdinalIgnoreCase))
                                continue; // don't return quoteIt editor key
                            var cmd = quoteItKey.OpenSubKey(name);
                            menuItems.Add((String)cmd.GetValue(""), name);
                        }
                        catch { } // just in case
                    }
                }
            }
            catch { }
            return menuItems;
        }

        public int addContextMenuItem(out String id, Input input, string menu_name, String exec_path, String icon_path = "")
        {
            if (String.Compare(QUOTE_IT_EDITOR_KEY_NAME, menu_name, true) > -1) //to ensure default menu item sit at the bottom
            {
                id = normalizeKeyName(" " + menu_name);
            }
            else
            {
                id = normalizeKeyName(menu_name);
            }
            if (char.IsLower(id[0])) //capitalize the key name just because it looks better :-)
            {
                var tmp = id.ToCharArray();
                tmp[0] = char.ToUpper(tmp[0]);
                id = new String(tmp);
            }

            foreach (var path_to_quoteIt in PATHS_TO_QUOTE_IT)
            {
                try
                {
                    String reg_path = REGISTRY_ROOT + path_to_quoteIt + QUOTE_IT_REGISTRY_STRUCTURE + id;
                    Registry.SetValue(reg_path, "", menu_name);
                    if (!String.IsNullOrEmpty(icon_path))
                    {
                        Registry.SetValue(reg_path, "Icon", icon_path);
                    }
                    var args = inputToArgs(input);
                    Registry.SetValue(reg_path + "\\command", "", String.Format("{0} {1}", addQuoteIfNecessary(exec_path), args));
                }
                catch (UnauthorizedAccessException ex)
                {
                    return -8; // just a random magic number //TODO: maybe change to enum ?
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
            return 0;
        }

        private String normalizeKeyName(String name)
        {
            if(String.IsNullOrEmpty(name))
            {
                name = "default";
            }
            else if (name.Length > 255)
            {
                name = name.Substring(0, 255);
            }
            return name;
        }

        public bool removeContextMenuItem(String id)
        {
            if (id == null)
                return false;

            bool result = true;
            foreach (var path_to_quoteIt in PATHS_TO_QUOTE_IT)
            {
                try
                {
                    Registry.CurrentUser.DeleteSubKeyTree(path_to_quoteIt + QUOTE_IT_REGISTRY_STRUCTURE + id, false);
                }
                catch (Exception ex) { 
                    result = false; 
                }
            }
            return result;
        }

        public String escapeText(String text)
        {
            return text.Replace("\r", @"\r").Replace("\n",@"\n").Replace("\"","_Q_");
        }

        public String unescapeText(String text)
        {
           return text.Replace(@"\r", "\r").Replace(@"\n", "\n").Replace("_Q_","\"").Replace("_LB_","[").Replace("_RB_","]"); // _LB_ and _RB_ are here just because installer cannot escape [] properly :( 

        }

        public String inputToArgs(Input input)
        {
            if(input == null)
                return "";

            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}",
                addQuoteIfNecessary(escapeText(input.LeftQuote))
                ,addQuoteIfNecessary(escapeText(input.RightQuote))
                ,addQuoteIfNecessary(escapeText(input.Seperator))
                ,addQuoteIfNecessary(escapeText(input.Prefix))
                ,addQuoteIfNecessary(escapeText(input.Suffix))
                ,addQuoteIfNecessary(escapeText(input.Tokenizer_Comma ? "y" : "n"))
                ,addQuoteIfNecessary(escapeText(input.Tokenizer_LineFeed ? "y" : "n"))
                ,addQuoteIfNecessary(escapeText(input.Tokenizer_Space ? "y" : "n"))
                ,addQuoteIfNecessary(escapeText(input.Tokenizer_CarriageReturn ? "y" : "n"))
                ,addQuoteIfNecessary(escapeText(input.Tokenizer_Tab ? "y" : "n"))
                ,addQuoteIfNecessary(escapeText(input.Tokenizer_Custom))
                );
        }

        public String addQuoteIfNecessary(String text)
        {
            if(text == null)
                return "";

            if(text == "")
                return "\"\"";

            if (text.Contains(' ') || text.Contains('\t'))
            {
                return String.Format("\"{0}\"", text);
            }
            return text;
        }

        public String[] split(String args)
        {
            if (args == null)
                return new String[0];
            return Regex.Matches(args, @"[\""].*?[\""]|[^ ]+")
                .Cast<Match>()
                .Select(m => unescapeText(m.Value.Trim(new char[] { '\"' })))
                .ToArray();
        }

        public Input argsToInput(String args)
        {
            var tokens = split(args);

            if (tokens.Length != 11)
            {
                return null;
            }

            return argsToInput(tokens);             
        }

        public Input argsToInput(IEnumerable<String> args)
        {
            Input input = new Input();
            var it = args.GetEnumerator();
            it.MoveNext();

            input.LeftQuote = unescapeText(it.Current); it.MoveNext();
            input.RightQuote = unescapeText(it.Current); it.MoveNext();
            input.Seperator = unescapeText(it.Current); it.MoveNext();
            input.Prefix = unescapeText(it.Current); it.MoveNext();
            input.Suffix = unescapeText(it.Current); it.MoveNext();
            input.Tokenizer_Comma = String.Equals(it.Current, "y", StringComparison.OrdinalIgnoreCase) ? true : false; it.MoveNext();
            input.Tokenizer_LineFeed = String.Equals(it.Current, "y", StringComparison.OrdinalIgnoreCase) ? true : false; it.MoveNext();
            input.Tokenizer_Space = String.Equals(it.Current, "y", StringComparison.OrdinalIgnoreCase) ? true : false; it.MoveNext();
            input.Tokenizer_CarriageReturn = String.Equals(it.Current, "y", StringComparison.OrdinalIgnoreCase) ? true : false; it.MoveNext();
            input.Tokenizer_Tab = String.Equals(it.Current, "y", StringComparison.OrdinalIgnoreCase) ? true : false; it.MoveNext();
            input.Tokenizer_Custom = unescapeText(it.Current);

            return input;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns>path to new file</returns>
        public String CopyIconToAppDir(String path)
        {

            try
            {
                using (var md5 = MD5.Create())
                {
                    byte[] new_hash;
                    using (var fs = File.OpenRead(path))
                    {
                        new_hash = md5.ComputeHash(fs);
                    }

                    var previous_icons = Directory.GetFiles(ICON_FOLDER, "*.ico", SearchOption.TopDirectoryOnly);
                    byte[] old_hash;
                    foreach (var icon in previous_icons)
                    {
                        using (var fs = File.OpenRead(icon))
                        {
                            old_hash = md5.ComputeHash(fs);
                            if (old_hash.SequenceEqual(new_hash))
                                return icon;
                        }
                    }
                }
                //new icon --> save it
                var filenameExt = Path.GetFileName(path);
                var ext = Path.GetExtension(path);
                var filename = Path.GetFileNameWithoutExtension(path);
                int i = 1;
                String final_name = filenameExt;
                while (File.Exists(ICON_FOLDER + "\\" + final_name))
                {
                    final_name = String.Format("{0}_{1}{2}",filename,i++,ext);
                }
                File.Copy(path, final_name);
                return Path.GetFullPath(ICON_FOLDER + "\\" + final_name);
            }
            catch (Exception ex)
            {
                return path;
            }
        }

        public String getArgs(string menuItemName)
        {
            using (var quoteItKey = Registry.CurrentUser.OpenSubKey(PATHS_TO_QUOTE_IT[0] + QUOTE_IT_REGISTRY_STRUCTURE))
            {
                if (quoteItKey == null)
                    return null;

                foreach (String name in quoteItKey.GetSubKeyNames())
                {
                    try
                    {
                        using(var cmd = quoteItKey.OpenSubKey(name))
                        {
                            if (String.Equals(menuItemName, (String)cmd.GetValue("")))
                            {
                                var tmp = Registry.GetValue(REGISTRY_ROOT + PATHS_TO_QUOTE_IT[0] + QUOTE_IT_REGISTRY_STRUCTURE + name + @"\command", "", null);
                                if (tmp != null) //double check if I have to check for null?
                                    return (String)tmp;
                                else
                                    return null;
                            }
                        }
                    }
                    catch (Exception ex) { } // just in case
                }
            }
            return null;
        }


        public string FindIdByMenuItemName(string menuItemName)
        {
            using (var quoteItKey = Registry.CurrentUser.OpenSubKey(PATHS_TO_QUOTE_IT + QUOTE_IT_REGISTRY_STRUCTURE))
            {
                if (quoteItKey == null)
                    return null;

                foreach (String name in quoteItKey.GetSubKeyNames())
                {
                    if(String.Equals(QUOTE_IT_EDITOR_MENU_NAME,name,StringComparison.OrdinalIgnoreCase)) //Hide quoteIt Menu Item
                        continue;
                    try
                    {
                        using (var cmd = quoteItKey.OpenSubKey(name))
                        {
                            if (String.Equals(menuItemName, (String)cmd.GetValue("")))
                            {
                                return name;
                            }
                        }
                    }
                    catch { } // just in case
                }
            }
            return null;
        }
    }
}
