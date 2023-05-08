namespace AgeWizard
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BornInTextBox = new System.Windows.Forms.TextBox();
            this.YearsOldTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Year_Born_Lab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Years_Old = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BornIn = new System.Windows.Forms.Button();
            this.YearsOld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BornInTextBox
            // 
            this.BornInTextBox.Location = new System.Drawing.Point(19, 49);
            this.BornInTextBox.Name = "BornInTextBox";
            this.BornInTextBox.Size = new System.Drawing.Size(125, 22);
            this.BornInTextBox.TabIndex = 0;
            this.BornInTextBox.TextChanged += new System.EventHandler(this.BornInTextBox_TextChanged);
            // 
            // YearsOldTextBox
            // 
            this.YearsOldTextBox.Location = new System.Drawing.Point(178, 49);
            this.YearsOldTextBox.Name = "YearsOldTextBox";
            this.YearsOldTextBox.Size = new System.Drawing.Size(136, 22);
            this.YearsOldTextBox.TabIndex = 1;
            this.YearsOldTextBox.TextChanged += new System.EventHandler(this.YearsOldTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "You Born In:";
            // 
            // Year_Born_Lab
            // 
            this.Year_Born_Lab.AutoSize = true;
            this.Year_Born_Lab.Location = new System.Drawing.Point(100, 128);
            this.Year_Born_Lab.Name = "Year_Born_Lab";
            this.Year_Born_Lab.Size = new System.Drawing.Size(0, 16);
            this.Year_Born_Lab.TabIndex = 3;
            this.Year_Born_Lab.Click += new System.EventHandler(this.Year_Born_Lab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "You are: ";
            // 
            // Years_Old
            // 
            this.Years_Old.AutoSize = true;
            this.Years_Old.Location = new System.Drawing.Point(258, 128);
            this.Years_Old.Name = "Years_Old";
            this.Years_Old.Size = new System.Drawing.Size(0, 16);
            this.Years_Old.TabIndex = 5;
            this.Years_Old.Click += new System.EventHandler(this.Years_Old_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "How old are you?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Enter your year of birth";
            // 
            // BornIn
            // 
            this.BornIn.Location = new System.Drawing.Point(19, 83);
            this.BornIn.Name = "BornIn";
            this.BornIn.Size = new System.Drawing.Size(125, 23);
            this.BornIn.TabIndex = 8;
            this.BornIn.Text = "START";
            this.BornIn.UseVisualStyleBackColor = true;
            this.BornIn.Click += new System.EventHandler(this.BornIn_Click);
            // 
            // YearsOld
            // 
            this.YearsOld.Location = new System.Drawing.Point(178, 82);
            this.YearsOld.Name = "YearsOld";
            this.YearsOld.Size = new System.Drawing.Size(136, 23);
            this.YearsOld.TabIndex = 9;
            this.YearsOld.Text = "START";
            this.YearsOld.UseVisualStyleBackColor = true;
            this.YearsOld.Click += new System.EventHandler(this.YearsOld_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 171);
            this.Controls.Add(this.YearsOld);
            this.Controls.Add(this.BornIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Years_Old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Year_Born_Lab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearsOldTextBox);
            this.Controls.Add(this.BornInTextBox);
            this.Name = "Form1";
            this.Text = "AgeWizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BornInTextBox;
        private System.Windows.Forms.TextBox YearsOldTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Year_Born_Lab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Years_Old;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BornIn;
        private System.Windows.Forms.Button YearsOld;
    }
}

