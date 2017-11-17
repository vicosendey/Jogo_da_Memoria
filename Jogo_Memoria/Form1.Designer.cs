namespace Jogo_Memoria
{
    partial class Frm_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.btn_comecar = new System.Windows.Forms.Button();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_sobre);
            this.panel1.Controls.Add(this.btn_comecar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 337);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jogo da Memória";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Ivory;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(218, 244);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(125, 39);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_sobre
            // 
            this.btn_sobre.BackColor = System.Drawing.Color.Ivory;
            this.btn_sobre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sobre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sobre.Location = new System.Drawing.Point(218, 192);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Size = new System.Drawing.Size(125, 39);
            this.btn_sobre.TabIndex = 1;
            this.btn_sobre.Text = "Sobre";
            this.btn_sobre.UseVisualStyleBackColor = false;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // btn_comecar
            // 
            this.btn_comecar.BackColor = System.Drawing.Color.Ivory;
            this.btn_comecar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_comecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comecar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comecar.Location = new System.Drawing.Point(218, 140);
            this.btn_comecar.Name = "btn_comecar";
            this.btn_comecar.Size = new System.Drawing.Size(125, 39);
            this.btn_comecar.TabIndex = 0;
            this.btn_comecar.Text = "Começar";
            this.btn_comecar.UseVisualStyleBackColor = false;
            this.btn_comecar.Click += new System.EventHandler(this.btn_comecar_Click);
            // 
            // timer_1
            // 
            this.timer_1.Enabled = true;
            this.timer_1.Interval = 500;
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_sobre;
        private System.Windows.Forms.Button btn_comecar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_1;
    }
}

