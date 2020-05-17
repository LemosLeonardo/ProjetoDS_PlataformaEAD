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
    public partial class Entrar : Form
    {
        Thread entrar;

        public Entrar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            entrar = new Thread(voltar);
            entrar.SetApartmentState(ApartmentState.STA);
            entrar.Start();
        }
        //MÉTODO voltar
        private void voltar(object obj)
        {
            Application.Run(new Home());
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }
    }
}
