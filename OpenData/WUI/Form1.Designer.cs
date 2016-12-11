namespace WUI
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // BtnLoadLanguages
            // 
            this.BtnLoadLanguages.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadLanguages.Location = new System.Drawing.Point(305, 24);
            this.BtnLoadLanguages.Name = "BtnLoadLanguages";
            this.BtnLoadLanguages.Size = new System.Drawing.Size(323, 33);
            this.BtnLoadLanguages.TabIndex = 0;
            this.BtnLoadLanguages.Text = "Charger Les Langues";
            this.BtnLoadLanguages.UseVisualStyleBackColor = true;
            this.BtnLoadLanguages.Click += new System.EventHandler(this.BtnLoadLanguages_Click);
            // 
            // TxtLanguages
            // 
            this.TxtLanguages.Location = new System.Drawing.Point(32, 79);
            this.TxtLanguages.Multiline = true;
            this.TxtLanguages.Name = "TxtLanguages";
            this.TxtLanguages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLanguages.Size = new System.Drawing.Size(849, 519);
            this.TxtLanguages.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 610);
            this.Controls.Add(this.TxtLanguages);
            this.Controls.Add(this.BtnLoadLanguages);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Languages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadLanguages;
        private System.Windows.Forms.TextBox TxtLanguages;
    }
}

