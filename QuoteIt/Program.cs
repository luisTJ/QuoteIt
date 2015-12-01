using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace QuoteIt
{
    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Input input = null;
            Util util = new Util();
            bool showDialog = false;
            if (args.Length == 12 && String.Equals(args[11], "show"))
            {
                String[] tmp = new String[11];
                Array.Copy(args, tmp, 11);
                args = tmp;
                showDialog = true;
            }

            if (args.Length == 11)
            {
                input = util.argsToInput(args);
            }
            else
            {
                showDialog = true;
            }

            if(showDialog)
            {
                if (input == null)
                {
                    input = new Input();
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var cb = Clipboard.GetDataObject();
                if ((cb != null) || cb.GetFormats().Contains("Text"))
                {
                    var tmp = (String)cb.GetData("Text");
                    if (!String.IsNullOrEmpty(tmp))
                        input.Text = tmp;
                }

                var frm = new MainForm(input);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }
            
            var clipboard = Clipboard.GetDataObject();
            if (clipboard == null)
                return;

            var formats = clipboard.GetFormats();
            if (!formats.Contains("Text"))
                return;

            String text = (String)clipboard.GetData("Text");
            input.Text = text;
            var quoted = util.AddQuote(input);
            if (quoted != null)
            {
                Clipboard.SetData("Text", quoted);
            }
        }
    }
}
