namespace Panel_Form
{
    partial class FormContainer
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
            this.btnShowForm = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStyleForm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnShowForm
            // 
            this.btnShowForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowForm.Location = new System.Drawing.Point(24, 12);
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.Size = new System.Drawing.Size(99, 39);
            this.btnShowForm.TabIndex = 0;
            this.btnShowForm.Text = "Show Form";
            this.btnShowForm.UseVisualStyleBackColor = true;
            this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pContainer.Location = new System.Drawing.Point(24, 57);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(764, 361);
            this.pContainer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(159, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Form Style";
            // 
            // cboStyleForm
            // 
            this.cboStyleForm.FormattingEnabled = true;
            this.cboStyleForm.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D",
            "FixedDialog",
            "Sizable",
            "FixedToolWindow",
            "SizableToolWindow"});
            this.cboStyleForm.Location = new System.Drawing.Point(258, 23);
            this.cboStyleForm.Name = "cboStyleForm";
            this.cboStyleForm.Size = new System.Drawing.Size(154, 21);
            this.cboStyleForm.TabIndex = 3;
            // 
            // FormContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboStyleForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.btnShowForm);
            this.Name = "FormContainer";
            this.Text = "Container";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStyleForm;
    }
}

