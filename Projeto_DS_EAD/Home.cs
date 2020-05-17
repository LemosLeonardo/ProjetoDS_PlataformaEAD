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

namespace UI_Projeto_DS_EAD
{
    public partial class Home : Form
    {
        Thread home; 
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIrEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            home = new Thread(entrar);
            home.SetApartmentState(ApartmentState.STA);
            home.Start();
        }
        //MÉTODO IR PARA O FORMS ENTRAR
        private void entrar(object obj)
        {
            Application.Run(new Projeto_DS_EAD.Entrar());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            home = new Thread(cadastrar);
            home.SetApartmentState(ApartmentState.STA);
            home.Start();
        }
        //MÉTODO IR PARA O FORMS CADASTRO
        private void cadastrar(object obj)
        {
            Application.Run(new Projeto_DS_EAD.Cadastro());
        }

        private void btnOuvidoria_Click(object sender, EventArgs e)
        {
            this.Close();
            home = new Thread(ouvidoria);
            home.SetApartmentState(ApartmentState.STA);
            home.Start();

        }
        //MÉTODO IR PARA O FORMS OUVIDORIA
        private void ouvidoria(object obj)
        {
            Application.Run(new Projeto_DS_EAD.Ouvidoria());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
