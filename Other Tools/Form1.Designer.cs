namespace Other_Tools
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button TradingCrypto;
            this.label1 = new System.Windows.Forms.Label();
            TradingCrypto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TradingCrypto
            // 
            TradingCrypto.BackgroundImage = global::Other_Tools.Properties.Resources.wallet;
            TradingCrypto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            TradingCrypto.Location = new System.Drawing.Point(12, 12);
            TradingCrypto.Name = "TradingCrypto";
            TradingCrypto.Size = new System.Drawing.Size(140, 140);
            TradingCrypto.TabIndex = 0;
            TradingCrypto.UseVisualStyleBackColor = true;
            TradingCrypto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mon portefeuille \r\nTrading - Crypto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(TradingCrypto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

