namespace WUI
{
    partial class FrmLanguage
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
            this.BtnLoadLanguages = new System.Windows.Forms.Button();
            this.TxtLanguages = new System.Windows.Forms.TextBox();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLoadLanguages
            // 
            this.BtnLoadLanguages.Location = new System.Drawing.Point(83, 24);
            this.BtnLoadLanguages.Name = "BtnLoadLanguages";
            this.BtnLoadLanguages.Size = new System.Drawing.Size(117, 23);
            this.BtnLoadLanguages.TabIndex = 0;
            this.BtnLoadLanguages.Text = "Charger les langues";
            this.BtnLoadLanguages.UseVisualStyleBackColor = true;
            this.BtnLoadLanguages.Click += new System.EventHandler(this.BtnLoadLanguages_Click);
            // 
            // TxtLanguages
            // 
            this.TxtLanguages.Location = new System.Drawing.Point(12, 70);
            this.TxtLanguages.Multiline = true;
            this.TxtLanguages.Name = "TxtLanguages";
            this.TxtLanguages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLanguages.Size = new System.Drawing.Size(775, 454);
            this.TxtLanguages.TabIndex = 1;
            this.TxtLanguages.TextChanged += new System.EventHandler(this.TxtLanguages_TextChanged);
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(377, 24);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(75, 23);
            this.BtnDisplay.TabIndex = 2;
            this.BtnDisplay.Text = "Afficher ";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 536);
            this.Controls.Add(this.BtnDisplay);
            this.Controls.Add(this.TxtLanguages);
            this.Controls.Add(this.BtnLoadLanguages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadLanguages;
        private System.Windows.Forms.TextBox TxtLanguages;
        private System.Windows.Forms.Button BtnDisplay;
    }
}

