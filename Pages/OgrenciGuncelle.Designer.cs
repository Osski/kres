namespace kres.Pages
{
    partial class OgrenciGuncelle
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtogrencino = new System.Windows.Forms.TextBox();
            this.rdbtnerk = new System.Windows.Forms.RadioButton();
            this.rdbtnkz = new System.Windows.Forms.RadioButton();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(116, 126);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(100, 20);
            this.txtadi.TabIndex = 1;
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.Location = new System.Drawing.Point(116, 152);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtsoyadi.TabIndex = 2;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(116, 178);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 20);
            this.txttc.TabIndex = 3;
            // 
            // txtogrencino
            // 
            this.txtogrencino.Location = new System.Drawing.Point(116, 204);
            this.txtogrencino.Name = "txtogrencino";
            this.txtogrencino.Size = new System.Drawing.Size(100, 20);
            this.txtogrencino.TabIndex = 4;
            // 
            // rdbtnerk
            // 
            this.rdbtnerk.AutoSize = true;
            this.rdbtnerk.Location = new System.Drawing.Point(116, 250);
            this.rdbtnerk.Name = "rdbtnerk";
            this.rdbtnerk.Size = new System.Drawing.Size(53, 17);
            this.rdbtnerk.TabIndex = 5;
            this.rdbtnerk.TabStop = true;
            this.rdbtnerk.Text = "Erkek";
            this.rdbtnerk.UseVisualStyleBackColor = true;
            // 
            // rdbtnkz
            // 
            this.rdbtnkz.AutoSize = true;
            this.rdbtnkz.Location = new System.Drawing.Point(116, 273);
            this.rdbtnkz.Name = "rdbtnkz";
            this.rdbtnkz.Size = new System.Drawing.Size(39, 17);
            this.rdbtnkz.TabIndex = 6;
            this.rdbtnkz.TabStop = true;
            this.rdbtnkz.Text = "Kız";
            this.rdbtnkz.UseVisualStyleBackColor = true;
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(103, 83);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(149, 20);
            this.datepicker.TabIndex = 7;
            this.datepicker.Value = new System.DateTime(2023, 6, 8, 0, 0, 0, 0);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(103, 319);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(133, 23);
            this.guncelle.TabIndex = 8;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // OgrenciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.rdbtnkz);
            this.Controls.Add(this.rdbtnerk);
            this.Controls.Add(this.txtogrencino);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtsoyadi);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.comboBox1);
            this.Name = "OgrenciGuncelle";
            this.Text = "OgrenciGuncelle";
            this.Load += new System.EventHandler(this.OgrenciGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtogrencino;
        private System.Windows.Forms.RadioButton rdbtnerk;
        private System.Windows.Forms.RadioButton rdbtnkz;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Button guncelle;
    }
}