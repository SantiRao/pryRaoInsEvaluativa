using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRaoInsEvaluativa
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void frmLogo_Load(object sender, EventArgs e)
        {

        }

        int Tempo = 0;

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Tempo += 1000;

            if (Tempo > 3000)
            {
                this.Hide();
                frmInicioSesion frmInicioSes = new frmInicioSesion();
                frmInicioSes.Show();
                Tempo = 0;
                Temporizador.Enabled = false;
            }
        }
    }
}
