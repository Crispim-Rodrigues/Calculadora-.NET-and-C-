namespace Calculadora
{
    public partial class Calculadora : Form
    {
        //Global var:
        double numero1 = 0, numero2 = 0;
        char operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += button.Text;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);

            if (operador == '+')
            {
                txtResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '-')
            {
                txtResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '*')
            {
                txtResultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '/')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    msn.Text = "Não é possivel dividir por Zero";
                    msn.Visible = true;
                }

            }
        }

        private void ClickOperador(object sender, EventArgs e)
        {
            var botton = ((Button)sender);
            numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(botton.Tag);
            if (operador == '✓')
            {
                numero1 = Math.Sqrt(numero1);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                txtResultado.Text = numero1.ToString();
            }
            else if (operador == '%')
            {
                numero1 = numero1 / 100;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                txtResultado.Text = "0";
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else { txtResultado.Text = "0"; }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            numero1 *= -1;
            txtResultado.Text = numero1.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            txtResultado.Text = "0";
            operador = '\0';
        }

        private void btnLimparTodos_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }
    }
}