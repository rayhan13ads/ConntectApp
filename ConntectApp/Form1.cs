using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContectService.bll;
using ContectModel;

namespace ConntectApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contectTableBindingSource.DataSource = services.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddForm ad = new AddForm(null))
            {
                if (ad.ShowDialog() == DialogResult.OK)
                {
                    contectTableBindingSource.DataSource = services.GetAll();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (contectTableBindingSource.DataSource == null)
            {
                return;
            }
            using (AddForm ad = new AddForm(contectTableBindingSource.Current as ContectTable))
            {
                if (ad.ShowDialog() == DialogResult.OK)
                {
                    contectTableBindingSource.DataSource = services.GetAll();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (contectTableBindingSource.DataSource == null)
            {
                return;
            }
            if (MessageBox.Show("Are you sure want to delete the record? ","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                services.Delete(contectTableBindingSource.Current as ContectTable);
                contectTableBindingSource.RemoveCurrent();
            }
        }
    }
}
