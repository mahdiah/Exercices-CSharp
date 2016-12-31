namespace RationnalWUI
{
    partial class FrmRationnal
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
            this.tbNumerateur1 = new System.Windows.Forms.TextBox();
            this.tbDenominateur1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumerateur2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDenominateur2 = new System.Windows.Forms.TextBox();
            this.tbResultatNumerateur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResultatDenominateur = new System.Windows.Forms.TextBox();
            this.rbAddition = new System.Windows.Forms.RadioButton();
            this.rbSoustraction = new System.Windows.Forms.RadioButton();
            this.rbMultiplication = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.btnCalculez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumerateur1
            // 
            this.tbNumerateur1.Location = new System.Drawing.Point(68, 99);
            this.tbNumerateur1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumerateur1.Name = "tbNumerateur1";
            this.tbNumerateur1.Size = new System.Drawing.Size(60, 26);
            this.tbNumerateur1.TabIndex = 0;
            this.tbNumerateur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumerateur1.TextChanged += new System.EventHandler(this.activerBtnCalculez);
            this.tbNumerateur1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tbDenominateur1
            // 
            this.tbDenominateur1.Location = new System.Drawing.Point(68, 165);
            this.tbDenominateur1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDenominateur1.Name = "tbDenominateur1";
            this.tbDenominateur1.Size = new System.Drawing.Size(60, 26);
            this.tbDenominateur1.TabIndex = 1;
            this.tbDenominateur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDenominateur1.TextChanged += new System.EventHandler(this.activerBtnCalculez);
            this.tbDenominateur1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "------------";
            // 
            // tbNumerateur2
            // 
            this.tbNumerateur2.Location = new System.Drawing.Point(228, 97);
            this.tbNumerateur2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumerateur2.Name = "tbNumerateur2";
            this.tbNumerateur2.Size = new System.Drawing.Size(60, 26);
            this.tbNumerateur2.TabIndex = 3;
            this.tbNumerateur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumerateur2.TextChanged += new System.EventHandler(this.activerBtnCalculez);
            this.tbNumerateur2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "------------";
            // 
            // tbDenominateur2
            // 
            this.tbDenominateur2.Location = new System.Drawing.Point(228, 165);
            this.tbDenominateur2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDenominateur2.Name = "tbDenominateur2";
            this.tbDenominateur2.Size = new System.Drawing.Size(60, 26);
            this.tbDenominateur2.TabIndex = 5;
            this.tbDenominateur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDenominateur2.TextChanged += new System.EventHandler(this.activerBtnCalculez);
            this.tbDenominateur2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tbResultatNumerateur
            // 
            this.tbResultatNumerateur.Location = new System.Drawing.Point(147, 274);
            this.tbResultatNumerateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbResultatNumerateur.Name = "tbResultatNumerateur";
            this.tbResultatNumerateur.Size = new System.Drawing.Size(60, 26);
            this.tbResultatNumerateur.TabIndex = 6;
            this.tbResultatNumerateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "------------";
            // 
            // tbResultatDenominateur
            // 
            this.tbResultatDenominateur.Location = new System.Drawing.Point(147, 330);
            this.tbResultatDenominateur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbResultatDenominateur.Name = "tbResultatDenominateur";
            this.tbResultatDenominateur.Size = new System.Drawing.Size(60, 26);
            this.tbResultatDenominateur.TabIndex = 8;
            this.tbResultatDenominateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbAddition
            // 
            this.rbAddition.AutoSize = true;
            this.rbAddition.Location = new System.Drawing.Point(159, 88);
            this.rbAddition.Name = "rbAddition";
            this.rbAddition.Size = new System.Drawing.Size(36, 24);
            this.rbAddition.TabIndex = 9;
            this.rbAddition.TabStop = true;
            this.rbAddition.Text = "+";
            this.rbAddition.UseVisualStyleBackColor = true;
            // 
            // rbSoustraction
            // 
            this.rbSoustraction.AutoSize = true;
            this.rbSoustraction.Location = new System.Drawing.Point(159, 118);
            this.rbSoustraction.Name = "rbSoustraction";
            this.rbSoustraction.Size = new System.Drawing.Size(32, 24);
            this.rbSoustraction.TabIndex = 10;
            this.rbSoustraction.TabStop = true;
            this.rbSoustraction.Text = "-";
            this.rbSoustraction.UseVisualStyleBackColor = true;
            // 
            // rbMultiplication
            // 
            this.rbMultiplication.AutoSize = true;
            this.rbMultiplication.Location = new System.Drawing.Point(161, 148);
            this.rbMultiplication.Name = "rbMultiplication";
            this.rbMultiplication.Size = new System.Drawing.Size(34, 24);
            this.rbMultiplication.TabIndex = 11;
            this.rbMultiplication.TabStop = true;
            this.rbMultiplication.Text = "x";
            this.rbMultiplication.UseVisualStyleBackColor = true;
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(161, 178);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(31, 24);
            this.rbDivision.TabIndex = 12;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "/";
            this.rbDivision.UseVisualStyleBackColor = true;
            // 
            // btnCalculez
            // 
            this.btnCalculez.Location = new System.Drawing.Point(137, 225);
            this.btnCalculez.Name = "btnCalculez";
            this.btnCalculez.Size = new System.Drawing.Size(88, 30);
            this.btnCalculez.TabIndex = 13;
            this.btnCalculez.Text = "Calculez";
            this.btnCalculez.UseVisualStyleBackColor = true;
            this.btnCalculez.Click += new System.EventHandler(this.btnCalculez_Click);
            // 
            // FrmRationnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 402);
            this.Controls.Add(this.btnCalculez);
            this.Controls.Add(this.rbDivision);
            this.Controls.Add(this.rbMultiplication);
            this.Controls.Add(this.rbSoustraction);
            this.Controls.Add(this.rbAddition);
            this.Controls.Add(this.tbResultatDenominateur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResultatNumerateur);
            this.Controls.Add(this.tbDenominateur2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumerateur2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDenominateur1);
            this.Controls.Add(this.tbNumerateur1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRationnal";
            this.Text = "Calcul de Rationnel";
            this.Load += new System.EventHandler(this.FrmRationnal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumerateur1;
        private System.Windows.Forms.TextBox tbDenominateur1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumerateur2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDenominateur2;
        private System.Windows.Forms.TextBox tbResultatNumerateur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResultatDenominateur;
        private System.Windows.Forms.RadioButton rbAddition;
        private System.Windows.Forms.RadioButton rbSoustraction;
        private System.Windows.Forms.RadioButton rbMultiplication;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.Button btnCalculez;
    }
}

