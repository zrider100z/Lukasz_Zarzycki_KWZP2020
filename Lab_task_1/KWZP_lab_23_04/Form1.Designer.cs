namespace KWZP_lab_23_04
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
            this.btnClose = new System.Windows.Forms.Button();
            this.chkButtonEnabled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtButtonLabel = new System.Windows.Forms.TextBox();
            this.rbtRadio1 = new System.Windows.Forms.RadioButton();
            this.rbtRadio2 = new System.Windows.Forms.RadioButton();
            this.rbtRadio3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(243, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Charge Me <sad beep>";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkButtonEnabled
            // 
            this.chkButtonEnabled.AutoSize = true;
            this.chkButtonEnabled.Location = new System.Drawing.Point(74, 94);
            this.chkButtonEnabled.Name = "chkButtonEnabled";
            this.chkButtonEnabled.Size = new System.Drawing.Size(141, 17);
            this.chkButtonEnabled.TabIndex = 1;
            this.chkButtonEnabled.Text = "Włącz/Wyłącz przycisk";
            this.chkButtonEnabled.UseVisualStyleBackColor = true;
            this.chkButtonEnabled.CheckedChanged += new System.EventHandler(this.chkButtonEnabled_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "KWZP Labki 23.04.2020";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // txtButtonLabel
            // 
            this.txtButtonLabel.Location = new System.Drawing.Point(17, 52);
            this.txtButtonLabel.Name = "txtButtonLabel";
            this.txtButtonLabel.Size = new System.Drawing.Size(243, 20);
            this.txtButtonLabel.TabIndex = 3;
            this.txtButtonLabel.TextChanged += new System.EventHandler(this.txtButtonLabel_TextChanged);
            // 
            // rbtRadio1
            // 
            this.rbtRadio1.AutoSize = true;
            this.rbtRadio1.Location = new System.Drawing.Point(98, 114);
            this.rbtRadio1.Name = "rbtRadio1";
            this.rbtRadio1.Size = new System.Drawing.Size(85, 17);
            this.rbtRadio1.TabIndex = 4;
            this.rbtRadio1.TabStop = true;
            this.rbtRadio1.Text = "radioButton1";
            this.rbtRadio1.UseVisualStyleBackColor = true;
            this.rbtRadio1.CheckedChanged += new System.EventHandler(this.rbtRadio1_CheckedChanged);
            // 
            // rbtRadio2
            // 
            this.rbtRadio2.AutoSize = true;
            this.rbtRadio2.Location = new System.Drawing.Point(98, 137);
            this.rbtRadio2.Name = "rbtRadio2";
            this.rbtRadio2.Size = new System.Drawing.Size(85, 17);
            this.rbtRadio2.TabIndex = 4;
            this.rbtRadio2.TabStop = true;
            this.rbtRadio2.Text = "radioButton1";
            this.rbtRadio2.UseVisualStyleBackColor = true;
            this.rbtRadio2.CheckedChanged += new System.EventHandler(this.rbtRadio2_CheckedChanged);
            // 
            // rbtRadio3
            // 
            this.rbtRadio3.AutoSize = true;
            this.rbtRadio3.Location = new System.Drawing.Point(98, 160);
            this.rbtRadio3.Name = "rbtRadio3";
            this.rbtRadio3.Size = new System.Drawing.Size(85, 17);
            this.rbtRadio3.TabIndex = 4;
            this.rbtRadio3.TabStop = true;
            this.rbtRadio3.Text = "radioButton1";
            this.rbtRadio3.UseVisualStyleBackColor = true;
            this.rbtRadio3.CheckedChanged += new System.EventHandler(this.rbtRadio3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(315, 241);
            this.Controls.Add(this.rbtRadio3);
            this.Controls.Add(this.rbtRadio2);
            this.Controls.Add(this.rbtRadio1);
            this.Controls.Add(this.txtButtonLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkButtonEnabled);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkButtonEnabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtButtonLabel;
        private System.Windows.Forms.RadioButton rbtRadio1;
        private System.Windows.Forms.RadioButton rbtRadio2;
        private System.Windows.Forms.RadioButton rbtRadio3;
    }
}

