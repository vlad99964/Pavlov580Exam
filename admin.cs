using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void Buttonexit_Click(object sender, EventArgs e)
        {
            Form exit = new auth();
            exit.Show();
            this.Hide();
        }
    }
}
