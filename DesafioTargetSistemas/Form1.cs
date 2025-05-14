using System.Text;
using System.Xml.Linq;

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

        private void AnaliseFaturamentoDiario(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string tempFilePath = string.Empty;
                try
                {
                    // Corrige erro de leitura por multiplos elemntos raiz encapsulando todos em um unico elemento raiz
                    string xmlString = "<root>" + Environment.NewLine;
                    string linha;
                    string diretorio = openFileDialog1.FileName.Replace(openFileDialog1.SafeFileName, string.Empty);
                    string tempName = string.Format("{0}Temp.{1}", openFileDialog1.SafeFileName.Split('.')[0], openFileDialog1.SafeFileName.Split('.')[1]);
                    tempFilePath = diretorio + tempName;
                    StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("UTF-8"));
                    linha = sr.ReadLine();

                    while (linha != null)
                    {
                        xmlString += linha + Environment.NewLine;
                        linha = sr.ReadLine();
                    }
                    sr.Close();
                    xmlString += "</root>" + Environment.NewLine;

                    //Cria novo arquivo temporário
                    StreamWriter sw = new StreamWriter(tempFilePath, false, Encoding.GetEncoding("UTF-8"));
                    sw.Write(xmlString);
                    sw.Close();

                    // Ler o novo arquivo temporário
                    XDocument xmlDoc = XDocument.Load(tempFilePath);

                    var rows = from row in xmlDoc.Descendants("row")
                               select new
                               {
                                   Dia = row.Element("dia").Value,
                                   Valor = Convert.ToDouble(row.Element("valor").Value.Replace('.', ','))
                               };
                    //Deleta arquivo temporário
                    File.Delete(tempFilePath);

                    var diasFaturados = rows.Where(x => x.Valor > 0);
                    var menorFaturamento = diasFaturados.OrderBy(x => x.Valor).First();
                    var maiorFaturamento = diasFaturados.OrderByDescending(x => x.Valor).First();
                    var faturamentoMensal = diasFaturados.Sum(x => x.Valor);
                    var mediaMensal = faturamentoMensal / diasFaturados.Count();
                    int diasAcimaMedia = 0;
                    foreach (var dia in diasFaturados)
                    {
                        if (dia.Valor > mediaMensal)
                        {
                            diasAcimaMedia++;
                        }
                    }
                    string msg = String.Format("O menor faturamento em um dia do Mês: {0};{1}", menorFaturamento, Environment.NewLine);
                    msg += String.Format("O maior faturamento em um dia do Mês: {0};{1}", maiorFaturamento, Environment.NewLine);
                    msg += String.Format("Total de dias com faturamento acima da média: {0};{1}", diasAcimaMedia, Environment.NewLine);
                    lblRespostaFaturamento.Text = msg;
                }
                catch (Exception ex)
                {
                    File.Delete(tempFilePath);
                    Console.WriteLine($"Erro ao ler o arquivo XML: {ex.Message}");
                }

            }




        }


    }
}
