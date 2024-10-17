using AyDSForm11Nov.Formularios;
using AyDSForm11Nov.PruebaDBDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyDSForm11Nov.Models;

namespace AyDSForm11Nov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Persona> lista = new List<Persona>();
            Persona persona = new Persona();
            persona.Codigo = 1;
            persona.Nombre = "Juan";
            persona.Apellido = "Perez";
            persona.Direccion = "Calle 123";
            persona.Telefono = "123456";
            lista.Add(persona);

            ReportDataSource dataSource = new ReportDataSource("DsReportes", lista);

            FrmReporteCiudad frm = new FrmReporteCiudad();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(dataSource);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "AyDSForm11Nov.Reportes2.RptPersona.rdlc";
            frm.reportViewer1.Refresh();
            frm.Show();



            //PruebaDBDataSet dataSet = new PruebaDBDataSet();
            //carrerasTableAdapter adapter = new carrerasTableAdapter();
            //adapter.Fill(dataSet.carreras);

            //ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet.Tables["carreras"]);

            //FrmReporteCiudad frm = new FrmReporteCiudad();
            //frm.reportViewer1.LocalReport.DataSources.Clear();
            //frm.reportViewer1.LocalReport.DataSources.Add(dataSource);
            //frm.reportViewer1.Refresh();
            //frm.Show();
        }
    }
}
