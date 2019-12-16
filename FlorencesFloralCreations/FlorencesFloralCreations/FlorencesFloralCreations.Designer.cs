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
            this.lblCongrats = new System.Windows.Forms.Label();
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
            this.lstOccasions.SelectedIndexChanged += new System.EventHandler(this.lstOccasions_SelectedIndexChanged);
            // 
            // lstFlowers
            // 
            this.lstFlowers.FormattingEnabled = true;
            this.lstFlowers.Location = new System.Drawing.Point(140, 13);
            this.lstFlowers.Name = "lstFlowers";
            this.lstFlowers.Size = new System.Drawing.Size(120, 95);
            this.lstFlowers.TabIndex = 1;
            this.lstFlowers.SelectedIndexChanged += new System.EventHandler(this.lstFlowers_SelectedIndexChanged);
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Location = new System.Drawing.Point(13, 115);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(0, 13);
            this.lblCongrats.TabIndex = 2;
            this.lblCongrats.Visible = false;
            // 
            // FlorencesFloralCreations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 169);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.lstFlowers);
            this.Controls.Add(this.lstOccasions);
            this.Name = "FlorencesFloralCreations";
            this.Text = "FlorencesFloralCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOccasions;
        private System.Windows.Forms.ListBox lstFlowers;
        private System.Windows.Forms.Label lblCongrats;
    }
}

