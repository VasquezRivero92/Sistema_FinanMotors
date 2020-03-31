using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_FinanMotors
{
    class gen
    {
        public static string tienda()
        {
            using (MySqlConnection conn = new MySqlConnection(FormMenuPrincipal.cnn))
            {

                string queryvtienda = "SELECT * FROM TIENDA WHERE ID = " + FormLogin.tienda_ + ";";
                MySqlCommand cmdtienda = new MySqlCommand(queryvtienda, conn);

                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdtienda);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                return dt2.Rows[0]["SERIE"].ToString();
                //txt_proforma.Text = "Proforma " + dt2.Rows[0]["TIENDA"].ToString();
            }
        }

        public static string numero()
        {
            using (MySqlConnection conn = new MySqlConnection(FormMenuPrincipal.cnn))
            {

                string queryvtienda = "SELECT * FROM proformas WHERE tienda = " + FormLogin.tienda_ + ";";
                MySqlCommand cmdtienda = new MySqlCommand(queryvtienda, conn);

                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdtienda);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                return dt2.Rows.Count.ToString();
            }
        }

        public static void proforma()
        {

        }
    }
}
