namespace Quantum_Commander
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
            this.tabOneBinding = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabTwoBinding = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.currentDirTabOneTextBox = new System.Windows.Forms.TextBox();
            this.currentDirTabTwoTextBox = new System.Windows.Forms.TextBox();
            this.elementNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemElementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.elementNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabOneBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTwoBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemElementBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemElementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elementNameDataGridViewTextBoxColumn1,
            this.extensionDataGridViewTextBoxColumn1,
            this.modificationDateDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.tabOneBinding;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(342, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // tabOneBinding
            // 
            this.tabOneBinding.DataSource = this.fileSystemElementBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elementNameDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.modificationDateDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tabTwoBinding;
            this.dataGridView2.Location = new System.Drawing.Point(348, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(339, 273);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // tabTwoBinding
            // 
            this.tabTwoBinding.DataSource = this.fileSystemElementBindingSource1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // currentDirTabOneTextBox
            // 
            this.currentDirTabOneTextBox.Location = new System.Drawing.Point(0, 28);
            this.currentDirTabOneTextBox.Name = "currentDirTabOneTextBox";
            this.currentDirTabOneTextBox.Size = new System.Drawing.Size(342, 20);
            this.currentDirTabOneTextBox.TabIndex = 3;
            this.currentDirTabOneTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currentDirTabOneTextBox_KeyDown);
            // 
            // currentDirTabTwoTextBox
            // 
            this.currentDirTabTwoTextBox.Location = new System.Drawing.Point(348, 27);
            this.currentDirTabTwoTextBox.Name = "currentDirTabTwoTextBox";
            this.currentDirTabTwoTextBox.Size = new System.Drawing.Size(339, 20);
            this.currentDirTabTwoTextBox.TabIndex = 4;
            this.currentDirTabTwoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currentDirTabTwoTextBox_KeyDown);
            // 
            // elementNameDataGridViewTextBoxColumn
            // 
            this.elementNameDataGridViewTextBoxColumn.DataPropertyName = "ElementName";
            this.elementNameDataGridViewTextBoxColumn.HeaderText = "ElementName";
            this.elementNameDataGridViewTextBoxColumn.Name = "elementNameDataGridViewTextBoxColumn";
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            // 
            // modificationDateDataGridViewTextBoxColumn
            // 
            this.modificationDateDataGridViewTextBoxColumn.DataPropertyName = "ModificationDate";
            this.modificationDateDataGridViewTextBoxColumn.HeaderText = "ModificationDate";
            this.modificationDateDataGridViewTextBoxColumn.Name = "modificationDateDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // fileSystemElementBindingSource1
            // 
            this.fileSystemElementBindingSource1.DataSource = typeof(Quantum_Commander.FileSystemElement);
            // 
            // elementNameDataGridViewTextBoxColumn1
            // 
            this.elementNameDataGridViewTextBoxColumn1.DataPropertyName = "ElementName";
            this.elementNameDataGridViewTextBoxColumn1.HeaderText = "ElementName";
            this.elementNameDataGridViewTextBoxColumn1.Name = "elementNameDataGridViewTextBoxColumn1";
            this.elementNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // extensionDataGridViewTextBoxColumn1
            // 
            this.extensionDataGridViewTextBoxColumn1.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn1.HeaderText = "Extension";
            this.extensionDataGridViewTextBoxColumn1.Name = "extensionDataGridViewTextBoxColumn1";
            this.extensionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modificationDateDataGridViewTextBoxColumn1
            // 
            this.modificationDateDataGridViewTextBoxColumn1.DataPropertyName = "ModificationDate";
            this.modificationDateDataGridViewTextBoxColumn1.HeaderText = "ModificationDate";
            this.modificationDateDataGridViewTextBoxColumn1.Name = "modificationDateDataGridViewTextBoxColumn1";
            this.modificationDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn1
            // 
            this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn1.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
            this.sizeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fileSystemElementBindingSource
            // 
            this.fileSystemElementBindingSource.DataSource = typeof(Quantum_Commander.FileSystemElement);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 380);
            this.Controls.Add(this.currentDirTabTwoTextBox);
            this.Controls.Add(this.currentDirTabOneTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quantum Commander";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabOneBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTwoBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemElementBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemElementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource tabOneBinding;
        private System.Windows.Forms.BindingSource tabTwoBinding;
        private System.Windows.Forms.BindingSource fileSystemElementBindingSource1;
        private System.Windows.Forms.BindingSource fileSystemElementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox currentDirTabOneTextBox;
        private System.Windows.Forms.TextBox currentDirTabTwoTextBox;
    }
}

