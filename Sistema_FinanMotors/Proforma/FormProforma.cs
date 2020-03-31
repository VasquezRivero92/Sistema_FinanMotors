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

namespace Sistema_FinanMotors
{
    public partial class FormProforma : Form
    {
        public static Button boton;
        public static bool btn_bool;

        public string tarjeta, placa, id_tarjeta, id_placa;

        private void btn_add_op_Click(object sender, EventArgs e)
        {

        }

        private void cb_modelo_op_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(FormMenuPrincipal.cnn))
            {

                if (cb_modelo_op_1.Text == "CCG125" || cb_modelo_op_1.Text == "GL150")
                {

                    string querycolor = "SELECT * FROM color WHERE id=1 OR id=2";
                    MySqlCommand cmdcolor = new MySqlCommand(querycolor, conn);

                    MySqlDataAdapter da5 = new MySqlDataAdapter(cmdcolor);
                    DataTable dt5 = new DataTable();
                    da5.Fill(dt5);
                    cb_color_op_1.ValueMember = "ID";
                    cb_color_op_1.DisplayMember = "COLOR";
                    cb_color_op_1.DataSource = dt5;
                }
                else
                {

                    string querycolor = "SELECT * FROM color WHERE id>=3";
                    MySqlCommand cmdcolor = new MySqlCommand(querycolor, conn);

                    MySqlDataAdapter da5 = new MySqlDataAdapter(cmdcolor);
                    DataTable dt5 = new DataTable();
                    da5.Fill(dt5);
                    cb_color_op_1.ValueMember = "ID";
                    cb_color_op_1.DisplayMember = "COLOR";
                    cb_color_op_1.DataSource = dt5;
                }
                string queryprecio = "SELECT * FROM modelos WHERE id = " + cb_modelo_op_1.SelectedValue + "";
                MySqlCommand cmprecio = new MySqlCommand(queryprecio, conn);

                MySqlDataAdapter da4 = new MySqlDataAdapter(cmprecio);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);

                lb_p_final.Text = dt4.Rows[0]["PRECIO_VENTA"].ToString();
                datos_temporales.id_modelo_1 = dt4.Rows[0]["ID"].ToString();
                datos_temporales.modelo = dt4.Rows[0]["MODELO"].ToString();


                //string querytipo = "SELECT tipos.nombre_tipo FROM modelos INNER JOIN tipos ON modelos.tipo = tipos.id WHERE modelos.tipo = " + cb_modelo_op.SelectedValue + "";
                //MySqlCommand cmtipo = new MySqlCommand(querytipo, conn);

                //MySqlDataAdapter da6 = new MySqlDataAdapter(cmtipo);
                //DataTable dt6 = new DataTable();
                //da6.Fill(dt6);
                //txt_p_final_op.Text = dt6.Rows[0]["NOMBRE_TIPO"].ToString();

            }
        }

        private void cb_vendedor_op_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos_temporales.id_vendedor = cb_vendedor_op.SelectedValue.ToString();
        }

        private void cb_c_pago_op_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_c_pago_op.Text == "CREDITO")
            {
                txt_cuotas.Visible = true;
                txt_c_inicial.Visible = true;
                inicial.Visible = true;
                cuotas.Visible = true;
                n_cuotas.Visible = true;
                txt_n_cuotas.Visible = true;
                txt_cuotas.Text = "0";
                txt_c_inicial.Text = "0";
                txt_n_cuotas.Text = "0";

            }
            else
            {
                txt_cuotas.Visible = false;
                txt_c_inicial.Visible = false;
                inicial.Visible = false;
                cuotas.Visible = false;
                n_cuotas.Visible = false;
                txt_n_cuotas.Visible = false;
                txt_cuotas.Text = "0";
                txt_c_inicial.Text = "0";
                txt_n_cuotas.Text = "0";
            }
        }

        private void btn_generar_op_Click(object sender, EventArgs e)
        {
            if (btn_add_op.Visible == true || txt_nomb_op.Text == "  " || txt_nomb_op.Text == "")
            {
                MessageBox.Show("Registre o Actualice el usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cb_c_pago_op.Text == "")
            {
                MessageBox.Show("Seleccione condición de pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cb_modelo_op_1.Text == "" || cb_color_op_1.Text == "")
            {
                MessageBox.Show("Seleccione correctamente la moto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                datos_temporales.id_n_proforma = gen.tienda() + "-" + gen.numero();
                using (MySqlConnection conn = new MySqlConnection(FormMenuPrincipal.cnn))
                {

                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro en generar la proforma?", "Proforma", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        conn.Open();
                        cmd.CommandText = "INSERT INTO proformas(TIENDA,TC,N_PROFORMA,CLIENTE,MODELO_MOTO,COLOR,TARJETA,PLACA,VENDEDOR,FECHA,CONDICION_PAGO,INICIAL,P_MENSUAL,N_CUOTAS,COSTO_TOTAL) VALUES(@TIENDA,@TC,@N_PROFORMA,@CLIENTE,@MODELO_MOTO,@COLOR,@TARJETA,@PLACA,@VENDEDOR,@FECHA,@CONDICION_PAGO,@INICIAL,@P_MENSUAL,@N_CUOTAS,@COSTO_TOTAL)";

                        cmd.Parameters.Add("@TC", MySqlDbType.VarChar).Value = TC.TC_V.Remove(TC.TC_V.Length - 1);
                        cmd.Parameters.Add("@TIENDA", MySqlDbType.Int32).Value = Int32.Parse(FormLogin.tienda_);
                        cmd.Parameters.Add("@N_PROFORMA", MySqlDbType.VarChar).Value = datos_temporales.id_n_proforma;
                        cmd.Parameters.Add("@CLIENTE", MySqlDbType.Int32).Value = Int32.Parse(datos_temporales.id_cliente);
                        cmd.Parameters.Add("@MODELO_MOTO", MySqlDbType.Int32).Value = Int32.Parse(datos_temporales.id_modelo_1);
                        if (cb_tarjeta.Checked)
                        {
                            cmd.Parameters.Add("@TARJETA", MySqlDbType.Int32).Value = id_tarjeta;
                        }
                        else
                        {
                            cmd.Parameters.Add("@TARJETA", MySqlDbType.Int32).Value = 0;
                        }
                        if (cb_placa.Checked)
                        {
                            cmd.Parameters.Add("@PLACA", MySqlDbType.Int32).Value = id_placa;
                        }
                        else
                        {
                            cmd.Parameters.Add("@PLACA", MySqlDbType.Int32).Value = 0;
                        }
                        cmd.Parameters.Add("@COLOR", MySqlDbType.Int32).Value = Int32.Parse(datos_temporales.id_color_1);
                        cmd.Parameters.Add("@VENDEDOR", MySqlDbType.Int32).Value = Int32.Parse(datos_temporales.id_vendedor);
                        cmd.Parameters.Add("@FECHA", MySqlDbType.DateTime).Value = dt_fecha_op.Value;
                        cmd.Parameters.Add("@CONDICION_PAGO", MySqlDbType.VarChar).Value = cb_c_pago_op.Text;
                        cmd.Parameters.Add("@INICIAL", MySqlDbType.VarChar).Value = txt_c_inicial.Text;
                        cmd.Parameters.Add("@P_MENSUAL", MySqlDbType.VarChar).Value = txt_cuotas.Text;
                        cmd.Parameters.Add("@N_CUOTAS", MySqlDbType.VarChar).Value = txt_n_cuotas.Text;
                        cmd.Parameters.Add("@COSTO_TOTAL", MySqlDbType.VarChar).Value = lb_p_final.Text;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        DialogResult dialogResult2 = MessageBox.Show("¿Desea generar la orden de pedido interno?", "Orden de Pedido Interno.", MessageBoxButtons.YesNo);
                        if (dialogResult2 == DialogResult.Yes)
                        {
                            reportes_table.proforma_reporte();
                            FormReporteProforma promo = new FormReporteProforma();
                            promo.Text = "Agregar Promocionales";
                            promo.StartPosition = FormStartPosition.CenterScreen;
                            promo.ShowDialog();
                        }
                        else if (dialogResult2 == DialogResult.No)
                        {

                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
            }
        }

        private void txt_ruc_dni_op_TextChanged(object sender, EventArgs e)
        {
            btn_add_op.Visible = false;
        }

        private void txt_nomb_op_TextChanged(object sender, EventArgs e)
        {
            boton = btn_add_op;
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            btn_add_op.Visible = true;
        }

        private void txt_direccion_op_TextChanged(object sender, EventArgs e)
        {
            btn_add_op.Visible = true;
        }

        private void cb_placa_CheckedChanged(object sender, EventArgs e)
        {
            decimal n;
            n = decimal.Parse(placa);
            if (!cb_placa.Checked)
            {
                Console.WriteLine(placa + " " + tarjeta);
                n = decimal.Parse(lb_p_final.Text) - n;
                lb_p_final.Text = n.ToString("N2");
            }
            else
            {
                n = decimal.Parse(lb_p_final.Text) + n;
                lb_p_final.Text = n.ToString("N2");
            }
        }

        private void cb_tarjeta_CheckedChanged(object sender, EventArgs e)
        {
            decimal n;
            n = decimal.Parse(tarjeta);
            if (!cb_tarjeta.Checked)
            {
                n = decimal.Parse(lb_p_final.Text) - n;
                lb_p_final.Text = n.ToString("N2");
            }
            else
            {
                n = decimal.Parse(lb_p_final.Text) + n;
                lb_p_final.Text = n.ToString("N2");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_ruc_dni_op.TextLength == 0)
            {
                MessageBox.Show("Ingresar DNI o RUC", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(FormMenuPrincipal.cnn))
                {
                    string queryreguser = "SELECT * FROM clientes WHERE dni = " + txt_ruc_dni_op.Text + " OR ruc =" + txt_ruc_dni_op.Text + ";";
                    MySqlCommand cmdreguser = new MySqlCommand(queryreguser, conn);

                    MySqlDataAdapter da5 = new MySqlDataAdapter(cmdreguser);
                    DataTable dt5 = new DataTable();
                    da5.Fill(dt5);

                    datos_temporales.id_cliente = dt5.Rows[0]["ID"].ToString();
                    datos_temporales.dni = txt_ruc_dni_op.Text;
                    datos_temporales.ruc = txt_ruc_dni_op.Text;
                    datos_temporales.nombre_razon = txt_nomb_op.Text;
                    datos_temporales.direccion = txt_direccion_op.Text;
                    datos_temporales.telefono = txt_telefono.Text;



                    if (txt_ruc_dni_op.TextLength == 8)
                    {

                        if (dt5.Rows.Count == 0)
                        {
                            ruc_dni.leerdni(txt_ruc_dni_op.Text);
                            txt_nomb_op.Text = ruc_dni.apellidoPaterno_dni + " " + ruc_dni.apellidoMaterno_dni + " " + ruc_dni.nombres_dni;
                            txt_direccion_op.Text = " - - ";
                        }
                        else
                        {
                            txt_nomb_op.Text = dt5.Rows[0]["NOMBRE_RAZON_SOCIAL"].ToString();
                            txt_direccion_op.Text = dt5.Rows[0]["DIRECCION"].ToString();
                            txt_telefono.Text = dt5.Rows[0]["TELEFONO"].ToString();
                            btn_add_op.Visible = false;
                        }
                    }
                    else if (txt_ruc_dni_op.TextLength == 11)
                    {
                        if (dt5.Rows.Count == 0)
                        {
                            ruc_dni.leerruc(txt_ruc_dni_op.Text);
                            txt_nomb_op.Text = ruc_dni.razonSocial_;
                            txt_direccion_op.Text = ruc_dni.direccion_ruc + " " + ruc_dni.distrito_ruc + " - " + ruc_dni.provincia_ruc + " - " + ruc_dni.departamento_ruc;
                        }
                        else
                        {
                            txt_nomb_op.Text = dt5.Rows[0]["NOMBRE_RAZON_SOCIAL"].ToString();
                            txt_direccion_op.Text = dt5.Rows[0]["DIRECCION"].ToString();
                            txt_telefono.Text = dt5.Rows[0]["TELEFONO"].ToString();
                            btn_add_op.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresar 8 DIGITOS SI ES DNI" + "\r\n" + "Ingresar 11 DIGITOS SI ES RUC", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
        }

        public FormProforma()
        {
            InitializeComponent();
        }

        private void FormProforma_Load(object sender, EventArgs e)
        {
            boton = btn_add_op;
            using (MySqlConnection conn = new MySqlConnection(FormMenuPrincipal.cnn))
            {

                string queryvtienda = "SELECT * FROM TIENDA WHERE ID = " + FormLogin.tienda_ + ";";
                MySqlCommand cmdtienda = new MySqlCommand(queryvtienda, conn);

                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdtienda);

                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                txt_proforma.Text = "Proforma " + dt2.Rows[0]["TIENDA"].ToString();


                string querymodelo = "SELECT * FROM modelos";
                MySqlCommand cmdmodelo = new MySqlCommand(querymodelo, conn);

                MySqlDataAdapter da3 = new MySqlDataAdapter(cmdmodelo);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                cb_modelo_op_1.ValueMember = "ID";
                cb_modelo_op_1.DisplayMember = "MODELO";
                cb_modelo_op_1.DataSource = dt3;

                string queryvendedor = "SELECT * FROM vendedor WHERE tienda = " + FormLogin.tienda_ + ";";
                MySqlCommand cmdvendedor = new MySqlCommand(queryvendedor, conn);

                MySqlDataAdapter da4 = new MySqlDataAdapter(cmdvendedor);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                cb_vendedor_op.ValueMember = "ID";
                cb_vendedor_op.DisplayMember = "NOMBRE_VENDEDOR";
                cb_vendedor_op.DataSource = dt4;

                string queryservicios = "SELECT ID,NOMBRE_SERVICIO,COSTO FROM servicios WHERE TIENDA = " + FormLogin.tienda_ + ";";
                MySqlCommand cmdservicios = new MySqlCommand(queryservicios, conn);

                MySqlDataAdapter da12 = new MySqlDataAdapter(cmdservicios);
                DataTable dt12 = new DataTable();
                da12.Fill(dt12);

                placa = dt12.Rows[0]["COSTO"].ToString();
                tarjeta = dt12.Rows[1]["COSTO"].ToString();
                id_placa = dt12.Rows[0]["ID"].ToString();
                id_tarjeta = dt12.Rows[1]["ID"].ToString();

            }

            Console.WriteLine(datos_temporales.id_n_proforma);
            txt_tc.Text = "T.C: " + TC.TC_V.Remove(TC.TC_V.Length - 1);
            datos_temporales.id_modelo_1 = cb_modelo_op_1.SelectedValue.ToString();
            datos_temporales.id_color_1 = cb_color_op_1.SelectedValue.ToString();
            datos_temporales.id_vendedor = cb_vendedor_op.SelectedValue.ToString();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

    }
}
