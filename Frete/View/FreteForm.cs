using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frete.View
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
           
            cBox_Estado.Items.Add("SP");
            cBox_Estado.Items.Add("RJ");
            cBox_Estado.Items.Add("BA");
            cBox_Estado.Items.Add("MG");
            cBox_Estado.Items.Add("GO");
            cBox_Estado.Items.Add("PE");
            cBox_Estado.Items.Add("MT");
            cBox_Estado.Items.Add("RS");
        }


        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            string uf = cBox_Estado.Text;
            decimal frete = Convert.ToDecimal(tb_valor.Text);
            decimal valor = 0;

            switch (uf)
            {
                case "SP":
                    valor = frete * 10 / 100;
                    break;
            }
            switch (uf)
            {
                case "RJ":
                    valor = frete * 10 / 100;
                    break;
            }
            switch (uf)
            {
                case "BA":
                    valor = frete * 20 / 100;
                    break;
            }
            switch (uf)
            {
                case "MG":
                    valor = frete * 15 / 100;
                    break;
            }
            switch (uf)
            {
                case "GO":
                    valor = frete * 20 / 100;
                    break;
            }
            switch (uf)
            {
                case "PE":
                    valor = frete *  30 / 100;
                    break;
            }
            switch (uf)
            {
                case "MT":
                    valor = frete * 50 / 100;
                    break;
            }
            switch (uf)
            {
                case "RS":
                    valor = frete * 10 / 100;
                    break;
            }


            lb_frete.Text = valor.ToString();
        }
    }
    }
