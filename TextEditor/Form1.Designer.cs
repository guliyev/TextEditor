namespace TextEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TextRichBox = new System.Windows.Forms.RichTextBox();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıtalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeThroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TextRichBox
            // 
            this.TextRichBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TextRichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRichBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextRichBox.Location = new System.Drawing.Point(0, 53);
            this.TextRichBox.Name = "TextRichBox";
            this.TextRichBox.Size = new System.Drawing.Size(789, 396);
            this.TextRichBox.TabIndex = 3;
            this.TextRichBox.Text = "";
            this.TextRichBox.TextChanged += new System.EventHandler(this.TextRichBox_TextChanged);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click_2);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click_1);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click_1);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fileToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Files;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Hopstarter_Soft_Scraps_File_New;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Visualpharm_Must_Have_Open;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.saveToolStripMenuItem.Text = "&Open";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Saki_NuoveXT_2_Actions_document_save;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.saveAsToolStripMenuItem.Text = "&Save";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_print_preview;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Treetog_Junior_Printer;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Kyo_Tux_Aeon_Sign_Close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.dataTimeToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.editToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Trysoda_Soda_Red_Text_edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Visualpharm_Must_Have_Undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Visualpharm_Must_Have_Redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Simiographics_Mixed_Eraser;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Visualpharm_Must_Have_Copy_v2;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Aha_Soft_Desktop_Halloween_Hatchet;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Avosoft_Warm_Toolbar_Paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Saki_NuoveXT_2_Actions_select_all;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // dataTimeToolStripMenuItem
            // 
            this.dataTimeToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.dataTimeToolStripMenuItem.Name = "dataTimeToolStripMenuItem";
            this.dataTimeToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.dataTimeToolStripMenuItem.Text = "Data/Time";
            this.dataTimeToolStripMenuItem.Click += new System.EventHandler(this.dataTimeToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textSizeToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.ıtalicToolStripMenuItem,
            this.undoToolStripMenuItem1,
            this.strikeThroughToolStripMenuItem,
            this.fontToolStripMenuItem1,
            this.textColorToolStripMenuItem});
            this.fontToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fontToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fontToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Everaldo_Crystal_Clear_App_fonts;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Image = global::TextEditor.Properties.Resources.Iconshock_Free_Folder_Folder_fonts;
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(218, 24);
            this.fontToolStripMenuItem1.Text = "Font Color";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Icons8_Windows_8_Editing_Bold;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // ıtalicToolStripMenuItem
            // 
            this.ıtalicToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Icons8_Windows_8_Editing_Italic;
            this.ıtalicToolStripMenuItem.Name = "ıtalicToolStripMenuItem";
            this.ıtalicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ıtalicToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.ıtalicToolStripMenuItem.Text = "Italic";
            this.ıtalicToolStripMenuItem.Click += new System.EventHandler(this.ıtalicToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Image = global::TextEditor.Properties.Resources.Icons8_Windows_8_Editing_Underline;
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(218, 24);
            this.undoToolStripMenuItem1.Text = "Underline";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // strikeThroughToolStripMenuItem
            // 
            this.strikeThroughToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Icons8_Ios7_Editing_Strikethrough;
            this.strikeThroughToolStripMenuItem.Name = "strikeThroughToolStripMenuItem";
            this.strikeThroughToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.strikeThroughToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.strikeThroughToolStripMenuItem.Text = "Strike through";
            this.strikeThroughToolStripMenuItem.Click += new System.EventHandler(this.strikeThroughToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Image = global::TextEditor.Properties.Resources.Iconshock_Brilliant_Graphics_Fill;
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.textColorToolStripMenuItem.Text = "Change Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // textSizeToolStripMenuItem
            // 
            this.textSizeToolStripMenuItem.Image = global::TextEditor.Properties.Resources.if_font_size_42242;
            this.textSizeToolStripMenuItem.Name = "textSizeToolStripMenuItem";
            this.textSizeToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.textSizeToolStripMenuItem.Text = "Text Size";
            this.textSizeToolStripMenuItem.Click += new System.EventHandler(this.textSizeToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.helpToolStripMenuItem.Image = global::TextEditor.Properties.Resources.if_Help_and_support_35529;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(789, 449);
            this.Controls.Add(this.TextRichBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıtalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem strikeThroughToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem textSizeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox TextRichBox;
    }
}

