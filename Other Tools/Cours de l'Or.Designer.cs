namespace Other_Tools
{
    partial class Cours_de_l_Or
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.OrGrHistory = new System.Windows.Forms.Button();
            this.OrKgHistory = new System.Windows.Forms.Button();
            this.OrKgDirect = new System.Windows.Forms.Button();
            this.OrGrDirect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 35);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(800, 415);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // OrGrHistory
            // 
            this.OrGrHistory.AutoSize = true;
            this.OrGrHistory.Location = new System.Drawing.Point(366, 6);
            this.OrGrHistory.Name = "OrGrHistory";
            this.OrGrHistory.Size = new System.Drawing.Size(105, 23);
            this.OrGrHistory.TabIndex = 1;
            this.OrGrHistory.Text = "Or en Gr historique";
            this.OrGrHistory.UseVisualStyleBackColor = true;
            this.OrGrHistory.Click += new System.EventHandler(this.OrGr_Click);
            // 
            // OrKgHistory
            // 
            this.OrKgHistory.AutoSize = true;
            this.OrKgHistory.Location = new System.Drawing.Point(253, 6);
            this.OrKgHistory.Name = "OrKgHistory";
            this.OrKgHistory.Size = new System.Drawing.Size(107, 23);
            this.OrKgHistory.TabIndex = 2;
            this.OrKgHistory.Text = "Or en Kg historique";
            this.OrKgHistory.UseVisualStyleBackColor = true;
            this.OrKgHistory.Click += new System.EventHandler(this.OrKg_Click);
            // 
            // OrKgDirect
            // 
            this.OrKgDirect.AutoSize = true;
            this.OrKgDirect.Location = new System.Drawing.Point(20, 6);
            this.OrKgDirect.Name = "OrKgDirect";
            this.OrKgDirect.Size = new System.Drawing.Size(103, 23);
            this.OrKgDirect.TabIndex = 4;
            this.OrKgDirect.Text = "Or en Kg en direct";
            this.OrKgDirect.UseVisualStyleBackColor = true;
            this.OrKgDirect.Click += new System.EventHandler(this.OrKgDirect_Click);
            // 
            // OrGrDirect
            // 
            this.OrGrDirect.AutoSize = true;
            this.OrGrDirect.Location = new System.Drawing.Point(129, 6);
            this.OrGrDirect.Name = "OrGrDirect";
            this.OrGrDirect.Size = new System.Drawing.Size(101, 23);
            this.OrGrDirect.TabIndex = 3;
            this.OrGrDirect.Text = "Or en Gr en direct";
            this.OrGrDirect.UseVisualStyleBackColor = true;
            this.OrGrDirect.Click += new System.EventHandler(this.OrGrDirect_Click);
            // 
            // Cours_de_l_Or
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrKgDirect);
            this.Controls.Add(this.OrGrDirect);
            this.Controls.Add(this.OrKgHistory);
            this.Controls.Add(this.OrGrHistory);
            this.Controls.Add(this.webView21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cours_de_l_Or";
            this.Text = "Cours_de_l_Or";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button OrGrHistory;
        private System.Windows.Forms.Button OrKgHistory;
        private System.Windows.Forms.Button OrKgDirect;
        private System.Windows.Forms.Button OrGrDirect;
    }
}