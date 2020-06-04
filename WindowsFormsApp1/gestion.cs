using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;



namespace WindowsFormsApp1
{


    class gestion

    {
        public OracleConnection cnx= new OracleConnection("data source =(DESCRIPTION =  (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-FNJ6QVC)(PORT = 1521)) (CONNECT_DATA = (service_name= xe)));user id =gestion;password=123456;");


        public void ouvrir()
        {

            if (cnx.State == ConnectionState.Closed) { cnx.Open();
                if (cnx.State == ConnectionState.Open)
                {
                    MessageBox.Show("conection reuussi");
                }
            }
            else
            {
                MessageBox.Show("erreur de execution");
            }

        }
      


    }
}
