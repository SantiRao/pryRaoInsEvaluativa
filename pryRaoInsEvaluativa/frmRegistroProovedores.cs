using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRaoInsEvaluativa
{
    public partial class frmRegistroProovedores : Form
    {
        public frmRegistroProovedores()
        {
            InitializeComponent();
        }

        private void frmRegistroProovedores_Load(object sender, EventArgs e)
        {
            string CadenaConexion = "Listado de aseguradores.csv";

            clsUsuario.CargarCombo(CadenaConexion, 5, cboJuzgado);
            clsUsuario.CargarCombo(CadenaConexion, 6, cboJurisdiccion);
            clsUsuario.CargarCombo(CadenaConexion, 8, cboLiquidador);
        }
    }
}
