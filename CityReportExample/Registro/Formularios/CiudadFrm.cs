using Microsoft.Reporting.WinForms;
using Registro.Estructuras;
using Registro.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro.Formularios
{
    public partial class CiudadFrm : Form
    {

        private List<Ciudad> ciudades;
        private Ciudad ciudadSel = new Ciudad();

        public CiudadFrm()
        {
            InitializeComponent();
            ciudades = new List<Ciudad>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.ID = int.Parse(tbCodigo.Text);
            ciudad.Nombre = tbNombre.Text;
            ciudad.Poblacion = int.Parse(tbPoblacion.Text);

            int index = ciudades.FindIndex(item => item.ID == ciudadSel.ID );

            if (index != -1)
            {
                ciudades[index] = ciudad;
            }
            else
            {
                ciudades.Add(ciudad);
            }
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            //ordenar por nombre
            ciudades.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = ciudades;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat";
                saveFileDialog1.Title = "Guardar archivo";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    CiudadArchivoServicio archivo = new CiudadArchivoServicio();

                    archivo.GuardarArchivo(ciudades, saveFileDialog1.FileName);
                    MessageBox.Show("Se ha guardado el archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                CiudadArchivoServicio archivo = new CiudadArchivoServicio();
                ciudades = archivo.CargarCiudades(ruta);

                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se selecciono ningún archivo.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ciudades.Remove(ciudadSel);
                MessageBox.Show("Ciudad eliminada...", "Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvRegistros.CurrentRow;
            if (currentRow != null)
            {
                ciudadSel.ID = int.Parse(currentRow.Cells[0].Value.ToString());
                ciudadSel.Nombre = currentRow.Cells[1].Value.ToString();
                ciudadSel.Poblacion = int.Parse(currentRow.Cells[2].Value.ToString());

                tbCodigo.Text = ciudadSel.ID.ToString();
                tbNombre.Text = ciudadSel.Nombre;
                tbPoblacion.Text = ciudadSel.Poblacion.ToString();
            }

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource dataSource = new ReportDataSource("DsDatos", ciudades);

            FrmReportes frmReportes = new FrmReportes();
            frmReportes.reportViewer1.LocalReport.DataSources.Clear();
            frmReportes.reportViewer1.LocalReport.DataSources.Add(dataSource);
            //Configurar el archivo de reporte
            frmReportes.reportViewer1.LocalReport.ReportEmbeddedResource = "Registro.Reportes.RptCiudades.rdlc";
            //Refrescar el reporte
            frmReportes.reportViewer1.RefreshReport();

            //Visualizar el formulario
            frmReportes.ShowDialog();

        }

        private void CiudadFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
