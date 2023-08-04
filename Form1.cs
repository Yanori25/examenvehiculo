using ExamenVehiculo.CapaController;
using ExamenVehiculo.CapaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenVehiculo
{
    public partial class Form1 : Form
    {


        VehiculoController opercontrol = new VehiculoController();
        VehiculoModel vehmodel = new VehiculoModel();
        ExportarExcel Excel = new ExportarExcel();
        Exportpdf expopdf = new Exportpdf();


        string id = "0";
        int editando = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void refrescar()
        {
            dgvroles.DataSource = opercontrol.ListarVehiculos();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            vehmodel.IdVehiculo = 0;
            vehmodel.DescripcionVehiculo = txtdescripcion.Text;
            vehmodel.MarcaVehiculo = txtmarca.Text;
            vehmodel.ModeloVehiculo = txtmodelo.Text;
            vehmodel.AniooVehiculo = Convert.ToInt32( txtanio.Text) ;
            vehmodel.FechaApertura = Convert.ToDateTime( "2023-08-03");
            vehmodel.Activo = true ;


            opercontrol.Crear(vehmodel);
            this.refrescar();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
          

            if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(Convert.ToInt32(this.id) != 0)
                {
                    vehmodel.IdVehiculo = Convert.ToInt32(this.id);
                    opercontrol.eliminar(vehmodel);

                    this.refrescar();
                }
                else
                {
                    MessageBox.Show("Se debe seleccionar el vehiculo a eliminar");
                }
                  

            }

        }

        private void dgvroles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dgvroles.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtid.Text = this.id;
            txtdescripcion.Text = dgvroles.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmarca.Text = dgvroles.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmodelo.Text = dgvroles.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtanio.Text = dgvroles.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtactivo.Text = dgvroles.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void txtfillmarca_TextChanged(object sender, EventArgs e)
        {
            string filtername = "MarcaVehiculo";
            ((DataTable)dgvroles.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfillmarca.Text);
        }

        private void txtfilmodelo_TextChanged(object sender, EventArgs e)
        {
            string filtername = "ModeloVehiculo";
            ((DataTable)dgvroles.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfilmodelo.Text);

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro de modificar este registro ?", "modificar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vehmodel.IdVehiculo = Convert.ToInt32( txtid.Text);
            vehmodel.DescripcionVehiculo = txtdescripcion.Text;
            vehmodel.MarcaVehiculo = txtmarca.Text;
            vehmodel.ModeloVehiculo = txtmodelo.Text;
            vehmodel.AniooVehiculo = Convert.ToInt32(txtanio.Text);
            vehmodel.FechaApertura = Convert.ToDateTime("2023-08-03");
            vehmodel.Activo = true;


            opercontrol.Modificar(vehmodel);
            this.refrescar();
            }

        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDataGridViewExcel(dgvroles);
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            expopdf.expopdf(dgvroles, 0, 5);
        }
    }
}
