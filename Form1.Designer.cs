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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botaoConectar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mensagens = new System.Windows.Forms.TabPage();
            this.txtTempoExibicao = new System.Windows.Forms.TextBox();
            this.TempoExibicao = new System.Windows.Forms.Label();
            this.texto4 = new System.Windows.Forms.Label();
            this.texto3 = new System.Windows.Forms.Label();
            this.texto2 = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.Label();
            this.txtTexto4 = new System.Windows.Forms.TextBox();
            this.txtTexto3 = new System.Windows.Forms.TextBox();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.config = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbDhcp = new System.Windows.Forms.RadioButton();
            this.rbIpFixo = new System.Windows.Forms.RadioButton();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.txtGatewayCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mascaraCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ipCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipServidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.porta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botaoConsulta = new System.Windows.Forms.Button();
            this.txtBuscarProduto = new System.Windows.Forms.TextBox();
            this.txtResultadoConsulta = new System.Windows.Forms.TextBox();
            this.pbImagemG2 = new System.Windows.Forms.PictureBox();
            this.ppFundo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.wifi = new System.Windows.Forms.GroupBox();
            this.checkBoxWifi = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.mensagens.SuspendLayout();
            this.config.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppFundo)).BeginInit();
            this.wifi.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoConectar
            // 
            this.botaoConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.botaoConectar.FlatAppearance.BorderSize = 0;
            this.botaoConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConectar.ForeColor = System.Drawing.Color.White;
            this.botaoConectar.Location = new System.Drawing.Point(5, 41);
            this.botaoConectar.Name = "botaoConectar";
            this.botaoConectar.Size = new System.Drawing.Size(379, 29);
            this.botaoConectar.TabIndex = 0;
            this.botaoConectar.Text = "Conectar";
            this.botaoConectar.UseVisualStyleBackColor = false;
            this.botaoConectar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mensagens);
            this.tabControl1.Controls.Add(this.config);
            this.tabControl1.Location = new System.Drawing.Point(390, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(230, 518);
            this.tabControl1.TabIndex = 3;
            // 
            // mensagens
            // 
            this.mensagens.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mensagens.Controls.Add(this.txtTempoExibicao);
            this.mensagens.Controls.Add(this.TempoExibicao);
            this.mensagens.Controls.Add(this.texto4);
            this.mensagens.Controls.Add(this.texto3);
            this.mensagens.Controls.Add(this.texto2);
            this.mensagens.Controls.Add(this.texto1);
            this.mensagens.Controls.Add(this.txtTexto4);
            this.mensagens.Controls.Add(this.txtTexto3);
            this.mensagens.Controls.Add(this.txtTexto2);
            this.mensagens.Controls.Add(this.txtTexto1);
            this.mensagens.Location = new System.Drawing.Point(4, 22);
            this.mensagens.Name = "mensagens";
            this.mensagens.Padding = new System.Windows.Forms.Padding(3);
            this.mensagens.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mensagens.Size = new System.Drawing.Size(222, 492);
            this.mensagens.TabIndex = 0;
            this.mensagens.Text = "Mensagens";
            // 
            // txtTempoExibicao
            // 
            this.txtTempoExibicao.Location = new System.Drawing.Point(17, 274);
            this.txtTempoExibicao.Name = "txtTempoExibicao";
            this.txtTempoExibicao.Size = new System.Drawing.Size(43, 20);
            this.txtTempoExibicao.TabIndex = 9;
            this.txtTempoExibicao.Text = "5";
            this.txtTempoExibicao.TextChanged += new System.EventHandler(this.txtTempoExibicao_TextChanged);
            // 
            // TempoExibicao
            // 
            this.TempoExibicao.AutoSize = true;
            this.TempoExibicao.Location = new System.Drawing.Point(17, 256);
            this.TempoExibicao.Name = "TempoExibicao";
            this.TempoExibicao.Size = new System.Drawing.Size(98, 13);
            this.TempoExibicao.TabIndex = 8;
            this.TempoExibicao.Text = "Tempo de Exibição";
            // 
            // texto4
            // 
            this.texto4.AutoSize = true;
            this.texto4.Location = new System.Drawing.Point(17, 201);
            this.texto4.Name = "texto4";
            this.texto4.Size = new System.Drawing.Size(43, 13);
            this.texto4.TabIndex = 7;
            this.texto4.Text = "Texto 4";
            // 
            // texto3
            // 
            this.texto3.AutoSize = true;
            this.texto3.Location = new System.Drawing.Point(17, 146);
            this.texto3.Name = "texto3";
            this.texto3.Size = new System.Drawing.Size(43, 13);
            this.texto3.TabIndex = 6;
            this.texto3.Text = "Texto 3";
            // 
            // texto2
            // 
            this.texto2.AutoSize = true;
            this.texto2.Location = new System.Drawing.Point(17, 86);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(43, 13);
            this.texto2.TabIndex = 5;
            this.texto2.Text = "Texto 2";
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Location = new System.Drawing.Point(17, 27);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(43, 13);
            this.texto1.TabIndex = 4;
            this.texto1.Text = "Texto 1";
            // 
            // txtTexto4
            // 
            this.txtTexto4.Location = new System.Drawing.Point(17, 217);
            this.txtTexto4.Name = "txtTexto4";
            this.txtTexto4.Size = new System.Drawing.Size(155, 20);
            this.txtTexto4.TabIndex = 3;
            this.txtTexto4.Text = "TEXTO4";
            this.txtTexto4.TextChanged += new System.EventHandler(this.txtTexto4_TextChanged);
            // 
            // txtTexto3
            // 
            this.txtTexto3.Location = new System.Drawing.Point(17, 162);
            this.txtTexto3.Name = "txtTexto3";
            this.txtTexto3.Size = new System.Drawing.Size(155, 20);
            this.txtTexto3.TabIndex = 2;
            this.txtTexto3.Text = "TEXTO3";
            this.txtTexto3.TextChanged += new System.EventHandler(this.txtTexto3_TextChanged);
            // 
            // txtTexto2
            // 
            this.txtTexto2.Location = new System.Drawing.Point(17, 102);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.Size = new System.Drawing.Size(155, 20);
            this.txtTexto2.TabIndex = 1;
            this.txtTexto2.Text = "TEXTO2";
            this.txtTexto2.TextChanged += new System.EventHandler(this.txtTexto2_TextChanged);
            // 
            // txtTexto1
            // 
            this.txtTexto1.Location = new System.Drawing.Point(17, 46);
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(155, 20);
            this.txtTexto1.TabIndex = 0;
            this.txtTexto1.Text = "TEXTO1";
            this.txtTexto1.TextChanged += new System.EventHandler(this.txtTexto1_TextChanged);
            // 
            // config
            // 
            this.config.BackColor = System.Drawing.Color.WhiteSmoke;
            this.config.Controls.Add(this.wifi);
            this.config.Controls.Add(this.groupBox2);
            this.config.Controls.Add(this.groupBox1);
            this.config.Location = new System.Drawing.Point(4, 22);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3);
            this.config.Size = new System.Drawing.Size(222, 492);
            this.config.TabIndex = 1;
            this.config.Text = "Configurações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMac);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rbDhcp);
            this.groupBox2.Controls.Add(this.rbIpFixo);
            this.groupBox2.Controls.Add(this.nomeCliente);
            this.groupBox2.Controls.Add(this.txtGatewayCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mascaraCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ipCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 181);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(51, 145);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(155, 20);
            this.txtMac.TabIndex = 7;
            this.txtMac.TabStop = false;
            this.txtMac.Text = "00:00:00:00:00:00";
            this.txtMac.TextChanged += new System.EventHandler(this.txtMac_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "MAC:";
            // 
            // rbDhcp
            // 
            this.rbDhcp.AutoSize = true;
            this.rbDhcp.Location = new System.Drawing.Point(112, 44);
            this.rbDhcp.Name = "rbDhcp";
            this.rbDhcp.Size = new System.Drawing.Size(55, 17);
            this.rbDhcp.TabIndex = 11;
            this.rbDhcp.Text = "DHCP";
            this.rbDhcp.UseVisualStyleBackColor = true;
            this.rbDhcp.CheckedChanged += new System.EventHandler(this.rbDhcp_CheckedChanged);
            // 
            // rbIpFixo
            // 
            this.rbIpFixo.AutoSize = true;
            this.rbIpFixo.Checked = true;
            this.rbIpFixo.Location = new System.Drawing.Point(50, 44);
            this.rbIpFixo.Name = "rbIpFixo";
            this.rbIpFixo.Size = new System.Drawing.Size(56, 17);
            this.rbIpFixo.TabIndex = 10;
            this.rbIpFixo.TabStop = true;
            this.rbIpFixo.Text = "Ip Fixo";
            this.rbIpFixo.UseVisualStyleBackColor = true;
            this.rbIpFixo.CheckedChanged += new System.EventHandler(this.rbIpFixo_CheckedChanged);
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(51, 19);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(155, 20);
            this.nomeCliente.TabIndex = 3;
            this.nomeCliente.Text = "EmuTC";
            // 
            // txtGatewayCliente
            // 
            this.txtGatewayCliente.Location = new System.Drawing.Point(51, 119);
            this.txtGatewayCliente.Name = "txtGatewayCliente";
            this.txtGatewayCliente.Size = new System.Drawing.Size(155, 20);
            this.txtGatewayCliente.TabIndex = 6;
            this.txtGatewayCliente.Text = "192.168.0.1";
            this.txtGatewayCliente.TextChanged += new System.EventHandler(this.gatewayCliente_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gateway:";
            // 
            // mascaraCliente
            // 
            this.mascaraCliente.Location = new System.Drawing.Point(51, 93);
            this.mascaraCliente.Name = "mascaraCliente";
            this.mascaraCliente.Size = new System.Drawing.Size(155, 20);
            this.mascaraCliente.TabIndex = 5;
            this.mascaraCliente.Text = "255.255.255.0";
            this.mascaraCliente.TextChanged += new System.EventHandler(this.mascaraCliente_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mascara:";
            // 
            // ipCliente
            // 
            this.ipCliente.Location = new System.Drawing.Point(51, 67);
            this.ipCliente.Name = "ipCliente";
            this.ipCliente.Size = new System.Drawing.Size(155, 20);
            this.ipCliente.TabIndex = 4;
            this.ipCliente.Text = "192.168.0.100";
            this.ipCliente.TextChanged += new System.EventHandler(this.ipCliente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipServidor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.porta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidor";
            // 
            // ipServidor
            // 
            this.ipServidor.Location = new System.Drawing.Point(51, 28);
            this.ipServidor.Name = "ipServidor";
            this.ipServidor.Size = new System.Drawing.Size(155, 20);
            this.ipServidor.TabIndex = 1;
            this.ipServidor.Text = "127.0.0.1";
            this.ipServidor.TextChanged += new System.EventHandler(this.ipServidor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP:";
            // 
            // porta
            // 
            this.porta.Location = new System.Drawing.Point(51, 54);
            this.porta.Name = "porta";
            this.porta.Size = new System.Drawing.Size(155, 20);
            this.porta.TabIndex = 2;
            this.porta.Text = "6500";
            this.porta.TextChanged += new System.EventHandler(this.porta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porta:";
            // 
            // botaoConsulta
            // 
            this.botaoConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.botaoConsulta.FlatAppearance.BorderSize = 0;
            this.botaoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoConsulta.ForeColor = System.Drawing.Color.White;
            this.botaoConsulta.Location = new System.Drawing.Point(117, 492);
            this.botaoConsulta.Name = "botaoConsulta";
            this.botaoConsulta.Size = new System.Drawing.Size(151, 32);
            this.botaoConsulta.TabIndex = 7;
            this.botaoConsulta.Text = "Consultar";
            this.botaoConsulta.UseVisualStyleBackColor = false;
            this.botaoConsulta.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduto.Location = new System.Drawing.Point(132, 340);
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.Size = new System.Drawing.Size(126, 26);
            this.txtBuscarProduto.TabIndex = 8;
            this.txtBuscarProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultadoConsulta
            // 
            this.txtResultadoConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(20)))));
            this.txtResultadoConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultadoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoConsulta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtResultadoConsulta.Location = new System.Drawing.Point(81, 199);
            this.txtResultadoConsulta.Multiline = true;
            this.txtResultadoConsulta.Name = "txtResultadoConsulta";
            this.txtResultadoConsulta.ReadOnly = true;
            this.txtResultadoConsulta.Size = new System.Drawing.Size(227, 45);
            this.txtResultadoConsulta.TabIndex = 9;
            this.txtResultadoConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbImagemG2
            // 
            this.pbImagemG2.ErrorImage = null;
            this.pbImagemG2.Image = ((System.Drawing.Image)(resources.GetObject("pbImagemG2.Image")));
            this.pbImagemG2.InitialImage = null;
            this.pbImagemG2.Location = new System.Drawing.Point(5, 78);
            this.pbImagemG2.Name = "pbImagemG2";
            this.pbImagemG2.Size = new System.Drawing.Size(383, 408);
            this.pbImagemG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemG2.TabIndex = 10;
            this.pbImagemG2.TabStop = false;
            // 
            // ppFundo
            // 
            this.ppFundo.Image = ((System.Drawing.Image)(resources.GetObject("ppFundo.Image")));
            this.ppFundo.Location = new System.Drawing.Point(-2, 0);
            this.ppFundo.Name = "ppFundo";
            this.ppFundo.Size = new System.Drawing.Size(630, 554);
            this.ppFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ppFundo.TabIndex = 11;
            this.ppFundo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Busca Preço G2",
            "Busca Preço"});
            this.cbModelo.Location = new System.Drawing.Point(92, 9);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(152, 28);
            this.cbModelo.TabIndex = 12;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.CbModelo_SelectedIndexChanged);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(12, 12);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(65, 20);
            this.lblModelo.TabIndex = 13;
            this.lblModelo.Text = "Modelo:";
            // 
            // wifi
            // 
            this.wifi.Controls.Add(this.checkBoxWifi);
            this.wifi.Location = new System.Drawing.Point(4, 290);
            this.wifi.Name = "wifi";
            this.wifi.Size = new System.Drawing.Size(212, 180);
            this.wifi.TabIndex = 7;
            this.wifi.TabStop = false;
            this.wifi.Text = "Wi-Fi";
            // 
            // checkBoxWifi
            // 
            this.checkBoxWifi.AutoSize = true;
            this.checkBoxWifi.Location = new System.Drawing.Point(41, 0);
            this.checkBoxWifi.Name = "checkBoxWifi";
            this.checkBoxWifi.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWifi.TabIndex = 0;
            this.checkBoxWifi.UseVisualStyleBackColor = true;
            this.checkBoxWifi.CheckedChanged += new System.EventHandler(this.checkBoxWifi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 546);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.txtBuscarProduto);
            this.Controls.Add(this.txtResultadoConsulta);
            this.Controls.Add(this.botaoConsulta);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.botaoConectar);
            this.Controls.Add(this.pbImagemG2);
            this.Controls.Add(this.ppFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emulador Busca Preço G2";
            this.tabControl1.ResumeLayout(false);
            this.mensagens.ResumeLayout(false);
            this.mensagens.PerformLayout();
            this.config.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppFundo)).EndInit();
            this.wifi.ResumeLayout(false);
            this.wifi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoConectar;
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
        private System.Windows.Forms.TextBox txtGatewayCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mascaraCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botaoConsulta;
        private System.Windows.Forms.TextBox txtBuscarProduto;
        private System.Windows.Forms.TextBox txtResultadoConsulta;
        private System.Windows.Forms.Label texto4;
        private System.Windows.Forms.Label texto3;
        private System.Windows.Forms.Label texto2;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.TextBox txtTexto4;
        private System.Windows.Forms.TextBox txtTexto3;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.TextBox txtTexto1;
        private System.Windows.Forms.TextBox txtTempoExibicao;
        private System.Windows.Forms.Label TempoExibicao;
        private System.Windows.Forms.PictureBox pbImagemG2;
        private System.Windows.Forms.PictureBox ppFundo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbDhcp;
        private System.Windows.Forms.RadioButton rbIpFixo;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox wifi;
        private System.Windows.Forms.CheckBox checkBoxWifi;
    }
}

