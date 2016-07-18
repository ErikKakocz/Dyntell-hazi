namespace Cikkek
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LoadinStatusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.backgroundLoader = new System.ComponentModel.BackgroundWorker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.cikknevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vonalkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegiEgysegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cikknevDataGridViewTextBoxColumn,
            this.cikkszamDataGridViewTextBoxColumn,
            this.vonalkodDataGridViewTextBoxColumn,
            this.mennyisegiEgysegDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.addToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "Fájl";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "betöltés";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "mentés";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "hozzáadás";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "Új táblázat";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(91, 21);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(81, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "szerkesztés";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(12, 21);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(73, 23);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "Hozzáadás";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadinStatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(559, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LoadinStatusBar
            // 
            this.LoadinStatusBar.Name = "LoadinStatusBar";
            this.LoadinStatusBar.Size = new System.Drawing.Size(100, 16);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(364, 23);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 20);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(472, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Keresés";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // backgroundLoader
            // 
            this.backgroundLoader.WorkerReportsProgress = true;
            this.backgroundLoader.WorkerSupportsCancellation = true;
            this.backgroundLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundLoader_DoWork);
            this.backgroundLoader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundLoader_ProgressChanged);
            this.backgroundLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundLoader_RunWorkerCompleted);
            // 
            // CancelButton
            // 
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(106, 333);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 22);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Mégse";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // cikknevDataGridViewTextBoxColumn
            // 
            this.cikknevDataGridViewTextBoxColumn.DataPropertyName = "Cikknev";
            this.cikknevDataGridViewTextBoxColumn.HeaderText = "Cikknev";
            this.cikknevDataGridViewTextBoxColumn.Name = "cikknevDataGridViewTextBoxColumn";
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            // 
            // vonalkodDataGridViewTextBoxColumn
            // 
            this.vonalkodDataGridViewTextBoxColumn.DataPropertyName = "Vonalkod";
            this.vonalkodDataGridViewTextBoxColumn.HeaderText = "Vonalkod";
            this.vonalkodDataGridViewTextBoxColumn.Name = "vonalkodDataGridViewTextBoxColumn";
            // 
            // mennyisegiEgysegDataGridViewTextBoxColumn
            // 
            this.mennyisegiEgysegDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgyseg";
            this.mennyisegiEgysegDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgyseg";
            this.mennyisegiEgysegDataGridViewTextBoxColumn.Name = "mennyisegiEgysegDataGridViewTextBoxColumn";
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataSource = typeof(Cikkek.Item);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 355);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Árucikkek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ItemBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar LoadinStatusBar;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikknevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vonalkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyisegiEgysegDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchButton;
        private System.ComponentModel.BackgroundWorker backgroundLoader;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
    }
}

