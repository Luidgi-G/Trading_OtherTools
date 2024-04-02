namespace Other_Tools
{
    partial class TradingCrypto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VotreInvestissementBox = new System.Windows.Forms.TextBox();
            this.DividendeBox = new System.Windows.Forms.TextBox();
            this.Calculer = new System.Windows.Forms.Button();
            this.Résultat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre investissement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dividende en %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Résultat en €";
            // 
            // VotreInvestissementBox
            // 
            this.VotreInvestissementBox.Location = new System.Drawing.Point(119, 48);
            this.VotreInvestissementBox.Name = "VotreInvestissementBox";
            this.VotreInvestissementBox.Size = new System.Drawing.Size(100, 20);
            this.VotreInvestissementBox.TabIndex = 3;
            // 
            // DividendeBox
            // 
            this.DividendeBox.Location = new System.Drawing.Point(119, 78);
            this.DividendeBox.Name = "DividendeBox";
            this.DividendeBox.Size = new System.Drawing.Size(100, 20);
            this.DividendeBox.TabIndex = 4;
            // 
            // Calculer
            // 
            this.Calculer.Location = new System.Drawing.Point(119, 127);
            this.Calculer.Name = "Calculer";
            this.Calculer.Size = new System.Drawing.Size(100, 39);
            this.Calculer.TabIndex = 6;
            this.Calculer.Text = "Calculer";
            this.Calculer.UseVisualStyleBackColor = true;
            this.Calculer.Click += new System.EventHandler(this.Calculer_Click);
            // 
            // Résultat
            // 
            this.Résultat.Location = new System.Drawing.Point(119, 104);
            this.Résultat.Name = "Résultat";
            this.Résultat.Size = new System.Drawing.Size(100, 20);
            this.Résultat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Calcule du rendement du dividende";
            // 
            // webView22
            // 
            this.webView22.AllowExternalDrop = true;
            this.webView22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView22.CreationProperties = null;
            this.webView22.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView22.Location = new System.Drawing.Point(247, 0);
            this.webView22.Name = "webView22";
            this.webView22.Size = new System.Drawing.Size(465, 531);
            this.webView22.TabIndex = 13;
            this.webView22.ZoomFactor = 1D;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Résultat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Calculer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DividendeBox);
            this.panel1.Controls.Add(this.VotreInvestissementBox);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 185);
            this.panel1.TabIndex = 14;
            // 
            // TradingCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 531);
            this.Controls.Add(this.webView22);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TradingCrypto";
            this.Text = "Trading & Crypto";
            this.Load += new System.EventHandler(this.TradingCrypto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VotreInvestissementBox;
        private System.Windows.Forms.TextBox DividendeBox;
        private System.Windows.Forms.Button Calculer;
        private System.Windows.Forms.Label Résultat;
        private System.Windows.Forms.Label label4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private System.Windows.Forms.Panel panel1;
    }
}