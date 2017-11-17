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
    public partial class Frm_Fase_02 : Form
    {
        public Frm_Fase_02()
        {
            InitializeComponent();
        }


        #region Variáveis Globais
        Boolean clicked = false;
        int cont = 0, faseCompleta = 0;
        int[] numero = new int[2];
        PictureBox[] picture = new PictureBox[2];
        String[] arquivos = { "/bola3.png", "/bola.png", "/bola4.png", "/bola3.png", "/bola2.png", "/bola.png", "/bola4.png", "/bola2.png" };
        #endregion

        #region Botao Sair
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Botão Voltar
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Frm_Fases novaJanela = new Frm_Fases(faseCompleta);
            novaJanela.Show();
            this.Hide();
        }
        #endregion

        #region Picture1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[0]);
                numero[0] = 0;
                picture[0] = pictureBox1;
            }
            else
            {
                clicked = false;
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[0]);
                numero[1] = 0;
                picture[1] = pictureBox1;
                if (picture[0] == picture[1])
                {
                    pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    picture[0] = null;
                    picture[1] = null;
                    numero[0] = 0;
                    numero[1] = 0;
                }
                else
                {
                    if (arquivos[numero[0]].Equals(arquivos[numero[1]]))
                    {
                        pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[0]);
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Enabled = false;
                        picture2.Enabled = false;
                        cont++;
                        lbl_corretas.Text = cont.ToString();
                        if (cont == 4)
                        {
                            lbl_sucesso.Visible = true;
                            faseCompleta = 2;
                        }
                    }
                    else
                    {
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                        picture2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    }
                }
            }
        }
        #endregion
        #region Picture2
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[1]);
                numero[0] = 1;
                picture[0] = pictureBox2;
            }
            else
            {
                clicked = false;
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[1]);
                numero[1] = 1;
                picture[1] = pictureBox2;
                if (picture[0] == picture[1])
                {
                    pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    picture[0] = null;
                    picture[1] = null;
                    numero[0] = 0;
                    numero[1] = 0;
                }
                else
                {
                    if (arquivos[numero[0]].Equals(arquivos[numero[1]]))
                    {
                        pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[1]);
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Enabled = false;
                        picture2.Enabled = false;
                        cont++;
                        lbl_corretas.Text = cont.ToString();
                        if (cont == 4)
                        {
                            lbl_sucesso.Visible = true;
                            faseCompleta = 2;
                        }
                    }
                    else
                    {
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                        picture2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    }
                }
            }
        }
        #endregion
        #region Picture3
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[2]);
                numero[0] = 2;
                picture[0] = pictureBox3;
            }
            else
            {
                clicked = false;
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[2]);
                numero[1] = 2;
                picture[1] = pictureBox3;
                if (picture[0] == picture[1])
                {
                    pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    picture[0] = null;
                    picture[1] = null;
                    numero[0] = 0;
                    numero[1] = 0;
                }
                else
                {
                    if (arquivos[numero[0]].Equals(arquivos[numero[1]]))
                    {
                        pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[2]);
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Enabled = false;
                        picture2.Enabled = false;
                        cont++;
                        lbl_corretas.Text = cont.ToString();
                        if (cont == 4)
                        {
                            lbl_sucesso.Visible = true;
                            faseCompleta = 2;
                        }
                    }
                    else
                    {
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                        picture2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    }
                }
            }
        }
        #endregion
        #region Picture4
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[3]);
                numero[0] = 3;
                picture[0] = pictureBox4;
            }
            else
            {
                clicked = false;
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[3]);
                numero[1] = 3;
                picture[1] = pictureBox4;
                if (picture[0] == picture[1])
                {
                    pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    picture[0] = null;
                    picture[1] = null;
                    numero[0] = 0;
                    numero[1] = 0;
                }
                else
                {
                    if (arquivos[numero[0]].Equals(arquivos[numero[1]]))
                    {
                        pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[3]);
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Enabled = false;
                        picture2.Enabled = false;
                        cont++;
                        lbl_corretas.Text = cont.ToString();
                        if (cont == 4)
                        {
                            lbl_sucesso.Visible = true;
                            faseCompleta = 2;
                        }
                    }
                    else
                    {
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                        picture2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    }
                }
            }
        }
        #endregion
        #region Picture5
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[4]);
                numero[0] = 4;
                picture[0] = pictureBox8;
            }
            else
            {
                clicked = false;
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[4]);
                numero[1] = 4;
                picture[1] = pictureBox8;
                if (picture[0] == picture[1])
                {
                    pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    picture[0] = null;
                    picture[1] = null;
                    numero[0] = 0;
                    numero[1] = 0;
                }
                else
                {
                    if (arquivos[numero[0]].Equals(arquivos[numero[1]]))
                    {
                        pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[4]);
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Enabled = false;
                        picture2.Enabled = false;
                        cont++;
                        lbl_corretas.Text = cont.ToString();
                        if (cont == 4)
                        {
                            lbl_sucesso.Visible = true;
                            faseCompleta = 2;
                        }
                    }
                    else
                    {
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                        picture2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    }
                }
            }
        }
        #endregion
        #region Picture6
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[5]);
                numero[0] = 5;
                picture[0] = pictureBox7;
            }
            else
            {
                clicked = false;
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[5]);
                numero[1] = 5;
                picture[1] = pictureBox7;
                if (picture[0] == picture[1])
                {
                    pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    picture[0] = null;
                    picture[1] = null;
                    numero[0] = 0;
                    numero[1] = 0;
                }
                else
                {
                    if (arquivos[numero[0]].Equals(arquivos[numero[1]]))
                    {
                        pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[5]);
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Enabled = false;
                        picture2.Enabled = false;
                        cont++;
                        lbl_corretas.Text = cont.ToString();
                        if (cont == 4)
                        {
                            lbl_sucesso.Visible = true;
                            faseCompleta = 2;
                        }
                    }
                    else
                    {
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                        picture2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    }
                }
            }
        }
        #endregion
        #region Picture7
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[6]);
                numero[0] = 6;
                picture[0] = pictureBox6;
            }
            else
            {
                clicked = false;
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[6]);
                numero[1] = 6;
                picture[1] = pictureBox6;
                if (picture[0] == picture[1])
                {
                    pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    picture[0] = null;
                    picture[1] = null;
                    numero[0] = 0;
                    numero[1] = 0;
                }
                else
                {
                    if (arquivos[numero[0]].Equals(arquivos[numero[1]]))
                    {
                        pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[6]);
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Enabled = false;
                        picture2.Enabled = false;
                        cont++;
                        lbl_corretas.Text = cont.ToString();
                        if (cont == 4)
                        {
                            lbl_sucesso.Visible = true;
                            faseCompleta = 2;
                        }
                    }
                    else
                    {
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                        picture2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    }
                }
            }
        }
        #endregion
        #region Picture8
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[7]);
                numero[0] = 7;
                picture[0] = pictureBox5;
            }
            else
            {
                clicked = false;
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[7]);
                numero[1] = 7;
                picture[1] = pictureBox5;
                if (picture[0] == picture[1])
                {
                    picture[0] = null;
                    picture[1] = null;
                    numero[0] = 0;
                    numero[1] = 0;
                }
                else
                {
                    if (arquivos[numero[0]].Equals(arquivos[numero[1]]))
                    {
                        pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + arquivos[7]);
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Enabled = false;
                        picture2.Enabled = false;
                        cont++;
                        lbl_corretas.Text = cont.ToString();
                        if (cont == 4)
                        {
                            lbl_sucesso.Visible = true;
                            faseCompleta = 2;
                        }
                    }
                    else
                    {
                        PictureBox picture1 = picture[0];
                        PictureBox picture2 = picture[1];
                        picture1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                        picture2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/gen.png");
                    }
                }
            }
        }
        #endregion
    }
}
