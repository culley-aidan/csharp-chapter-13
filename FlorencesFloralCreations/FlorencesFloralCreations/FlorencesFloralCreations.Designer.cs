namespace FlorencesFloralCreations
{
    partial class FlorencesFloralCreations
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
            this.lstOccasions = new System.Windows.Forms.ListBox();
            this.lstFlowers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstOccasions
            // 
            this.lstOccasions.FormattingEnabled = true;
            this.lstOccasions.Items.AddRange(new object[] {
            "Funeral",
            "Wedding",
            "Prison"});
            this.lstOccasions.Location = new System.Drawing.Point(13, 13);
            this.lstOccasions.Name = "lstOccasions";
            this.lstOccasions.Size = new System.Drawing.Size(120, 95);
            this.lstOccasions.TabIndex = 0;
            // 
            // lstFlowers
            // 
            this.lstFlowers.FormattingEnabled = true;
            this.lstFlowers.Location = new System.Drawing.Point(140, 13);
            this.lstFlowers.Name = "lstFlowers";
            this.lstFlowers.Size = new System.Drawing.Size(120, 95);
            this.lstFlowers.TabIndex = 1;
            // 
            // FlorencesFloralCreations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFlowers);
            this.Controls.Add(this.lstOccasions);
            this.Name = "FlorencesFloralCreations";
            this.Text = "FlorencesFloralCreation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOccasions;
        private System.Windows.Forms.ListBox lstFlowers;
    }
}

