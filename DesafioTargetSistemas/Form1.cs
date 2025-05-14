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

        private void VerificaFibonacci_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (int.TryParse(txtVerificarFibonacci.Text, out numero))
            {
                string msg = string.Empty, sequencia = "0_1";
                int anterior1 = 0, anterior2 = 1, maxFibonacci = 1;
                if (numero > 1)
                {
                    while (numero > maxFibonacci)
                    {
                        maxFibonacci = anterior1 + anterior2;
                        anterior1 = anterior2;
                        anterior2 = maxFibonacci;
                        sequencia += "_" + maxFibonacci;
                    }
                    if (numero == maxFibonacci) msg = numero + " pertence à sequência Fibonacci."; else msg = numero + " não pertence à sequência Fibonacci.";
                }
                else
                {
                    msg = numero + " pertence à sequência Fibonacci.";
                }
                lblSequenciaFibonacci.Text = sequencia;
                lblRespostaFibonacci.Text = msg;
            }
            else
            {
                txtVerificarFibonacci.ForeColor = Color.Red;
                lblRespostaFibonacci.Text = "Digite um numero válido";
            }

        }
    }
}
