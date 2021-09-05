using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double operando1;
        char operacion;
        bool chequearIngreso = true;
        double result;
        public Calculadora()
        {
            InitializeComponent();
        }

        public void ResultadoOperacion()
        {

            try
            {

                switch (this.operacion)
                {
                    case 'x':
                        this.result = this.operando1 * Convert.ToDouble(txtVisor.Text);
                        break;

                    case '-':
                        this.result = this.operando1 - Convert.ToDouble(txtVisor.Text);
                        break;

                    case '+':
                        this.result = this.operando1 + Convert.ToDouble(txtVisor.Text);
                        break;

                    case '/':
                        this.result = this.operando1 / Convert.ToDouble(txtVisor.Text);
                        break;

                    case '%':
                        this.result = (this.operando1 * Convert.ToDouble(txtVisor.Text)) / 100;
                        break;
                }

                txtVisor.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por 0", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        public void CargarDato(char dato)
        {
            //Carga de datos numericos
            switch (dato)
            {
                case '1':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "1";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "1";
                    }
                    break;
                case '2':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "2";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "2";
                    }
                    break;
                case '3':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "3";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "3";
                    }
                    break;
                case '4':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "4";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "4";
                    }
                    break;
                case '5':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "5";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "5";
                    }
                    break;
                case '6':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "6";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "6";
                    }
                    break;
                case '7':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "7";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "7";
                    }
                    break;
                case '8':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "8";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "8";
                    }
                    break;
                case '9':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "9";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += "9";
                    }
                    break;
                case '0':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "0";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        if (!txtVisor.Equals("0"))
                        {
                            txtVisor.Text += "0";
                        }

                    }
                    break;
                case ',':
                    if (chequearIngreso || txtVisor.Equals('0'))
                    {
                        txtVisor.Text = "0,";
                        this.chequearIngreso = false;
                    }
                    else
                    {
                        txtVisor.Text += ",";
                    }
                    break;

                //Carga de datos operaciones

                case 'x':
                    this.operando1 = Convert.ToDouble(txtVisor.Text);
                    this.operacion = 'x';
                    this.chequearIngreso = true;

                    break;
                case '+':
                    this.operando1 = Convert.ToDouble(txtVisor.Text);
                    this.operacion = '+';
                    this.chequearIngreso = true;

                    break;
                case '-':
                    this.operando1 = Convert.ToDouble(txtVisor.Text);
                    this.operacion = '-';
                    this.chequearIngreso = true;

                    break;
                case '%':
                    this.operando1 = Convert.ToDouble(txtVisor.Text);
                    this.operacion = '%';
                    this.chequearIngreso = true;

                    break;
                case '/':
                    this.operando1 = Convert.ToDouble(txtVisor.Text);
                    this.operacion = '/';
                    this.chequearIngreso = true;

                    break;

            }


        }

        private void txtBot1_Click(object sender, EventArgs e)
        {

            CargarDato('1');
        }

        private void txtBot2_Click(object sender, EventArgs e)
        {
            CargarDato('2');
        }

        private void txtBot3_Click(object sender, EventArgs e)
        {
            CargarDato('3');
        }

        private void txtBot4_Click(object sender, EventArgs e)
        {
            CargarDato('4');
        }

        private void txtBot5_Click(object sender, EventArgs e)
        {
            CargarDato('5');
        }

        private void txtBot6_Click(object sender, EventArgs e)
        {
            CargarDato('6');
        }

        private void txtBot7_Click(object sender, EventArgs e)
        {
            CargarDato('7');
        }

        private void txtBot8_Click(object sender, EventArgs e)
        {
            CargarDato('8');
        }

        private void txtBot9_Click(object sender, EventArgs e)
        {
            CargarDato('9');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CargarDato('0');
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CargarDato(',');
        }

        private void txtBotLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            this.operando1 = 0;
            this.chequearIngreso = true;
            txtVisor.Focus();

        }

        private void txtBotBorarNum_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Count() > 0)
            {
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Count() - 1);


            }
            if (txtVisor.Text.Count() == 0)
            {
                txtVisor.Text = "0";
                this.chequearIngreso = true;
            }

        }

        private void txtBotMultiplicacion_Click(object sender, EventArgs e)
        {
            CargarDato('x');
        }

        private void txtBotResta_Click(object sender, EventArgs e)
        {
            CargarDato('-');
        }

        private void txtBotSuma_Click(object sender, EventArgs e)
        {
            CargarDato('+');
        }

        private void txtBotPorcentaje_Click(object sender, EventArgs e)
        {
            CargarDato('%');
        }

        private void txtBotDivision_Click(object sender, EventArgs e)
        {
            CargarDato('/');
        }

        private void txtBotResultado_Click(object sender, EventArgs e)
        {
            ResultadoOperacion();
        }

        private void BotonCambioSigno_Click(object sender, EventArgs e)
        {
            if (!txtVisor.Text[0].Equals('-'))
            {
                txtVisor.Text = '-' + txtVisor.Text;
            }
            else
            {
                if (txtVisor.Text[0].Equals('-'))
                {
                    txtVisor.Text=txtVisor.Text.Replace("-",string.Empty);
                }

            }
           
        }

        private void txtBotLimpiarEntrada_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            this.operando1 = 0;
            this.chequearIngreso = true;
            txtVisor.Focus();
        }
    }
}
