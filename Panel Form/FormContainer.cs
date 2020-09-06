using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_Form
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        private void btnShowForm_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2()
            {
                Dock = DockStyle.Fill,
                //TopLevel window is a window that ha no parent form, or whose parent form is dekstop window
                TopLevel = false,
                //TopMost is a form that overlaps all the other form even if it is not the active or foreground form
                TopMost = true
            };
            form2.FormBorderStyle = (FormBorderStyle)cboStyleForm.SelectedIndex;
            this.pContainer.Controls.Add(form2);
            form2.Show();
        }
    }
}
