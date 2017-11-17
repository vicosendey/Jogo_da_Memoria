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

namespace Jogo_Memoria
{
    public partial class Frm_Fases : Form
    {

        #region Construtor
        public Frm_Fases(int recebeStatus)
        {
            switch(recebeStatus)
            {
                case 1:
                    {
                      for (int i = 0; i < 1; i++)
                      {
                         statusFases[i] = true;
                      }
                      break;
                    }
                case 2:
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            statusFases[i] = true;
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            statusFases[i] = true;
                        }
                        break;
                    }
            }
            
            InitializeComponent();
        }
        #endregion
        #region Variaveis Globais
        Boolean[] statusFases = new Boolean[3] { false, false, false };
        #endregion
        #region Botão Sair
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Botão Voltar
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Frm_Menu novaJanela = new Frm_Menu();
            novaJanela.Show();
            this.Hide();
        }
        #endregion
        #region Form Load
        private void Frm_Fases_Load(object sender, EventArgs e)
        {
            if(statusFases[0] == true && statusFases[1] == false && statusFases[2] == false)
            {
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/fase1c.png");
            }
            else if(statusFases[0] == true && statusFases[1] == true && statusFases[2] == false)
            {
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/fase1c.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/fase2c.png");
            }
            else if (statusFases[0] == true && statusFases[1] == true && statusFases[2] == true)
            {
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/fase1c.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/fase2c.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/fase3c.png");
            }
        }
        #endregion
        #region Primeira Fase
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Fase_01 novaJanela = new Frm_Fase_01();
            novaJanela.Show();
            this.Hide();
        }
        #endregion
        #region Segunda Fase
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Fase_02 novaJanela = new Frm_Fase_02();
            novaJanela.Show();
            this.Hide();
        }
        #endregion
        #region Terceira Fase
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_Fase_03 novaJanela = new Frm_Fase_03();
            novaJanela.Show();
            this.Hide();
        }
        #endregion
    }
}
