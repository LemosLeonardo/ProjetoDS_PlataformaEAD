using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using UI_Projeto_DS_EAD;

namespace Projeto_DS_EAD
{
    public partial class Ouvidoria : Form
    {
        Thread ouvidoria;

        public Ouvidoria()
        {
            InitializeComponent();
        }

        private void Ouvidoria_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            ouvidoria = new Thread(voltar);
            ouvidoria.SetApartmentState(ApartmentState.STA);
            ouvidoria.Start();
        }
        private void voltar(object obj)
        {
            Application.Run(new Home());
        }

    }
}
