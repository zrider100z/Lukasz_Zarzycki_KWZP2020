namespace KWZP_lab_23_04
{
    partial class DetailsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPesel = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.dgvEmployment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SieZmieni";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(79, 69);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(297, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(79, 95);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(297, 20);
            this.txtPesel.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(79, 121);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(297, 20);
            this.txtAdres.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Imie";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(21, 72);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(53, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Nazwisko";
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Location = new System.Drawing.Point(21, 98);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(33, 13);
            this.lblPesel.TabIndex = 3;
            this.lblPesel.Text = "Pesel";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(21, 128);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres";
            // 
            // dgvEmployment
            // 
            this.dgvEmployment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployment.Location = new System.Drawing.Point(18, 156);
            this.dgvEmployment.Name = "dgvEmployment";
            this.dgvEmployment.Size = new System.Drawing.Size(753, 362);
            this.dgvEmployment.TabIndex = 4;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 530);
            this.Controls.Add(this.dgvEmployment);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitle);
            this.Name = "DetailsForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.DataGridView dgvEmployment;
    }
}