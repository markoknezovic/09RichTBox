﻿namespace RichTxtBox_kontrola
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
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnCitaj = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(80, 84);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(186, 136);
            this.rtbIspis.TabIndex = 0;
            this.rtbIspis.Text = "";
            this.rtbIspis.TextChanged += new System.EventHandler(this.rtbIspis_TextChanged);
            // 
            // btnCitaj
            // 
            this.btnCitaj.Location = new System.Drawing.Point(80, 55);
            this.btnCitaj.Name = "btnCitaj";
            this.btnCitaj.Size = new System.Drawing.Size(75, 23);
            this.btnCitaj.TabIndex = 1;
            this.btnCitaj.Text = "Citaj";
            this.btnCitaj.UseVisualStyleBackColor = true;
            this.btnCitaj.Click += new System.EventHandler(this.btnCitaj_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(191, 55);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 2;
            this.btnBrisi.Text = "brisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(80, 226);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 307);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnCitaj);
            this.Controls.Add(this.rtbIspis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnCitaj;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnSpremi;
    }
}

