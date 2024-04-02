namespace Other_Tools
{
    partial class Crypto
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
            this.WebViewTrading = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.OpenCrypto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WebViewTrading)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebViewTrading
            // 
            this.WebViewTrading.AllowExternalDrop = true;
            this.WebViewTrading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebViewTrading.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.WebViewTrading.CreationProperties = null;
            this.WebViewTrading.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.WebViewTrading.Location = new System.Drawing.Point(0, 26);
            this.WebViewTrading.Name = "WebViewTrading";
            this.WebViewTrading.Size = new System.Drawing.Size(853, 537);
            this.WebViewTrading.TabIndex = 11;
            this.WebViewTrading.ZoomFactor = 1D;
            // 
            // OpenCrypto
            // 
            this.OpenCrypto.BackgroundImage = global::Other_Tools.Properties.Resources.share;
            this.OpenCrypto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenCrypto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCrypto.Location = new System.Drawing.Point(3, 0);
            this.OpenCrypto.Name = "OpenCrypto";
            this.OpenCrypto.Size = new System.Drawing.Size(30, 30);
            this.OpenCrypto.TabIndex = 15;
            this.OpenCrypto.UseVisualStyleBackColor = true;
            this.OpenCrypto.Click += new System.EventHandler(this.OpenCrypto_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.OpenCrypto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 30);
            this.panel1.TabIndex = 16;
            // 
            // Crypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 563);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WebViewTrading);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crypto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Crypto";
            this.Load += new System.EventHandler(this.Crypto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebViewTrading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WebViewTrading;
        private System.Windows.Forms.Button OpenCrypto;
        private System.Windows.Forms.Panel panel1;
    }
}