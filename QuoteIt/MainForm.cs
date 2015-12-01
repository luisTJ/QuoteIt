using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace QuoteIt
{
    public partial class MainForm : Form
    {
        Input input;
        Util util = new Util();
        SortedDictionary<String, String> menuItems;
        public MainForm(Input input)
        {
            this.input = input;
            InitializeComponent();
        }

        private void FormCustomInput_Load(object sender, EventArgs e)
        {
            assignInputToTextBoxes(input);
            menuItems = util.getCurrentContextMenuItem();
            cmboMenuItem.DisplayMember = "Key";
            cmboMenuItem.ValueMember = "Value";
            bindComboBox();
        }

        private void assignInputToTextBoxes(Input input)
        {
            txtPrefix.Text = input.Prefix;
            txtLeftQuote.Text = input.LeftQuote;
            txtRightQuote.Text = input.RightQuote;
            txtSeperator.Text = input.Seperator;
            txtSuffix.Text = input.Suffix;
            chkComma.Checked = input.Tokenizer_Comma;
            chkCarriageReturn.Checked = input.Tokenizer_CarriageReturn;
            chkLineFeed.Checked = input.Tokenizer_LineFeed;
            chkTab.Checked = input.Tokenizer_Tab;
            chkSpace.Checked = input.Tokenizer_Space;
            txtCustomTokenizer.Text = input.Tokenizer_Custom;
            txtSampleInput.Text = input.Text;
        }

        private void bindComboBox(String defaultText = null)
        {
            if (menuItems.Count > 0)
                cmboMenuItem.DataSource = new BindingSource(menuItems, null);
            else
                cmboMenuItem.DataSource = null;

            if(defaultText != null)
                cmboMenuItem.Text = defaultText;
        }


        private void txt_sampleInput_TextChanged(object sender, EventArgs e)
        {
            chkUseDefaultText.Checked = String.Equals(input.default_sample_input, txtSampleInput.Text);
            input.Text = txtSampleInput.Text;
            txtResult.Text = util.AddQuote(input);
        }

        private void chk_comma_CheckedChanged(object sender, EventArgs e)
        {
            input.Tokenizer_Comma = chkComma.Checked;
            txtResult.Text = util.AddQuote(input);
        }

        private void chk_carriageReturn_CheckedChanged(object sender, EventArgs e)
        {
            input.Tokenizer_CarriageReturn = chkCarriageReturn.Checked;
            txtResult.Text = util.AddQuote(input);
        }

        private void chk_lineFeed_CheckedChanged(object sender, EventArgs e)
        {
            input.Tokenizer_LineFeed = chkLineFeed.Checked;
            txtResult.Text = util.AddQuote(input);
        }

        private void chk_tab_CheckedChanged(object sender, EventArgs e)
        {
            input.Tokenizer_Tab = chkTab.Checked;
            txtResult.Text = util.AddQuote(input);
        }

        private void chk_space_CheckedChanged(object sender, EventArgs e)
        {
            input.Tokenizer_Space = chkSpace.Checked;
            txtResult.Text = util.AddQuote(input);
        }

        private void txt_customTokenizer_TextChanged(object sender, EventArgs e)
        {
            input.Tokenizer_Custom = txtCustomTokenizer.Text;
            txtResult.Text = util.AddQuote(input);
        }

        private void txt_prefix_TextChanged(object sender, EventArgs e)
        {
            input.Prefix = txtPrefix.Text;
            txtResult.Text = util.AddQuote(input);
        }

        private void txt_leftQuote_TextChanged(object sender, EventArgs e)
        {
            input.LeftQuote = txtLeftQuote.Text;
            txtResult.Text = util.AddQuote(input);
        }

        private void txt_rightQuote_TextChanged(object sender, EventArgs e)
        {
            input.RightQuote = txtRightQuote.Text;
            txtResult.Text = util.AddQuote(input);
        }

        private void txt_seperator_TextChanged(object sender, EventArgs e)
        {
            input.Seperator = txtSeperator.Text;
            txtResult.Text = util.AddQuote(input);
        }

        private void txt_suffix_TextChanged(object sender, EventArgs e)
        {
            input.Suffix = txtSuffix.Text;
            txtResult.Text = util.AddQuote(input);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmboMenuItem.Text))
            {
                MessageBoxEx.Show(this, "Pick a name first!!", "Save Result",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String id;
            String itemName = cmboMenuItem.Text;
            String icon_path = util.CopyIconToAppDir(txtChosenIcon.Text);

            int status = util.addContextMenuItem(out id, input, itemName, Application.ExecutablePath,icon_path);
            if (status == 0)
            {
                //update combobox
                if (!menuItems.ContainsKey(itemName))
                {
                    menuItems.Add(itemName, id);
                    bindComboBox(itemName);
                }
                MessageBoxEx.Show(this,String.Format("Success: \"{0}\" has been added.",itemName), "Save Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if(status == -8){
                var result = MessageBoxEx.Show(this, "Do you want to relaunch this app using higher privilege?", "You seems to have a permission issue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes){
                    ProcessStartInfo startInfo = new ProcessStartInfo(Application.ExecutablePath, String.Format("{0} show", util.inputToArgs(input)));
                    startInfo.Verb = "runas";
                    System.Diagnostics.Process.Start(startInfo);
                    this.Close();
                }
            }
            else
            {
                MessageBoxEx.Show(this, String.Format("We Failed to add \"{0}\" :(", itemName), "Save Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmboMenuItem.Text))
            {
                MessageBoxEx.Show(this, "Pick a name first!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            String itemName = cmboMenuItem.Text;
            String id;
            if (menuItems.ContainsKey(itemName))
            {
                id = menuItems[itemName];
            }
            else
            {
                id = util.FindIdByMenuItemName(itemName);
            }

            bool success = util.removeContextMenuItem(id);
            if (success)
            {
                //update combobox
                menuItems.Remove(itemName);
                bindComboBox();
                MessageBoxEx.Show(this, String.Format("Success: \"{0}\" has been removed",itemName), "Remove Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show(this, String.Format("Failed: Couldn't remove \"{0}\"",itemName), "Remove Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btBrowseIcon_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Util.ICON_FOLDER))
            {
                openFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), Util.ICON_FOLDER);
            }
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtChosenIcon.Text = openFileDialog.FileName;
                picChosenIcon.Image = Image.FromFile(txtChosenIcon.Text);
                picChosenIcon.Visible = true;
            }
        }

        private void chkUseDefaultText_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseDefaultText.Checked)
            {
                txtSampleInput.Text = input.default_sample_input;
            }
        }

        private void cmboMenuItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                loadPreset();
                e.Handled = true;
            }
        }

        private void loadPreset()
        {
            var text = cmboMenuItem.Text;
            if (String.IsNullOrEmpty(text))
                return;

            if (menuItems.ContainsKey(text))
            {
                var raw_cmd = util.getArgs(menuItems[text]);
                if (raw_cmd == null)
                    return;
                var cmds = util.split(raw_cmd);
                if (cmds.Length == 12)
                {
                    var input = util.argsToInput(cmds.Skip(1));
                    input.Text = this.input.Text;
                    this.input = input;
                    assignInputToTextBoxes(this.input);
                }
            }
        }

        private void cmboMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPreset();
        }
    }
}
