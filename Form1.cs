﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace EmuladorTC
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Connection Conexao = new Connection();      

        private void Button1_Click(object sender, EventArgs e)
        {            
            try
            {
                if (Conexao.Conectado==false)
                {
                    // timer1.Start();
                    Conexao.DadosCliente(ipServidor.Text, porta.Text, nomeCliente.Text, ipCliente.Text, mascaraCliente.Text, gatewayCliente.Text);
                    Conexao.Connect(ipServidor.Text, int.Parse(porta.Text));
                    textConectado.Text = "Cliente ON";
                    botaoConectar.Text = "Desconectar";
                }
                else
                {
                    // timer1.Stop();
                    Conexao.Disconnect();
                    textConectado.Text = "Cliente OFF";
                    botaoConectar.Text = "Conectar";
                }

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            msgRecebida.Text = Conexao.MsgServer();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {            
            string produto;
            produto = Conexao.EnviarProduto(entradaProduto.Text);
            txtResultadoConsulta.Text = produto;
        }
    }
}
