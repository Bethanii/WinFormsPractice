using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCode;
namespace DemoForm
{
    public partial class frmDemoForm : Form
    {
        public frmDemoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Animal per = new Animal();

        private void WriteToFile_Click(object sender, EventArgs e)
        {
            per.Type = txtType.Text;
            per.Name = txtName.Text;

            MessageBox.Show(per.GetTypeName(per.Type, per.Name).ToString());
        }
    }
}
