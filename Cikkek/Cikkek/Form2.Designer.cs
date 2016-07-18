namespace Cikkek
{
    partial class Form2
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
            this.Cikknev = new System.Windows.Forms.TextBox();
            this.Vonalkod = new System.Windows.Forms.TextBox();
            this.Cikkszam = new System.Windows.Forms.TextBox();
            this.MennyisegEgyseg = new System.Windows.Forms.ComboBox();
            this.CikknevLabel = new System.Windows.Forms.Label();
            this.CikkszamLabel = new System.Windows.Forms.Label();
            this.VonalkodLabel = new System.Windows.Forms.Label();
            this.MennyisegEgysegLabel = new System.Windows.Forms.Label();
            this.MEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cikknev
            // 
            this.Cikknev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ItemBindingSource, "Cikknev", true));
            this.Cikknev.Location = new System.Drawing.Point(126, 42);
            this.Cikknev.Name = "Cikknev";
            this.Cikknev.Size = new System.Drawing.Size(121, 20);
            this.Cikknev.TabIndex = 0;
            // 
            // Vonalkod
            // 
            this.Vonalkod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ItemBindingSource, "Vonalkod", true));
            this.Vonalkod.Location = new System.Drawing.Point(126, 116);
            this.Vonalkod.Name = "Vonalkod";
            this.Vonalkod.Size = new System.Drawing.Size(121, 20);
            this.Vonalkod.TabIndex = 1;
            // 
            // Cikkszam
            // 
            this.Cikkszam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ItemBindingSource, "Cikkszam", true));
            this.Cikkszam.Location = new System.Drawing.Point(126, 78);
            this.Cikkszam.Name = "Cikkszam";
            this.Cikkszam.Size = new System.Drawing.Size(121, 20);
            this.Cikkszam.TabIndex = 2;
            // 
            // MennyisegEgyseg
            // 
            this.MennyisegEgyseg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ItemBindingSource, "MennyisegiEgyseg", true));
            this.MennyisegEgyseg.DataSource = this.MEBindingSource;
            this.MennyisegEgyseg.FormattingEnabled = true;
            this.MennyisegEgyseg.Location = new System.Drawing.Point(126, 155);
            this.MennyisegEgyseg.Name = "MennyisegEgyseg";
            this.MennyisegEgyseg.Size = new System.Drawing.Size(121, 21);
            this.MennyisegEgyseg.TabIndex = 3;
            // 
            // CikknevLabel
            // 
            this.CikknevLabel.AutoSize = true;
            this.CikknevLabel.Location = new System.Drawing.Point(27, 45);
            this.CikknevLabel.Name = "CikknevLabel";
            this.CikknevLabel.Size = new System.Drawing.Size(46, 13);
            this.CikknevLabel.TabIndex = 4;
            this.CikknevLabel.Text = "Cikknev";
            // 
            // CikkszamLabel
            // 
            this.CikkszamLabel.AutoSize = true;
            this.CikkszamLabel.Location = new System.Drawing.Point(27, 81);
            this.CikkszamLabel.Name = "CikkszamLabel";
            this.CikkszamLabel.Size = new System.Drawing.Size(52, 13);
            this.CikkszamLabel.TabIndex = 5;
            this.CikkszamLabel.Text = "Cikkszam";
            // 
            // VonalkodLabel
            // 
            this.VonalkodLabel.AutoSize = true;
            this.VonalkodLabel.Location = new System.Drawing.Point(27, 119);
            this.VonalkodLabel.Name = "VonalkodLabel";
            this.VonalkodLabel.Size = new System.Drawing.Size(52, 13);
            this.VonalkodLabel.TabIndex = 6;
            this.VonalkodLabel.Text = "Vonalkod";
            // 
            // MennyisegEgysegLabel
            // 
            this.MennyisegEgysegLabel.AutoSize = true;
            this.MennyisegEgysegLabel.Location = new System.Drawing.Point(27, 158);
            this.MennyisegEgysegLabel.Name = "MennyisegEgysegLabel";
            this.MennyisegEgysegLabel.Size = new System.Drawing.Size(93, 13);
            this.MennyisegEgysegLabel.TabIndex = 7;
            this.MennyisegEgysegLabel.Text = "MennyisegEgyseg";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(30, 204);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(172, 204);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataSource = typeof(Cikkek.Item);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MennyisegEgysegLabel);
            this.Controls.Add(this.VonalkodLabel);
            this.Controls.Add(this.CikkszamLabel);
            this.Controls.Add(this.CikknevLabel);
            this.Controls.Add(this.MennyisegEgyseg);
            this.Controls.Add(this.Cikkszam);
            this.Controls.Add(this.Vonalkod);
            this.Controls.Add(this.Cikknev);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ItemBindingSource;
        private System.Windows.Forms.TextBox Cikknev;
        private System.Windows.Forms.TextBox Vonalkod;
        private System.Windows.Forms.TextBox Cikkszam;
        private System.Windows.Forms.ComboBox MennyisegEgyseg;
        private System.Windows.Forms.Label CikknevLabel;
        private System.Windows.Forms.Label CikkszamLabel;
        private System.Windows.Forms.Label VonalkodLabel;
        private System.Windows.Forms.Label MennyisegEgysegLabel;
        private System.Windows.Forms.BindingSource MEBindingSource;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}