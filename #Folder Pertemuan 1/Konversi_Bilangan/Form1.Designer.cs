namespace Konversi_Suhu
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
            this.lblCelcius = new System.Windows.Forms.Label();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCelcius
            // 
            this.lblCelcius.AutoSize = true;
            this.lblCelcius.Location = new System.Drawing.Point(29, 53);
            this.lblCelcius.Name = "lblCelcius";
            this.lblCelcius.Size = new System.Drawing.Size(84, 15);
            this.lblCelcius.TabIndex = 0;
            this.lblCelcius.Text = "Input (Celcius)";
            this.lblCelcius.Click += new System.EventHandler(this.lblCelcius_Click);
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(308, 49);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(75, 23);
            this.btnKonversi.TabIndex = 1;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(389, 49);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(145, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(157, 23);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 170);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.lblCelcius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCelcius;
        private Button btnKonversi;
        private Button btnKeluar;
        private TextBox txtInput;
    }
}