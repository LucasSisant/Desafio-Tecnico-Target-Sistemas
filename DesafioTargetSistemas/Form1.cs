namespace DesafioTargetSistemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RevelarSOMA(object sender, EventArgs e)
        {
            int indice = 13, soma = 0, k = 0;
            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            lblValorSOMA.Text = soma.ToString();
        }
    }
}
