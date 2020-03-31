using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FinanMotors
{
    class reportes_table
    {

        public static void proforma_reporte()
        {
            proforma_crp objRpt;
            objRpt = new proforma_crp();

            // LA DE ARRIBA ES NUESTRA CADENA DE CONEXION DEL SERVIDOR
            
            MySqlConnection myConnection = new MySqlConnection(FormMenuPrincipal.cnn); // TIENEN QUE UTILIZAR EN EL USING LA CLASE DE System.Data.SqlClient
            myConnection.Open();
            String Query = "SELECT p.id,p.N_proforma,c.DNI,c.direccion,c.nombre_razon_social,c.telefono,t.tienda,m.modelo,co.color,v.nombre_vendedor,fecha,condicion_pago,tc,inicial,p_mensual,n_cuotas,costo_total FROM proformas p INNER JOIN clientes c ON p.cliente = c.id INNER JOIN tienda t ON p.tienda = t.id INNER JOIN modelos m ON p.modelo_moto = m.id INNER JOIN color co ON p.color = co.id INNER JOIN vendedor v ON p.vendedor = v.id WHERE p.n_proforma = '"+ datos_temporales.id_n_proforma + "';"; // ESTE ES NUESTRO QUERY
            MySqlCommand cmdreporte = new MySqlCommand(Query, myConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdreporte);
            String Query2 = "SELECT p.id,p.N_proforma,c.DNI,c.direccion,c.nombre_razon_social,c.telefono,t.tienda,m.modelo,co.color,v.nombre_vendedor,fecha,condicion_pago,tc,inicial,p_mensual,n_cuotas,costo_total FROM proformas p INNER JOIN clientes c ON p.cliente = c.id INNER JOIN tienda t ON p.tienda = t.id INNER JOIN modelos m ON p.modelo_moto = m.id INNER JOIN color co ON p.color = co.id INNER JOIN vendedor v ON p.vendedor = v.id WHERE p.n_proforma = '" + datos_temporales.id_n_proforma + "';"; // ESTE ES NUESTRO QUERY
            MySqlCommand cmdreporte2 = new MySqlCommand(Query2, myConnection);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmdreporte2);

            dt_proforma Ds = new dt_proforma(); // ESTE ES EL NOMBRE DE NUESTRO DATASET
            adapter.Fill(Ds, "proforma"); // ESTE Reportes ES EL NOMBRE DE NUESTRA TABLA DE DATOS QUE ESTA DENTRO DE NUESTRO DATASET
            adapter2.Fill(Ds, "proforma");

            objRpt.SetDataSource(Ds); 
            FormReporteProforma rpt = new FormReporteProforma(); // ES EL FORM DONDE ESTA NUESTRO CRYSTAL REPORT VIEWER
            rpt.crv_proforma.ReportSource = objRpt; // ESTE ES NUESTRO REPORT VIEWER
            rpt.ShowDialog(); // AQUI LO MUESTRA}
            myConnection.Close();
        }
    }
}
