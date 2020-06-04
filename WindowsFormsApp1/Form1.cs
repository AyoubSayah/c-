using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
         gestion n = new gestion();
         Boolean authen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Labelbl24_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           label2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ajoutadminpanel.Hide();
            loginpanel.Show();
            n.ouvrir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajoutadminpanel.Hide();
            loginpanel.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ajoutadminpanel.Show();
            loginpanel.Hide();
       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string user = adminid.Text;
            string pass = password.Text;
            string pass2 = password2.Text;
            if (pass == pass2)
            {
                string query = $@"insert into ADMIN values('{user}', '{pass}')";
                OracleCommand cmd = new OracleCommand(query, n.cnx);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("admin Ajouter");
                }
                catch (Exception ea)
                {
                    MessageBox.Show("admin exist");
                    
                }
            }
            else { MessageBox.Show("verfier mdp");
                password.BackColor= Color.Red ;
                password2.BackColor = Color.Red;
            }
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((adminidlogin.Text == "") || (motpasse.Text == "")) {
                MessageBox.Show("veuillez remplir ");
            }
            else
            {
                string query = $@"select * from admin where (ADMINID like '{adminidlogin.Text}' )and(PASSWORD like '{motpasse.Text}')";

                OracleCommand cmd = new OracleCommand(query, n.cnx);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) { authen = true;
                        MessageBox.Show("vous etes authentifié");
                    }
                    else { MessageBox.Show("verifier votre id et mot passe"); }
                }
                catch { MessageBox.Show("err");}

            }
        }
    }
        }

