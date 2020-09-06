namespace Panel_Form
{
    partial class Form2
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
            this.labelForm2 = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForm2
            // 
            this.labelForm2.AutoSize = true;
            this.labelForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelForm2.Location = new System.Drawing.Point(28, 31);
            this.labelForm2.Name = "labelForm2";
            this.labelForm2.Size = new System.Drawing.Size(558, 20);
            this.labelForm2.TabIndex = 0;
            this.labelForm2.Text = "Hallo, welcome in Form 2. Please click this button to continue. Happy Codding!";
            // 
            // btnClickMe
            // 
            this.btnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClickMe.Location = new System.Drawing.Point(223, 77);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(94, 35);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 136);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.labelForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForm2;
        private System.Windows.Forms.Button btnClickMe;
    }
}