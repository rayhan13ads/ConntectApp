using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContectModel;
using ContectService.bll;
namespace ConntectApp
{
    public partial class AddForm : Form
    {
        bool IsNew;
        public AddForm(ContectTable obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                contectTableBindingSource.DataSource = new ContectTable();
                IsNew = true;
            }
            else
            {
                contectTableBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show("Please Fill Up Name ...", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBoxName.Focus();
                    e.Cancel = true;
                    return;
                }
                if (IsNew)
                {
                    services.Insert(contectTableBindingSource.Current as ContectTable);
                }
                else
                {
                    services.Update(contectTableBindingSource.Current as ContectTable);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxAddress.Clear();
        }
    }
}
