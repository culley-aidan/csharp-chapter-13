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
            this.lblQuoteTwo = new System.Windows.Forms.Label();
            this.lblQuoteThree = new System.Windows.Forms.Label();
            this.lblQuoteFour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuoteOne
            // 
            this.lblQuoteOne.AutoSize = true;
            this.lblQuoteOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteOne.Location = new System.Drawing.Point(12, 9);
            this.lblQuoteOne.Name = "lblQuoteOne";
            this.lblQuoteOne.Size = new System.Drawing.Size(402, 40);
            this.lblQuoteOne.TabIndex = 0;
            this.lblQuoteOne.Text = "War is peace. Freedom is slavery. Ignorance is strength.\r\n- George Orwell\r\n";
            this.lblQuoteOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuoteOne.MouseEnter += new System.EventHandler(this.lblQuoteOne_MouseEnter);
            this.lblQuoteOne.MouseLeave += new System.EventHandler(this.lblQuoteOne_MouseLeave);
            // 
            // lblQuoteTwo
            // 
            this.lblQuoteTwo.AutoSize = true;
            this.lblQuoteTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteTwo.Location = new System.Drawing.Point(12, 188);
            this.lblQuoteTwo.Name = "lblQuoteTwo";
            this.lblQuoteTwo.Size = new System.Drawing.Size(627, 32);
            this.lblQuoteTwo.TabIndex = 1;
            this.lblQuoteTwo.Text = "The most effective way to destroy people is to deny and obliterate their own unde" +
    "rstanding of their history.\r\n- George Orwell\r\n";
            this.lblQuoteTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuoteTwo.MouseEnter += new System.EventHandler(this.lblQuoteTwo_MouseEnter);
            this.lblQuoteTwo.MouseLeave += new System.EventHandler(this.lblQuoteTwo_MouseLeave);
            // 
            // lblQuoteThree
            // 
            this.lblQuoteThree.AutoSize = true;
            this.lblQuoteThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteThree.Location = new System.Drawing.Point(41, 75);
            this.lblQuoteThree.Name = "lblQuoteThree";
            this.lblQuoteThree.Size = new System.Drawing.Size(591, 40);
            this.lblQuoteThree.TabIndex = 2;
            this.lblQuoteThree.Text = "Censorship is telling a man he can\'t have a steak just because a baby can\'t chew " +
    "it.\r\n- Mark Twain\r\n";
            this.lblQuoteThree.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuoteThree.MouseEnter += new System.EventHandler(this.lblQuoteThree_MouseEnter);
            this.lblQuoteThree.MouseLeave += new System.EventHandler(this.lblQuoteThree_MouseLeave);
            // 
            // lblQuoteFour
            // 
            this.lblQuoteFour.AutoSize = true;
            this.lblQuoteFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteFour.Location = new System.Drawing.Point(6, 128);
            this.lblQuoteFour.Name = "lblQuoteFour";
            this.lblQuoteFour.Size = new System.Drawing.Size(408, 40);
            this.lblQuoteFour.TabIndex = 3;
            this.lblQuoteFour.Text = "If you tell the truth, you don\'t have to remember anything.\r\n- Mark Twain\r\n";
            this.lblQuoteFour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuoteFour.MouseEnter += new System.EventHandler(this.lblQuoteFour_MouseEnter);
            this.lblQuoteFour.MouseLeave += new System.EventHandler(this.lblQuoteFour_MouseLeave);
            // 
            // WordsOfWisdom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(644, 248);
            this.Controls.Add(this.lblQuoteFour);
            this.Controls.Add(this.lblQuoteThree);
            this.Controls.Add(this.lblQuoteTwo);
            this.Controls.Add(this.lblQuoteOne);
            this.Name = "WordsOfWisdom";
            this.Text = "WordsOfWisdom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuoteOne;
        private System.Windows.Forms.Label lblQuoteTwo;
        private System.Windows.Forms.Label lblQuoteThree;
        private System.Windows.Forms.Label lblQuoteFour;
    }
}

