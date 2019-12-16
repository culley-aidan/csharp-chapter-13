namespace WordsOfWisdom
{
    partial class WordsOfWisdom
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
            this.lblQuoteOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuoteOne
            // 
            this.lblQuoteOne.AutoSize = true;
            this.lblQuoteOne.Location = new System.Drawing.Point(13, 13);
            this.lblQuoteOne.Name = "lblQuoteOne";
            this.lblQuoteOne.Size = new System.Drawing.Size(271, 26);
            this.lblQuoteOne.TabIndex = 0;
            this.lblQuoteOne.Text = "War is peace. Freedom is slavery. Ignorance is strength.\r\n- George Orwell\r\n";
            this.lblQuoteOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WordsOfWisdom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuoteOne);
            this.Name = "WordsOfWisdom";
            this.Text = "WordsOfWisdom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuoteOne;
    }
}

