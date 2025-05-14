namespace DesafioTargetSistemas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbValorSOMA = new GroupBox();
            lblValorSOMA = new Label();
            label1 = new Label();
            btnRevelarSoma = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblRespostaFibonacci = new Label();
            lblSequenciaFibonacci = new Label();
            txtVerificarFibonacci = new TextBox();
            label3 = new Label();
            btnVerificarFibonacci = new Button();
            groupBox2 = new GroupBox();
            lblRespostaFaturamento = new Label();
            button1 = new Button();
            groupBox3 = new GroupBox();
            btnFaturamentoMensal = new Button();
            lblFaturamentoMensal = new Label();
            gbValorSOMA.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // gbValorSOMA
            // 
            gbValorSOMA.Controls.Add(lblValorSOMA);
            gbValorSOMA.Controls.Add(label1);
            gbValorSOMA.Controls.Add(btnRevelarSoma);
            gbValorSOMA.Location = new Point(12, 74);
            gbValorSOMA.Name = "gbValorSOMA";
            gbValorSOMA.Size = new Size(694, 115);
            gbValorSOMA.TabIndex = 0;
            gbValorSOMA.TabStop = false;
            gbValorSOMA.Text = "Valor da variável SOMA";
            // 
            // lblValorSOMA
            // 
            lblValorSOMA.AutoSize = true;
            lblValorSOMA.Location = new Point(60, 35);
            lblValorSOMA.Name = "lblValorSOMA";
            lblValorSOMA.Size = new Size(28, 15);
            lblValorSOMA.TabIndex = 2;
            lblValorSOMA.Text = "? ? ?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Valor:";
            // 
            // btnRevelarSoma
            // 
            btnRevelarSoma.Location = new Point(62, 61);
            btnRevelarSoma.Name = "btnRevelarSoma";
            btnRevelarSoma.Size = new Size(75, 23);
            btnRevelarSoma.TabIndex = 0;
            btnRevelarSoma.Text = "Revelar";
            btnRevelarSoma.UseVisualStyleBackColor = true;
            btnRevelarSoma.Click += RevelarSOMA;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(278, 23);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "S O L U Ç Õ E S";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblRespostaFibonacci);
            groupBox1.Controls.Add(lblSequenciaFibonacci);
            groupBox1.Controls.Add(txtVerificarFibonacci);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnVerificarFibonacci);
            groupBox1.Location = new Point(12, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 112);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Verificação Fibonacci";
            // 
            // lblRespostaFibonacci
            // 
            lblRespostaFibonacci.AutoSize = true;
            lblRespostaFibonacci.Location = new Point(203, 79);
            lblRespostaFibonacci.Name = "lblRespostaFibonacci";
            lblRespostaFibonacci.Size = new Size(57, 15);
            lblRespostaFibonacci.TabIndex = 4;
            lblRespostaFibonacci.Text = "Resposta:";
            // 
            // lblSequenciaFibonacci
            // 
            lblSequenciaFibonacci.AutoSize = true;
            lblSequenciaFibonacci.Location = new Point(203, 55);
            lblSequenciaFibonacci.Name = "lblSequenciaFibonacci";
            lblSequenciaFibonacci.Size = new Size(64, 15);
            lblSequenciaFibonacci.TabIndex = 3;
            lblSequenciaFibonacci.Text = "Sequência:";
            // 
            // txtVerificarFibonacci
            // 
            txtVerificarFibonacci.Location = new Point(49, 54);
            txtVerificarFibonacci.Name = "txtVerificarFibonacci";
            txtVerificarFibonacci.PlaceholderText = "Apenas número inteiro";
            txtVerificarFibonacci.Size = new Size(132, 23);
            txtVerificarFibonacci.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 28);
            label3.Name = "label3";
            label3.Size = new Size(362, 15);
            label3.TabIndex = 1;
            label3.Text = "Insira o numero para verificar se pertence à sequência de FIbonacci:";
            // 
            // btnVerificarFibonacci
            // 
            btnVerificarFibonacci.Location = new Point(74, 83);
            btnVerificarFibonacci.Name = "btnVerificarFibonacci";
            btnVerificarFibonacci.Size = new Size(75, 23);
            btnVerificarFibonacci.TabIndex = 0;
            btnVerificarFibonacci.Text = "Verificar";
            btnVerificarFibonacci.UseVisualStyleBackColor = true;
            btnVerificarFibonacci.Click += VerificaFibonacci_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblRespostaFaturamento);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 339);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(694, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Faturamento Diário da Distribuidora";
            // 
            // lblRespostaFaturamento
            // 
            lblRespostaFaturamento.AutoSize = true;
            lblRespostaFaturamento.Location = new Point(203, 28);
            lblRespostaFaturamento.Name = "lblRespostaFaturamento";
            lblRespostaFaturamento.Size = new Size(57, 15);
            lblRespostaFaturamento.TabIndex = 1;
            lblRespostaFaturamento.Text = "Resposta:";
            // 
            // button1
            // 
            button1.Location = new Point(17, 38);
            button1.Name = "button1";
            button1.Size = new Size(155, 23);
            button1.TabIndex = 0;
            button1.Text = "Carregar arquivo XML";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AnaliseFaturamentoDiario;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFaturamentoMensal);
            groupBox3.Controls.Add(lblFaturamentoMensal);
            groupBox3.Location = new Point(12, 457);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(694, 164);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Faturamento Mensal por Estado";
            // 
            // btnFaturamentoMensal
            // 
            btnFaturamentoMensal.Location = new Point(17, 28);
            btnFaturamentoMensal.Name = "btnFaturamentoMensal";
            btnFaturamentoMensal.Size = new Size(155, 23);
            btnFaturamentoMensal.TabIndex = 1;
            btnFaturamentoMensal.Text = "Ver Percentual";
            btnFaturamentoMensal.UseVisualStyleBackColor = true;
            btnFaturamentoMensal.Click += CalculaPercentualPorEstado;
            // 
            // lblFaturamentoMensal
            // 
            lblFaturamentoMensal.AutoSize = true;
            lblFaturamentoMensal.Location = new Point(176, 30);
            lblFaturamentoMensal.Name = "lblFaturamentoMensal";
            lblFaturamentoMensal.Size = new Size(57, 15);
            lblFaturamentoMensal.TabIndex = 0;
            lblFaturamentoMensal.Text = "Resposta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 790);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(gbValorSOMA);
            Name = "Form1";
            Text = "Desafio Técnico - Target Sistemas";
            gbValorSOMA.ResumeLayout(false);
            gbValorSOMA.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbValorSOMA;
        private Label lblValorSOMA;
        private Label label1;
        private Button btnRevelarSoma;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblSequenciaFibonacci;
        private TextBox txtVerificarFibonacci;
        private Label label3;
        private Button btnVerificarFibonacci;
        private Label lblRespostaFibonacci;
        private GroupBox groupBox2;
        private Label lblRespostaFaturamento;
        private Button button1;
        private GroupBox groupBox3;
        private Button btnFaturamentoMensal;
        private Label lblFaturamentoMensal;
    }
}
