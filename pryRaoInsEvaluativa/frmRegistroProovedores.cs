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

           clsUsuario ObjP = new clsUsuario();

        public void frmRegistroProovedores_Load(object sender, EventArgs e)
        {

            ObjP.CargarInfo(dgvProovedores,cboJuzgado, cboJurisdiccion, cboLiquidador);

        }
        
    }
}
