using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Memoria
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        #region Variáveis Globais
        Boolean colorChange = true;
        #endregion
        #region Timer
        private void timer_1_Tick(object sender, EventArgs e)
        {
            if(colorChange == true)
            {
                btn_comecar.BackColor = Color.Red;
                colorChange = false;
            }
            else
            {
                btn_comecar.BackColor = Color.Ivory;
                colorChange = true;
            }
        }
        #endregion
        #region Botão Sair
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Botão Começar
        private void btn_comecar_Click(object sender, EventArgs e)
        {
            Frm_Fases novaJanela = new Frm_Fases(0);
            novaJanela.Show();
            this.Hide();
        }
        #endregion

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jogo produzido por:\n\nGabriel RA: 138743\nJoão RA:138608\nGuilherme RA:138376\nVinicius RA:139451", "Sobre");
        }
    }
}
