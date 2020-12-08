using MySql.Data.MySqlClient;
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
    public partial class auth : Form
    {
        DB db = new DB();
        DataTable authRes = new DataTable();
        public auth()
        {
            InitializeComponent();
        }

        private void BoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxShow.Checked == true)
                Inputpass.UseSystemPasswordChar = false;
            if (BoxShow.Checked == false)
                Inputpass.UseSystemPasswordChar = true;
        }

        private void Buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buttonauth_Click(object sender, EventArgs e)
        {

            int wrong = 0;
            try
            {
                MySqlDataAdapter adapterAdmin = new MySqlDataAdapter();
                MySqlCommand logAdmin = new MySqlCommand("select * from admin where login=@login and password =@password", db.getConnection());
                logAdmin.Parameters.Add("@login", MySqlDbType.String).Value = Inputlogin.Text;
                logAdmin.Parameters.Add("@password", MySqlDbType.String).Value = Inputpass.Text;
                adapterAdmin.SelectCommand = logAdmin;
                adapterAdmin.Fill(authRes);

                if (authRes.Rows.Count >= 1)
                {
                    Form adm = new admin();
                    adm.Show();
                    authRes.Clear();
                } //админ
                else
                {

                }




                MySqlDataAdapter adapterUser = new MySqlDataAdapter();
                MySqlCommand logUser = new MySqlCommand("select * from pacienti where login=@login and password =@password", db.getConnection());
                logUser.Parameters.Add("@login", MySqlDbType.String).Value = Inputlogin.Text;
                logUser.Parameters.Add("@password", MySqlDbType.String).Value = Inputpass.Text;
                adapterUser.SelectCommand = logUser;
                adapterUser.Fill(authRes);

                if (authRes.Rows.Count >= 1)
                {
                    Form usr = new user();
                    usr.Show();
                    authRes.Clear();
                } //юзер
                else
                {

                }





                MySqlDataAdapter adapterBuhg = new MySqlDataAdapter();
                MySqlCommand logBuhg = new MySqlCommand("select * from buhg where login=@login and password =@password", db.getConnection());
                logBuhg.Parameters.Add("@login", MySqlDbType.String).Value = Inputlogin.Text;
                logBuhg.Parameters.Add("@password", MySqlDbType.String).Value = Inputpass.Text;
                adapterBuhg.SelectCommand = logBuhg;
                adapterBuhg.Fill(authRes);

                if (authRes.Rows.Count >= 1)
                {
                    Form bhg = new buh();
                    bhg.Show();
                    authRes.Clear();
                } //бухгалтер
                else { }




                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand logLaboranti = new MySqlCommand("select * from laboranti where login=@login and password =@password", db.getConnection());
                logLaboranti.Parameters.Add("@login", MySqlDbType.String).Value = Inputlogin.Text;
                logLaboranti.Parameters.Add("@password", MySqlDbType.String).Value = Inputpass.Text;
                adapter.SelectCommand = logLaboranti;
                adapter.Fill(authRes);

                if (authRes.Rows.Count >= 1)
                {
                    Form lab = new lab();
                    lab.Show();
                    authRes.Clear();
                } //это лаборант 
                else { }














            }
            catch
            {

            }

        }
    }
}
