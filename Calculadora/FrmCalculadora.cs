namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //não permite digitacao
            e.Handled = true;
        }
        private void AgregarNumero(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += button.Text;
        }

    }
}