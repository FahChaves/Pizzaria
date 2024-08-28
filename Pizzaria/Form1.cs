namespace Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor = 36.00;

            if (rbGrande.Checked)
                valor += valor * 0.13;
            else if (rbfamilia.Checked)
                valor += valor * 0.17;

            if (cbCebola.Checked)
                valor = valor + 2.50;
            if (cbMolho.Checked)
                valor = valor + 2.50;
            if (cbBordaRecheada.Checked)
                valor = valor + 2.50;
            if (cbQueijo.Checked)
                valor = valor + 2.50;

            if (!rbRetirada.Checked)
            {
                double entrega = 1.50;
                double distancia = double.Parse(texDistancia.Text);
                valor += entrega * distancia;
            }

            texTotal.Text = valor.ToString();
        }

        private void rbEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbRetirada.Checked)
            {
                lbDistancia.Visible = true;
                texDistancia.Visible = true;
                lbKm.Visible = true;
            }
            else
            {
                lbDistancia.Visible = false;
                texDistancia.Visible = false;
                lbKm.Visible = false;
            }
        }
    }
}
