
namespace WFAFundementalsContinue_0
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.txtGiris2 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(73, 245);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(94, 71);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(100, 20);
            this.txtGiris.TabIndex = 1;
            // 
            // txtGiris2
            // 
            this.txtGiris2.Location = new System.Drawing.Point(249, 71);
            this.txtGiris2.Name = "txtGiris2";
            this.txtGiris2.Size = new System.Drawing.Size(100, 20);
            this.txtGiris2.TabIndex = 2;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(94, 114);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(94, 165);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(75, 23);
            this.btnCarp.TabIndex = 3;
            this.btnCarp.Text = "x";
            this.btnCarp.UseVisualStyleBackColor = true;
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(274, 114);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 3;
            this.btnCikar.Text = "-";
            this.btnCikar.UseVisualStyleBackColor = true;
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(274, 165);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(75, 23);
            this.btnBol.TabIndex = 3;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "LUTFEN SAYI GIRINIZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtGiris2);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.btnGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.TextBox txtGiris2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label label1;
    }
}

