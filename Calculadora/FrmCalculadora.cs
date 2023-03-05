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
               txtResultado.Text = (numero1+ numero2).ToString();
               numero1 = Convert.ToDouble(txtResultado.Text);
            }
        }

        private void ClickOperador(object sender, EventArgs e)
        {
            var botton = ((Button)sender);
            numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(botton.Tag);

            txtResultado.Text = "0";
        }

        
    }
}