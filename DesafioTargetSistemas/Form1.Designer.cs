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
            gbValorSOMA.SuspendLayout();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 587);
            Controls.Add(label2);
            Controls.Add(gbValorSOMA);
            Name = "Form1";
            Text = "Desafio Técnico - Target Sistemas";
            gbValorSOMA.ResumeLayout(false);
            gbValorSOMA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbValorSOMA;
        private Label lblValorSOMA;
        private Label label1;
        private Button btnRevelarSoma;
        private Label label2;
    }
}
