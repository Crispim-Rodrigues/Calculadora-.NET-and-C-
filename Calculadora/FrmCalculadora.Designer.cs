namespace Calculadora
{
    partial class Calculadora
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
            txtResultado = new TextBox();
            btnVirgula = new Button();
            btnSubtrair = new Button();
            btnIgual = new Button();
            btnZero = new Button();
            btn01 = new Button();
            btn02 = new Button();
            btn03 = new Button();
            btnMultiplicar = new Button();
            btnSobre1 = new Button();
            btn04 = new Button();
            btn05 = new Button();
            btn06 = new Button();
            btnDividir = new Button();
            btnPorcentagem = new Button();
            btn07 = new Button();
            btn08 = new Button();
            btn09 = new Button();
            btnMaisMenos = new Button();
            btnRaiz = new Button();
            btnSoma = new Button();
            btnLimpar = new Button();
            btnLimparTodos = new Button();
            btnApagar = new Button();
            msn = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.ActiveBorder;
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(12, 12);
            txtResultado.MaxLength = 15;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(359, 54);
            txtResultado.TabIndex = 20;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(158, 364);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(67, 59);
            btnVirgula.TabIndex = 23;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(231, 297);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(67, 59);
            btnSubtrair.TabIndex = 24;
            btnSubtrair.Tag = "-";
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += ClickOperador;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(304, 297);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(67, 124);
            btnIgual.TabIndex = 25;
            btnIgual.Tag = "=";
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(12, 364);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(140, 59);
            btnZero.TabIndex = 21;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += AgregarNumero;
            // 
            // btn01
            // 
            btn01.Location = new Point(12, 299);
            btn01.Name = "btn01";
            btn01.Size = new Size(67, 59);
            btn01.TabIndex = 26;
            btn01.Text = "1";
            btn01.UseVisualStyleBackColor = true;
            btn01.Click += AgregarNumero;
            // 
            // btn02
            // 
            btn02.Location = new Point(85, 299);
            btn02.Name = "btn02";
            btn02.Size = new Size(67, 59);
            btn02.TabIndex = 27;
            btn02.Text = "2";
            btn02.UseVisualStyleBackColor = true;
            btn02.Click += AgregarNumero;
            // 
            // btn03
            // 
            btn03.Location = new Point(158, 299);
            btn03.Name = "btn03";
            btn03.Size = new Size(67, 59);
            btn03.TabIndex = 28;
            btn03.Text = "3";
            btn03.UseVisualStyleBackColor = true;
            btn03.Click += AgregarNumero;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(231, 232);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(67, 59);
            btnMultiplicar.TabIndex = 29;
            btnMultiplicar.Tag = "*";
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += ClickOperador;
            // 
            // btnSobre1
            // 
            btnSobre1.Location = new Point(304, 232);
            btnSobre1.Name = "btnSobre1";
            btnSobre1.Size = new Size(67, 59);
            btnSobre1.TabIndex = 30;
            btnSobre1.Tag = "²";
            btnSobre1.Text = "x²";
            btnSobre1.UseVisualStyleBackColor = true;
            btnSobre1.Click += ClickOperador;
            // 
            // btn04
            // 
            btn04.Location = new Point(12, 234);
            btn04.Name = "btn04";
            btn04.Size = new Size(67, 59);
            btn04.TabIndex = 31;
            btn04.Text = "4";
            btn04.UseVisualStyleBackColor = true;
            btn04.Click += AgregarNumero;
            // 
            // btn05
            // 
            btn05.Location = new Point(85, 234);
            btn05.Name = "btn05";
            btn05.Size = new Size(67, 59);
            btn05.TabIndex = 32;
            btn05.Text = "5";
            btn05.UseVisualStyleBackColor = true;
            btn05.Click += AgregarNumero;
            // 
            // btn06
            // 
            btn06.Location = new Point(158, 234);
            btn06.Name = "btn06";
            btn06.Size = new Size(67, 59);
            btn06.TabIndex = 33;
            btn06.Text = "6";
            btn06.UseVisualStyleBackColor = true;
            btn06.Click += AgregarNumero;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(231, 167);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(67, 59);
            btnDividir.TabIndex = 34;
            btnDividir.Tag = "/";
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += ClickOperador;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.Location = new Point(304, 167);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(67, 59);
            btnPorcentagem.TabIndex = 35;
            btnPorcentagem.Tag = "%";
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = true;
            btnPorcentagem.Click += ClickOperador;
            // 
            // btn07
            // 
            btn07.Location = new Point(12, 169);
            btn07.Name = "btn07";
            btn07.Size = new Size(67, 59);
            btn07.TabIndex = 36;
            btn07.Text = "7";
            btn07.UseVisualStyleBackColor = true;
            btn07.Click += AgregarNumero;
            // 
            // btn08
            // 
            btn08.Location = new Point(85, 169);
            btn08.Name = "btn08";
            btn08.Size = new Size(67, 59);
            btn08.TabIndex = 37;
            btn08.Text = "8";
            btn08.UseVisualStyleBackColor = true;
            btn08.Click += AgregarNumero;
            // 
            // btn09
            // 
            btn09.Location = new Point(158, 169);
            btn09.Name = "btn09";
            btn09.Size = new Size(67, 59);
            btn09.TabIndex = 38;
            btn09.Text = "9";
            btn09.UseVisualStyleBackColor = true;
            btn09.Click += AgregarNumero;
            // 
            // btnMaisMenos
            // 
            btnMaisMenos.Location = new Point(231, 102);
            btnMaisMenos.Name = "btnMaisMenos";
            btnMaisMenos.Size = new Size(67, 59);
            btnMaisMenos.TabIndex = 39;
            btnMaisMenos.Tag = "+/-";
            btnMaisMenos.Text = "+/-";
            btnMaisMenos.UseVisualStyleBackColor = true;
            btnMaisMenos.Click += btnMaisMenos_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(304, 102);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(67, 59);
            btnRaiz.TabIndex = 40;
            btnRaiz.Tag = "✓";
            btnRaiz.Text = "✓";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += ClickOperador;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(231, 364);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(67, 59);
            btnSoma.TabIndex = 41;
            btnSoma.Tag = "+";
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += ClickOperador;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(158, 102);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(67, 59);
            btnLimpar.TabIndex = 42;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnLimparTodos
            // 
            btnLimparTodos.Location = new Point(85, 102);
            btnLimparTodos.Name = "btnLimparTodos";
            btnLimparTodos.Size = new Size(67, 59);
            btnLimparTodos.TabIndex = 43;
            btnLimparTodos.Text = "CE";
            btnLimparTodos.UseVisualStyleBackColor = true;
            btnLimparTodos.Click += btnLimparTodos_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(12, 102);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(67, 59);
            btnApagar.TabIndex = 44;
            btnApagar.Text = "←";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // msn
            // 
            msn.AutoSize = true;
            msn.Location = new Point(15, 76);
            msn.Name = "msn";
            msn.Size = new Size(30, 15);
            msn.TabIndex = 45;
            msn.Text = "msn";
            msn.Visible = false;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 436);
            Controls.Add(msn);
            Controls.Add(btnApagar);
            Controls.Add(btnLimparTodos);
            Controls.Add(btnLimpar);
            Controls.Add(btnSoma);
            Controls.Add(btnRaiz);
            Controls.Add(btnMaisMenos);
            Controls.Add(btn09);
            Controls.Add(btn08);
            Controls.Add(btn07);
            Controls.Add(btnPorcentagem);
            Controls.Add(btnDividir);
            Controls.Add(btn06);
            Controls.Add(btn05);
            Controls.Add(btn04);
            Controls.Add(btnSobre1);
            Controls.Add(btnMultiplicar);
            Controls.Add(btn03);
            Controls.Add(btn02);
            Controls.Add(btn01);
            Controls.Add(btnIgual);
            Controls.Add(btnSubtrair);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(txtResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtResultado;
        private Button btnVirgula;
        private Button btnSubtrair;
        private Button btnIgual;
        private Button btnZero;
        private Button btn01;
        private Button btn02;
        private Button btn03;
        private Button btnMultiplicar;
        private Button btnSobre1;
        private Button btn04;
        private Button btn05;
        private Button btn06;
        private Button btnDividir;
        private Button btnPorcentagem;
        private Button btn07;
        private Button btn08;
        private Button btn09;
        private Button btnMaisMenos;
        private Button btnRaiz;
        private Button btnSoma;
        private Button btnLimpar;
        private Button btnLimparTodos;
        private Button btnApagar;
        private Label msn;
    }
}