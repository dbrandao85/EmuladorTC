﻿namespace EmuladorTC
{
    partial class Form1
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
            this.botaoConectar = new System.Windows.Forms.Button();
            this.textConectado = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mensagens = new System.Windows.Forms.TabPage();
            this.config = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ipCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipServidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.porta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.config.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoConectar
            // 
            this.botaoConectar.Location = new System.Drawing.Point(12, 393);
            this.botaoConectar.Name = "botaoConectar";
            this.botaoConectar.Size = new System.Drawing.Size(132, 45);
            this.botaoConectar.TabIndex = 0;
            this.botaoConectar.Text = "Conectar";
            this.botaoConectar.UseVisualStyleBackColor = true;
            this.botaoConectar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textConectado
            // 
            this.textConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConectado.Location = new System.Drawing.Point(12, 358);
            this.textConectado.Name = "textConectado";
            this.textConectado.ReadOnly = true;
            this.textConectado.Size = new System.Drawing.Size(116, 29);
            this.textConectado.TabIndex = 2;
            this.textConectado.Text = "Cliente OFF";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mensagens);
            this.tabControl1.Controls.Add(this.config);
            this.tabControl1.Location = new System.Drawing.Point(527, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(208, 450);
            this.tabControl1.TabIndex = 3;
            // 
            // mensagens
            // 
            this.mensagens.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mensagens.Location = new System.Drawing.Point(4, 22);
            this.mensagens.Name = "mensagens";
            this.mensagens.Padding = new System.Windows.Forms.Padding(3);
            this.mensagens.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mensagens.Size = new System.Drawing.Size(200, 424);
            this.mensagens.TabIndex = 0;
            this.mensagens.Text = "Mensagens";
            // 
            // config
            // 
            this.config.BackColor = System.Drawing.Color.WhiteSmoke;
            this.config.Controls.Add(this.groupBox2);
            this.config.Controls.Add(this.groupBox1);
            this.config.Location = new System.Drawing.Point(4, 22);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3);
            this.config.Size = new System.Drawing.Size(200, 424);
            this.config.TabIndex = 1;
            this.config.Text = "Configurações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ipCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nomeCliente);
            this.groupBox2.Location = new System.Drawing.Point(4, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 213);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // ipCliente
            // 
            this.ipCliente.Location = new System.Drawing.Point(51, 19);
            this.ipCliente.Name = "ipCliente";
            this.ipCliente.Size = new System.Drawing.Size(133, 20);
            this.ipCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(51, 45);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(133, 20);
            this.nomeCliente.TabIndex = 3;
            this.nomeCliente.Text = "Busca Preço G2 Emu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipServidor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.porta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidor";
            // 
            // ipServidor
            // 
            this.ipServidor.Location = new System.Drawing.Point(51, 28);
            this.ipServidor.Name = "ipServidor";
            this.ipServidor.Size = new System.Drawing.Size(133, 20);
            this.ipServidor.TabIndex = 1;
            this.ipServidor.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP:";
            // 
            // porta
            // 
            this.porta.Location = new System.Drawing.Point(51, 54);
            this.porta.Name = "porta";
            this.porta.Size = new System.Drawing.Size(133, 20);
            this.porta.TabIndex = 2;
            this.porta.Text = "6500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porta:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 466);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textConectado);
            this.Controls.Add(this.botaoConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Emulador Busca Preço G2";
            this.tabControl1.ResumeLayout(false);
            this.config.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoConectar;
        private System.Windows.Forms.TextBox textConectado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mensagens;
        private System.Windows.Forms.TabPage config;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox porta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipServidor;
        private System.Windows.Forms.TextBox ipCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

