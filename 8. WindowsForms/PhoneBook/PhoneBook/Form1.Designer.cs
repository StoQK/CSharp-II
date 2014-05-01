namespace PhoneBook
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.listBoxItemsCollection = new System.Windows.Forms.ListBox();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.buttonDeleteContact = new System.Windows.Forms.Button();
            this.buttonLoadContacts = new System.Windows.Forms.Button();
            this.buttonSearchByName = new System.Windows.Forms.Button();
            this.buttonSearchByNumber = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(116, 56);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(131, 22);
            this.TextBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number:";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(418, 59);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(131, 22);
            this.TextBoxPhone.TabIndex = 4;
            // 
            // listBoxItemsCollection
            // 
            this.listBoxItemsCollection.FormattingEnabled = true;
            this.listBoxItemsCollection.ItemHeight = 16;
            this.listBoxItemsCollection.Location = new System.Drawing.Point(200, 200);
            this.listBoxItemsCollection.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxItemsCollection.Name = "listBoxItemsCollection";
            this.listBoxItemsCollection.ScrollAlwaysVisible = true;
            this.listBoxItemsCollection.Size = new System.Drawing.Size(191, 196);
            this.listBoxItemsCollection.TabIndex = 5;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(116, 121);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(111, 26);
            this.buttonAddContact.TabIndex = 6;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // buttonDeleteContact
            // 
            this.buttonDeleteContact.Location = new System.Drawing.Point(233, 121);
            this.buttonDeleteContact.Name = "buttonDeleteContact";
            this.buttonDeleteContact.Size = new System.Drawing.Size(111, 26);
            this.buttonDeleteContact.TabIndex = 7;
            this.buttonDeleteContact.Text = "Delete Contact";
            this.buttonDeleteContact.UseVisualStyleBackColor = true;
            this.buttonDeleteContact.Click += new System.EventHandler(this.buttonDeleteContact_Click);
            // 
            // buttonLoadContacts
            // 
            this.buttonLoadContacts.Location = new System.Drawing.Point(350, 121);
            this.buttonLoadContacts.Name = "buttonLoadContacts";
            this.buttonLoadContacts.Size = new System.Drawing.Size(120, 26);
            this.buttonLoadContacts.TabIndex = 8;
            this.buttonLoadContacts.Text = "Load Contacts";
            this.buttonLoadContacts.UseVisualStyleBackColor = true;
            this.buttonLoadContacts.Click += new System.EventHandler(this.buttonLoadContacts_Click);
            // 
            // buttonSearchByName
            // 
            this.buttonSearchByName.Location = new System.Drawing.Point(44, 200);
            this.buttonSearchByName.Name = "buttonSearchByName";
            this.buttonSearchByName.Size = new System.Drawing.Size(128, 30);
            this.buttonSearchByName.TabIndex = 9;
            this.buttonSearchByName.Text = "Search by Name";
            this.buttonSearchByName.UseVisualStyleBackColor = true;
            this.buttonSearchByName.Click += new System.EventHandler(this.buttonSearchByName_Click);
            // 
            // buttonSearchByNumber
            // 
            this.buttonSearchByNumber.Location = new System.Drawing.Point(418, 200);
            this.buttonSearchByNumber.Name = "buttonSearchByNumber";
            this.buttonSearchByNumber.Size = new System.Drawing.Size(137, 30);
            this.buttonSearchByNumber.TabIndex = 11;
            this.buttonSearchByNumber.Text = "Search by Number";
            this.buttonSearchByNumber.UseVisualStyleBackColor = true;
            this.buttonSearchByNumber.Click += new System.EventHandler(this.buttonSearchByNumber_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(483, 411);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 33);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 456);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearchByNumber);
            this.Controls.Add(this.buttonSearchByName);
            this.Controls.Add(this.buttonLoadContacts);
            this.Controls.Add(this.buttonDeleteContact);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.listBoxItemsCollection);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Phone Book";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.ListBox listBoxItemsCollection;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Button buttonDeleteContact;
        private System.Windows.Forms.Button buttonLoadContacts;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button buttonSearchByName;
        private System.Windows.Forms.Button buttonSearchByNumber;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonExit;
    }
}

