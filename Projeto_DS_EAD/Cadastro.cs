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
    public partial class Cadastro : Form
    {
        Thread cadastro;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            cadastro = new Thread(voltar);
            cadastro.SetApartmentState(ApartmentState.STA);
            cadastro.Start();
        }
        //MÉTODO voltar
        private void voltar(object obj)
        {
            Application.Run(new Home());
        }

    }
}
