namespace LibraryDatabase
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.readers = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbBooksReader = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbReaders = new System.Windows.Forms.ListBox();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.books = new System.Windows.Forms.TabPage();
            this.clbReadersBooks = new System.Windows.Forms.CheckedListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnGiveBooks = new System.Windows.Forms.Button();
            this.clbSelectBooks = new System.Windows.Forms.CheckedListBox();
            this.cbReaders = new System.Windows.Forms.ComboBox();
            this.reports = new System.Windows.Forms.TabPage();
            this.lbCountBooks = new System.Windows.Forms.ListBox();
            this.listViewDebts = new System.Windows.Forms.ListView();
            this.cbSelectedReader = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.readers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.books.SuspendLayout();
            this.reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.readers);
            this.tabControl1.Controls.Add(this.books);
            this.tabControl1.Controls.Add(this.reports);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // readers
            // 
            this.readers.Controls.Add(this.groupBox2);
            this.readers.Controls.Add(this.groupBox1);
            this.readers.Location = new System.Drawing.Point(4, 29);
            this.readers.Name = "readers";
            this.readers.Padding = new System.Windows.Forms.Padding(3);
            this.readers.Size = new System.Drawing.Size(650, 446);
            this.readers.TabIndex = 0;
            this.readers.Text = "Readers";
            this.readers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBooksReader);
            this.groupBox2.Location = new System.Drawing.Point(352, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reader Details";
            // 
            // lbBooksReader
            // 
            this.lbBooksReader.FormattingEnabled = true;
            this.lbBooksReader.ItemHeight = 20;
            this.lbBooksReader.Location = new System.Drawing.Point(6, 20);
            this.lbBooksReader.Name = "lbBooksReader";
            this.lbBooksReader.Size = new System.Drawing.Size(323, 404);
            this.lbBooksReader.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbReaders);
            this.groupBox1.Controls.Add(this.btnAddReader);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Readers List";
            // 
            // lbReaders
            // 
            this.lbReaders.FormattingEnabled = true;
            this.lbReaders.ItemHeight = 20;
            this.lbReaders.Location = new System.Drawing.Point(6, 160);
            this.lbReaders.Name = "lbReaders";
            this.lbReaders.Size = new System.Drawing.Size(323, 264);
            this.lbReaders.TabIndex = 4;
            this.lbReaders.SelectedIndexChanged += new System.EventHandler(this.lbReaders_SelectedIndexChanged);
            // 
            // btnAddReader
            // 
            this.btnAddReader.Location = new System.Drawing.Point(228, 125);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(101, 29);
            this.btnAddReader.TabIndex = 3;
            this.btnAddReader.Text = "Add Reader";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(6, 92);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.Size = new System.Drawing.Size(323, 27);
            this.tbEmail.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(6, 59);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderText = "Last Name";
            this.tbLastName.Size = new System.Drawing.Size(323, 27);
            this.tbLastName.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(6, 26);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "First Name";
            this.tbFirstName.Size = new System.Drawing.Size(323, 27);
            this.tbFirstName.TabIndex = 0;
            // 
            // books
            // 
            this.books.Controls.Add(this.clbReadersBooks);
            this.books.Controls.Add(this.btnReturn);
            this.books.Controls.Add(this.btnGiveBooks);
            this.books.Controls.Add(this.clbSelectBooks);
            this.books.Controls.Add(this.cbReaders);
            this.books.Location = new System.Drawing.Point(4, 29);
            this.books.Name = "books";
            this.books.Padding = new System.Windows.Forms.Padding(3);
            this.books.Size = new System.Drawing.Size(650, 446);
            this.books.TabIndex = 1;
            this.books.Text = "Books";
            this.books.UseVisualStyleBackColor = true;
            // 
            // clbReadersBooks
            // 
            this.clbReadersBooks.FormattingEnabled = true;
            this.clbReadersBooks.Location = new System.Drawing.Point(330, 90);
            this.clbReadersBooks.Name = "clbReadersBooks";
            this.clbReadersBooks.Size = new System.Drawing.Size(316, 356);
            this.clbReadersBooks.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(552, 50);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 29);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnGiveBooks
            // 
            this.btnGiveBooks.Location = new System.Drawing.Point(8, 50);
            this.btnGiveBooks.Name = "btnGiveBooks";
            this.btnGiveBooks.Size = new System.Drawing.Size(94, 29);
            this.btnGiveBooks.TabIndex = 2;
            this.btnGiveBooks.Text = "Give";
            this.btnGiveBooks.UseVisualStyleBackColor = true;
            this.btnGiveBooks.Click += new System.EventHandler(this.btnGiveBooks_Click);
            // 
            // clbSelectBooks
            // 
            this.clbSelectBooks.FormattingEnabled = true;
            this.clbSelectBooks.Location = new System.Drawing.Point(8, 91);
            this.clbSelectBooks.Name = "clbSelectBooks";
            this.clbSelectBooks.Size = new System.Drawing.Size(316, 356);
            this.clbSelectBooks.TabIndex = 1;
            // 
            // cbReaders
            // 
            this.cbReaders.FormattingEnabled = true;
            this.cbReaders.Location = new System.Drawing.Point(219, 6);
            this.cbReaders.Name = "cbReaders";
            this.cbReaders.Size = new System.Drawing.Size(216, 28);
            this.cbReaders.TabIndex = 0;
            this.cbReaders.SelectedIndexChanged += new System.EventHandler(this.cbReaders_SelectedIndexChanged);
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reports.Controls.Add(this.cbSelectedReader);
            this.reports.Controls.Add(this.lbCountBooks);
            this.reports.Controls.Add(this.listViewDebts);
            this.reports.Location = new System.Drawing.Point(4, 29);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(650, 446);
            this.reports.TabIndex = 2;
            this.reports.Text = "Reports";
            // 
            // lbCountBooks
            // 
            this.lbCountBooks.FormattingEnabled = true;
            this.lbCountBooks.ItemHeight = 20;
            this.lbCountBooks.Location = new System.Drawing.Point(327, 53);
            this.lbCountBooks.Name = "lbCountBooks";
            this.lbCountBooks.Size = new System.Drawing.Size(320, 384);
            this.lbCountBooks.TabIndex = 1;
            // 
            // listViewDebts
            // 
            this.listViewDebts.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewDebts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewDebts.HideSelection = false;
            this.listViewDebts.Location = new System.Drawing.Point(0, 52);
            this.listViewDebts.Name = "listViewDebts";
            this.listViewDebts.Size = new System.Drawing.Size(321, 393);
            this.listViewDebts.TabIndex = 0;
            this.listViewDebts.UseCompatibleStateImageBehavior = false;
            // 
            // cbSelectedReader
            // 
            this.cbSelectedReader.FormattingEnabled = true;
            this.cbSelectedReader.Location = new System.Drawing.Point(391, 19);
            this.cbSelectedReader.Name = "cbSelectedReader";
            this.cbSelectedReader.Size = new System.Drawing.Size(216, 28);
            this.cbSelectedReader.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.readers.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.books.ResumeLayout(false);
            this.reports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage readers;
        private System.Windows.Forms.TabPage books;
        private System.Windows.Forms.TabPage reports;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbReaders;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.CheckedListBox clbSelectBooks;
        private System.Windows.Forms.ComboBox cbReaders;
        private System.Windows.Forms.Button btnGiveBooks;
        private System.Windows.Forms.ListBox lbBooksReader;
        private System.Windows.Forms.ListView listViewDebts;
        private System.Windows.Forms.CheckedListBox clbReadersBooks;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lbCountBooks;
        private System.Windows.Forms.ComboBox cbSelectedReader;
    }
}
