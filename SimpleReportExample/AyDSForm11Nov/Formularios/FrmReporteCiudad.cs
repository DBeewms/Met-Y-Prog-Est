using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyDSForm11Nov.Formularios
{
    public partial class FrmReporteCiudad : Form
    {
        // Instancia estática de FrmReportes
        private static FrmReporteCiudad instance;

        // Propiedad estática para acceder a la instancia única
        public static FrmReporteCiudad Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmReporteCiudad();
                }
                return instance;
            }
        }

        public FrmReporteCiudad()
        {
            InitializeComponent();
        }

        private void FrmReporteCiudad_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
