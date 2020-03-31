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
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }
        

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            if (dtg_clientes.SelectedRows.Count > 0)
            {               
                frm.txtid.Text= dtg_clientes.CurrentRow.Cells[0].Value.ToString();
                frm.txtnombre.Text = dtg_clientes.CurrentRow.Cells[1].Value.ToString();
                frm.txtapellido.Text = dtg_clientes.CurrentRow.Cells[2].Value.ToString();
                frm.txtdireccion.Text = dtg_clientes.CurrentRow.Cells[3].Value.ToString();
                frm.txttelefono.Text = dtg_clientes.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();
             
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.ShowDialog();
        }

        private void InsertarFilas()
        {
            using (MySqlConnection conn = new MySqlConnection(FormMenuPrincipal.cnn))
            {
                string queryuser = "SELECT * FROM clientes";
                MySqlCommand cmduser = new MySqlCommand(queryuser, conn);

                MySqlDataAdapter da5 = new MySqlDataAdapter(cmduser);
                DataTable dt5 = new DataTable();
                DataSet ds = new DataSet();
                da5.Fill(ds, "tabla");
                dtg_clientes.DataSource = ds;
                dtg_clientes.DataMember = "tabla";
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormMembresia frm = Owner as FormMembresia;
            //FormMembresia frm = new FormMembresia();

            frm.txtid.Text = dtg_clientes.CurrentRow.Cells[0].Value.ToString();
            frm.txtnombre.Text = dtg_clientes.CurrentRow.Cells[1].Value.ToString();
            frm.txtapellido.Text = dtg_clientes.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
