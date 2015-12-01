namespace QuoteIt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtLeftQuote = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtRightQuote = new System.Windows.Forms.TextBox();
            this.lbPrefix = new System.Windows.Forms.Label();
            this.lbLeftQuote = new System.Windows.Forms.Label();
            this.lbRightQuote = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSeperator = new System.Windows.Forms.TextBox();
            this.lbSeperator = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpSampleInput = new System.Windows.Forms.GroupBox();
            this.chkUseDefaultText = new System.Windows.Forms.CheckBox();
            this.txtSampleInput = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.grpTokenizer = new System.Windows.Forms.GroupBox();
            this.chkSpace = new System.Windows.Forms.CheckBox();
            this.lb_customTokenizer = new System.Windows.Forms.Label();
            this.txtCustomTokenizer = new System.Windows.Forms.TextBox();
            this.chkCarriageReturn = new System.Windows.Forms.CheckBox();
            this.chkLineFeed = new System.Windows.Forms.CheckBox();
            this.chkTab = new System.Windows.Forms.CheckBox();
            this.chkComma = new System.Windows.Forms.CheckBox();
            this.lbSuffix = new System.Windows.Forms.Label();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.picChosenIcon = new System.Windows.Forms.PictureBox();
            this.lbIcon = new System.Windows.Forms.Label();
            this.lbMenuItem = new System.Windows.Forms.Label();
            this.btBrowseIcon = new System.Windows.Forms.Button();
            this.txtChosenIcon = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmboMenuItem = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpResult.SuspendLayout();
            this.grpSampleInput.SuspendLayout();
            this.grpTokenizer.SuspendLayout();
            this.grpSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChosenIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLeftQuote
            // 
            this.txtLeftQuote.Location = new System.Drawing.Point(94, 31);
            this.txtLeftQuote.Multiline = true;
            this.txtLeftQuote.Name = "txtLeftQuote";
            this.txtLeftQuote.Size = new System.Drawing.Size(72, 36);
            this.txtLeftQuote.TabIndex = 1;
            this.txtLeftQuote.TextChanged += new System.EventHandler(this.txt_leftQuote_TextChanged);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(16, 31);
            this.txtPrefix.Multiline = true;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(72, 36);
            this.txtPrefix.TabIndex = 0;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txt_prefix_TextChanged);
            // 
            // txtRightQuote
            // 
            this.txtRightQuote.Location = new System.Drawing.Point(172, 31);
            this.txtRightQuote.Multiline = true;
            this.txtRightQuote.Name = "txtRightQuote";
            this.txtRightQuote.Size = new System.Drawing.Size(72, 36);
            this.txtRightQuote.TabIndex = 2;
            this.txtRightQuote.TextChanged += new System.EventHandler(this.txt_rightQuote_TextChanged);
            // 
            // lbPrefix
            // 
            this.lbPrefix.AutoSize = true;
            this.lbPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbPrefix.Location = new System.Drawing.Point(16, 11);
            this.lbPrefix.Name = "lbPrefix";
            this.lbPrefix.Size = new System.Drawing.Size(33, 13);
            this.lbPrefix.TabIndex = 3;
            this.lbPrefix.Text = "Prefix";
            // 
            // lbLeftQuote
            // 
            this.lbLeftQuote.AutoSize = true;
            this.lbLeftQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbLeftQuote.Location = new System.Drawing.Point(94, 11);
            this.lbLeftQuote.Name = "lbLeftQuote";
            this.lbLeftQuote.Size = new System.Drawing.Size(57, 13);
            this.lbLeftQuote.TabIndex = 4;
            this.lbLeftQuote.Text = "Left Quote";
            // 
            // lbRightQuote
            // 
            this.lbRightQuote.AutoSize = true;
            this.lbRightQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbRightQuote.Location = new System.Drawing.Point(172, 11);
            this.lbRightQuote.Name = "lbRightQuote";
            this.lbRightQuote.Size = new System.Drawing.Size(64, 13);
            this.lbRightQuote.TabIndex = 5;
            this.lbRightQuote.Text = "Right Quote";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(265, 30);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 30);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(265, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtSeperator
            // 
            this.txtSeperator.Location = new System.Drawing.Point(250, 31);
            this.txtSeperator.Multiline = true;
            this.txtSeperator.Name = "txtSeperator";
            this.txtSeperator.Size = new System.Drawing.Size(72, 36);
            this.txtSeperator.TabIndex = 3;
            this.txtSeperator.TextChanged += new System.EventHandler(this.txt_seperator_TextChanged);
            // 
            // lbSeperator
            // 
            this.lbSeperator.AutoSize = true;
            this.lbSeperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbSeperator.Location = new System.Drawing.Point(250, 11);
            this.lbSeperator.Name = "lbSeperator";
            this.lbSeperator.Size = new System.Drawing.Size(53, 13);
            this.lbSeperator.TabIndex = 7;
            this.lbSeperator.Text = "Separator";
            // 
            // grpResult
            // 
            this.grpResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpResult.Location = new System.Drawing.Point(419, 301);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(584, 305);
            this.grpResult.TabIndex = 8;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(15, 26);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(550, 260);
            this.txtResult.TabIndex = 0;
            // 
            // grpSampleInput
            // 
            this.grpSampleInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSampleInput.Controls.Add(this.chkUseDefaultText);
            this.grpSampleInput.Controls.Add(this.txtSampleInput);
            this.grpSampleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpSampleInput.Location = new System.Drawing.Point(418, 11);
            this.grpSampleInput.Name = "grpSampleInput";
            this.grpSampleInput.Size = new System.Drawing.Size(584, 284);
            this.grpSampleInput.TabIndex = 9;
            this.grpSampleInput.TabStop = false;
            this.grpSampleInput.Text = "Sample Input";
            // 
            // chkUseDefaultText
            // 
            this.chkUseDefaultText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUseDefaultText.AutoSize = true;
            this.chkUseDefaultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseDefaultText.Location = new System.Drawing.Point(421, 0);
            this.chkUseDefaultText.Name = "chkUseDefaultText";
            this.chkUseDefaultText.Size = new System.Drawing.Size(144, 17);
            this.chkUseDefaultText.TabIndex = 0;
            this.chkUseDefaultText.Text = "Use Default Sample Text";
            this.chkUseDefaultText.UseVisualStyleBackColor = true;
            this.chkUseDefaultText.CheckedChanged += new System.EventHandler(this.chkUseDefaultText_CheckedChanged);
            // 
            // txtSampleInput
            // 
            this.txtSampleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSampleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSampleInput.Location = new System.Drawing.Point(15, 20);
            this.txtSampleInput.Multiline = true;
            this.txtSampleInput.Name = "txtSampleInput";
            this.txtSampleInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSampleInput.Size = new System.Drawing.Size(550, 244);
            this.txtSampleInput.TabIndex = 1;
            this.txtSampleInput.TextChanged += new System.EventHandler(this.txt_sampleInput_TextChanged);
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(328, 31);
            this.txtSuffix.Multiline = true;
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(72, 36);
            this.txtSuffix.TabIndex = 4;
            this.txtSuffix.TextChanged += new System.EventHandler(this.txt_suffix_TextChanged);
            // 
            // grpTokenizer
            // 
            this.grpTokenizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTokenizer.Controls.Add(this.chkSpace);
            this.grpTokenizer.Controls.Add(this.lb_customTokenizer);
            this.grpTokenizer.Controls.Add(this.btnOk);
            this.grpTokenizer.Controls.Add(this.txtCustomTokenizer);
            this.grpTokenizer.Controls.Add(this.btnCancel);
            this.grpTokenizer.Controls.Add(this.chkCarriageReturn);
            this.grpTokenizer.Controls.Add(this.chkLineFeed);
            this.grpTokenizer.Controls.Add(this.chkTab);
            this.grpTokenizer.Controls.Add(this.chkComma);
            this.grpTokenizer.Location = new System.Drawing.Point(16, 75);
            this.grpTokenizer.Name = "grpTokenizer";
            this.grpTokenizer.Size = new System.Drawing.Size(384, 334);
            this.grpTokenizer.TabIndex = 11;
            this.grpTokenizer.TabStop = false;
            this.grpTokenizer.Text = "Tokenizer";
            // 
            // chkSpace
            // 
            this.chkSpace.AutoSize = true;
            this.chkSpace.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpace.Location = new System.Drawing.Point(19, 192);
            this.chkSpace.Name = "chkSpace";
            this.chkSpace.Size = new System.Drawing.Size(103, 26);
            this.chkSpace.TabIndex = 4;
            this.chkSpace.Text = "\\s (Space)";
            this.chkSpace.UseVisualStyleBackColor = true;
            this.chkSpace.CheckedChanged += new System.EventHandler(this.chk_space_CheckedChanged);
            // 
            // lb_customTokenizer
            // 
            this.lb_customTokenizer.AutoSize = true;
            this.lb_customTokenizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customTokenizer.Location = new System.Drawing.Point(19, 232);
            this.lb_customTokenizer.Name = "lb_customTokenizer";
            this.lb_customTokenizer.Size = new System.Drawing.Size(311, 16);
            this.lb_customTokenizer.TabIndex = 5;
            this.lb_customTokenizer.Text = "Custom Tokenizer (seperated by comma or space)";
            // 
            // txtCustomTokenizer
            // 
            this.txtCustomTokenizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomTokenizer.Location = new System.Drawing.Point(19, 251);
            this.txtCustomTokenizer.Multiline = true;
            this.txtCustomTokenizer.Name = "txtCustomTokenizer";
            this.txtCustomTokenizer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCustomTokenizer.Size = new System.Drawing.Size(348, 61);
            this.txtCustomTokenizer.TabIndex = 5;
            this.txtCustomTokenizer.TextChanged += new System.EventHandler(this.txt_customTokenizer_TextChanged);
            // 
            // chkCarriageReturn
            // 
            this.chkCarriageReturn.AutoSize = true;
            this.chkCarriageReturn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCarriageReturn.Location = new System.Drawing.Point(19, 72);
            this.chkCarriageReturn.Name = "chkCarriageReturn";
            this.chkCarriageReturn.Size = new System.Drawing.Size(179, 26);
            this.chkCarriageReturn.TabIndex = 1;
            this.chkCarriageReturn.Text = "\\r (Carriage Return)";
            this.chkCarriageReturn.UseVisualStyleBackColor = true;
            this.chkCarriageReturn.CheckedChanged += new System.EventHandler(this.chk_carriageReturn_CheckedChanged);
            // 
            // chkLineFeed
            // 
            this.chkLineFeed.AutoSize = true;
            this.chkLineFeed.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLineFeed.Location = new System.Drawing.Point(19, 112);
            this.chkLineFeed.Name = "chkLineFeed";
            this.chkLineFeed.Size = new System.Drawing.Size(134, 26);
            this.chkLineFeed.TabIndex = 2;
            this.chkLineFeed.Text = "\\n (Line Feed)";
            this.chkLineFeed.UseVisualStyleBackColor = true;
            this.chkLineFeed.CheckedChanged += new System.EventHandler(this.chk_lineFeed_CheckedChanged);
            // 
            // chkTab
            // 
            this.chkTab.AutoSize = true;
            this.chkTab.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTab.Location = new System.Drawing.Point(19, 152);
            this.chkTab.Name = "chkTab";
            this.chkTab.Size = new System.Drawing.Size(86, 26);
            this.chkTab.TabIndex = 3;
            this.chkTab.Text = "\\t (Tab)";
            this.chkTab.UseVisualStyleBackColor = true;
            this.chkTab.CheckedChanged += new System.EventHandler(this.chk_tab_CheckedChanged);
            // 
            // chkComma
            // 
            this.chkComma.AutoSize = true;
            this.chkComma.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComma.Location = new System.Drawing.Point(19, 32);
            this.chkComma.Name = "chkComma";
            this.chkComma.Size = new System.Drawing.Size(114, 26);
            this.chkComma.TabIndex = 0;
            this.chkComma.Text = ",  (Comma)";
            this.chkComma.UseVisualStyleBackColor = true;
            this.chkComma.CheckedChanged += new System.EventHandler(this.chk_comma_CheckedChanged);
            // 
            // lbSuffix
            // 
            this.lbSuffix.AutoSize = true;
            this.lbSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbSuffix.Location = new System.Drawing.Point(328, 11);
            this.lbSuffix.Name = "lbSuffix";
            this.lbSuffix.Size = new System.Drawing.Size(33, 13);
            this.lbSuffix.TabIndex = 12;
            this.lbSuffix.Text = "Suffix";
            // 
            // grpSave
            // 
            this.grpSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpSave.Controls.Add(this.picChosenIcon);
            this.grpSave.Controls.Add(this.lbIcon);
            this.grpSave.Controls.Add(this.lbMenuItem);
            this.grpSave.Controls.Add(this.btBrowseIcon);
            this.grpSave.Controls.Add(this.txtChosenIcon);
            this.grpSave.Controls.Add(this.btnRemove);
            this.grpSave.Controls.Add(this.btnSave);
            this.grpSave.Controls.Add(this.cmboMenuItem);
            this.grpSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSave.Location = new System.Drawing.Point(16, 425);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(384, 181);
            this.grpSave.TabIndex = 14;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "Load | Save | Remove";
            // 
            // picChosenIcon
            // 
            this.picChosenIcon.Location = new System.Drawing.Point(343, 42);
            this.picChosenIcon.Name = "picChosenIcon";
            this.picChosenIcon.Size = new System.Drawing.Size(24, 24);
            this.picChosenIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChosenIcon.TabIndex = 15;
            this.picChosenIcon.TabStop = false;
            this.picChosenIcon.Visible = false;
            // 
            // lbIcon
            // 
            this.lbIcon.AutoSize = true;
            this.lbIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIcon.Location = new System.Drawing.Point(18, 28);
            this.lbIcon.Name = "lbIcon";
            this.lbIcon.Size = new System.Drawing.Size(31, 13);
            this.lbIcon.TabIndex = 15;
            this.lbIcon.Text = "Icon:";
            // 
            // lbMenuItem
            // 
            this.lbMenuItem.AutoSize = true;
            this.lbMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuItem.Location = new System.Drawing.Point(18, 74);
            this.lbMenuItem.Name = "lbMenuItem";
            this.lbMenuItem.Size = new System.Drawing.Size(68, 13);
            this.lbMenuItem.TabIndex = 16;
            this.lbMenuItem.Text = "Menu Name:";
            // 
            // btBrowseIcon
            // 
            this.btBrowseIcon.Location = new System.Drawing.Point(313, 42);
            this.btBrowseIcon.Name = "btBrowseIcon";
            this.btBrowseIcon.Size = new System.Drawing.Size(24, 24);
            this.btBrowseIcon.TabIndex = 1;
            this.btBrowseIcon.Text = "...";
            this.btBrowseIcon.UseVisualStyleBackColor = true;
            this.btBrowseIcon.Click += new System.EventHandler(this.btBrowseIcon_Click);
            // 
            // txtChosenIcon
            // 
            this.txtChosenIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChosenIcon.Location = new System.Drawing.Point(19, 44);
            this.txtChosenIcon.Name = "txtChosenIcon";
            this.txtChosenIcon.Size = new System.Drawing.Size(288, 20);
            this.txtChosenIcon.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(156, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(265, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmboMenuItem
            // 
            this.cmboMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboMenuItem.FormattingEnabled = true;
            this.cmboMenuItem.Location = new System.Drawing.Point(19, 90);
            this.cmboMenuItem.Name = "cmboMenuItem";
            this.cmboMenuItem.Size = new System.Drawing.Size(348, 21);
            this.cmboMenuItem.TabIndex = 2;
            this.cmboMenuItem.SelectedIndexChanged += new System.EventHandler(this.cmboMenuItem_SelectedIndexChanged);
            this.cmboMenuItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmboMenuItem_KeyPress);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Icon Files | *.ico; *.exe;";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 618);
            this.Controls.Add(this.lbSuffix);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpSave);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.lbPrefix);
            this.Controls.Add(this.grpTokenizer);
            this.Controls.Add(this.txtRightQuote);
            this.Controls.Add(this.txtSeperator);
            this.Controls.Add(this.lbRightQuote);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.lbSeperator);
            this.Controls.Add(this.lbLeftQuote);
            this.Controls.Add(this.txtLeftQuote);
            this.Controls.Add(this.grpSampleInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Quote it | Custom Command Editor";
            this.Load += new System.EventHandler(this.FormCustomInput_Load);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpSampleInput.ResumeLayout(false);
            this.grpSampleInput.PerformLayout();
            this.grpTokenizer.ResumeLayout(false);
            this.grpTokenizer.PerformLayout();
            this.grpSave.ResumeLayout(false);
            this.grpSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChosenIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeftQuote;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtRightQuote;
        private System.Windows.Forms.Label lbPrefix;
        private System.Windows.Forms.Label lbLeftQuote;
        private System.Windows.Forms.Label lbRightQuote;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSeperator;
        private System.Windows.Forms.Label lbSeperator;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.GroupBox grpSampleInput;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSampleInput;
        private System.Windows.Forms.GroupBox grpTokenizer;
        private System.Windows.Forms.CheckBox chkCarriageReturn;
        private System.Windows.Forms.CheckBox chkLineFeed;
        private System.Windows.Forms.CheckBox chkTab;
        private System.Windows.Forms.CheckBox chkComma;
        private System.Windows.Forms.Label lb_customTokenizer;
        private System.Windows.Forms.TextBox txtCustomTokenizer;
        private System.Windows.Forms.CheckBox chkSpace;
        private System.Windows.Forms.Label lbSuffix;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmboMenuItem;
        private System.Windows.Forms.Label lbIcon;
        private System.Windows.Forms.Label lbMenuItem;
        private System.Windows.Forms.Button btBrowseIcon;
        private System.Windows.Forms.TextBox txtChosenIcon;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox picChosenIcon;
        private System.Windows.Forms.CheckBox chkUseDefaultText;
    }
}

