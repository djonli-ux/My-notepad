namespace HwUniversity
{
    partial class TextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnOpen = new Button();
            tbFileName = new TextBox();
            rtField = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            lblCharacters = new Label();
            lblWords = new Label();
            lblVowels = new Label();
            lblConsonants = new Label();
            lblParagraphs = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            chooseAnoterFileToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            onToolStripMenuItem = new ToolStripMenuItem();
            oFFToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            findAnyEmailToolStripMenuItem = new ToolStripMenuItem();
            findUniqueWordInTehTextToolStripMenuItem = new ToolStripMenuItem();
            uploadToolStripMenuItem = new ToolStripMenuItem();
            uploadArticleFromWebsiteZnuToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            btnSaveChanges = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Current File:";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(34, 77);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // tbFileName
            // 
            tbFileName.Enabled = false;
            tbFileName.Location = new Point(153, 78);
            tbFileName.Name = "tbFileName";
            tbFileName.ReadOnly = true;
            tbFileName.Size = new Size(388, 27);
            tbFileName.TabIndex = 2;
            // 
            // rtField
            // 
            rtField.Location = new Point(34, 200);
            rtField.Name = "rtField";
            rtField.Size = new Size(507, 348);
            rtField.TabIndex = 3;
            rtField.Text = "";
            // 
            // lblCharacters
            // 
            lblCharacters.AutoSize = true;
            lblCharacters.Location = new Point(34, 123);
            lblCharacters.Name = "lblCharacters";
            lblCharacters.Size = new Size(81, 20);
            lblCharacters.TabIndex = 4;
            lblCharacters.Text = "Characters:";
            lblCharacters.Visible = false;
            // 
            // lblWords
            // 
            lblWords.AutoSize = true;
            lblWords.Location = new Point(34, 166);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(54, 20);
            lblWords.TabIndex = 5;
            lblWords.Text = "Words:";
            lblWords.Visible = false;
            // 
            // lblVowels
            // 
            lblVowels.AutoSize = true;
            lblVowels.Location = new Point(219, 166);
            lblVowels.Name = "lblVowels";
            lblVowels.Size = new Size(58, 20);
            lblVowels.TabIndex = 7;
            lblVowels.Text = "Vowels:";
            lblVowels.Visible = false;
            // 
            // lblConsonants
            // 
            lblConsonants.AutoSize = true;
            lblConsonants.Location = new Point(219, 123);
            lblConsonants.Name = "lblConsonants";
            lblConsonants.Size = new Size(88, 20);
            lblConsonants.TabIndex = 6;
            lblConsonants.Text = "Consonants:";
            lblConsonants.Visible = false;
            // 
            // lblParagraphs
            // 
            lblParagraphs.AutoSize = true;
            lblParagraphs.Location = new Point(386, 166);
            lblParagraphs.Name = "lblParagraphs";
            lblParagraphs.Size = new Size(85, 20);
            lblParagraphs.TabIndex = 8;
            lblParagraphs.Text = "Paragraphs:";
            lblParagraphs.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, statisticsToolStripMenuItem, searchToolStripMenuItem, uploadToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(580, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseAnoterFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // chooseAnoterFileToolStripMenuItem
            // 
            chooseAnoterFileToolStripMenuItem.Name = "chooseAnoterFileToolStripMenuItem";
            chooseAnoterFileToolStripMenuItem.Size = new Size(213, 26);
            chooseAnoterFileToolStripMenuItem.Text = "Choose anoter file";
            chooseAnoterFileToolStripMenuItem.Click += chooseAnoterFileToolStripMenuItem_Click;
            // 
            // statisticsToolStripMenuItem
            // 
            statisticsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { onToolStripMenuItem, oFFToolStripMenuItem });
            statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            statisticsToolStripMenuItem.Size = new Size(81, 24);
            statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // onToolStripMenuItem
            // 
            onToolStripMenuItem.Name = "onToolStripMenuItem";
            onToolStripMenuItem.Size = new Size(113, 26);
            onToolStripMenuItem.Text = "On";
            onToolStripMenuItem.Click += onToolStripMenuItem_Click;
            // 
            // oFFToolStripMenuItem
            // 
            oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
            oFFToolStripMenuItem.Size = new Size(113, 26);
            oFFToolStripMenuItem.Text = "Off";
            oFFToolStripMenuItem.Click += offToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findAnyEmailToolStripMenuItem, findUniqueWordInTehTextToolStripMenuItem });
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(67, 24);
            searchToolStripMenuItem.Text = "Search";
            // 
            // findAnyEmailToolStripMenuItem
            // 
            findAnyEmailToolStripMenuItem.Name = "findAnyEmailToolStripMenuItem";
            findAnyEmailToolStripMenuItem.Size = new Size(283, 26);
            findAnyEmailToolStripMenuItem.Text = "Find any email in the text";
            findAnyEmailToolStripMenuItem.Click += findAnyEmailToolStripMenuItem_Click;
            // 
            // findUniqueWordInTehTextToolStripMenuItem
            // 
            findUniqueWordInTehTextToolStripMenuItem.Name = "findUniqueWordInTehTextToolStripMenuItem";
            findUniqueWordInTehTextToolStripMenuItem.Size = new Size(283, 26);
            findUniqueWordInTehTextToolStripMenuItem.Text = "Find unique words in the text";
            findUniqueWordInTehTextToolStripMenuItem.Click += findUniqueWordInTehTextToolStripMenuItem_Click;
            // 
            // uploadToolStripMenuItem
            // 
            uploadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uploadArticleFromWebsiteZnuToolStripMenuItem });
            uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            uploadToolStripMenuItem.Size = new Size(72, 24);
            uploadToolStripMenuItem.Text = "Upload";
            // 
            // uploadArticleFromWebsiteZnuToolStripMenuItem
            // 
            uploadArticleFromWebsiteZnuToolStripMenuItem.Name = "uploadArticleFromWebsiteZnuToolStripMenuItem";
            uploadArticleFromWebsiteZnuToolStripMenuItem.Size = new Size(277, 26);
            uploadArticleFromWebsiteZnuToolStripMenuItem.Text = "Upload article from website";
            uploadArticleFromWebsiteZnuToolStripMenuItem.Click += uploadArticleFromWebsiteZnuToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(447, 560);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(94, 29);
            btnSaveChanges.TabIndex = 10;
            btnSaveChanges.Text = "Save";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 601);
            Controls.Add(btnSaveChanges);
            Controls.Add(menuStrip1);
            Controls.Add(lblParagraphs);
            Controls.Add(lblVowels);
            Controls.Add(lblConsonants);
            Controls.Add(lblWords);
            Controls.Add(lblCharacters);
            Controls.Add(rtField);
            Controls.Add(tbFileName);
            Controls.Add(btnOpen);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "TextEditor";
            Text = "Text Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOpen;
        private TextBox tbFileName;
        private RichTextBox rtField;
        private SaveFileDialog saveFileDialog1;
        private Label lblCharacters;
        private Label lblWords;
        private Label lblVowels;
        private Label lblConsonants;
        private Label lblParagraphs;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem chooseAnoterFileToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem oFFToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem findAnyEmailToolStripMenuItem;
        private ToolStripMenuItem findUniqueWordInTehTextToolStripMenuItem;
        private Button btnSaveChanges;
        private ToolStripMenuItem uploadToolStripMenuItem;
        private ToolStripMenuItem uploadArticleFromWebsiteZnuToolStripMenuItem;
    }
}
