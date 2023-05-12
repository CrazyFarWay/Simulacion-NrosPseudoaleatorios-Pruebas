namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    partial class MetodoCongruencialMultiplicativo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            moduloTextBox = new TextBox();
            label4 = new Label();
            constanteMultiplicativaTextBox = new TextBox();
            resultRichTextBox = new RichTextBox();
            botonCalcular = new Button();
            label3 = new Label();
            semillaTextBox = new TextBox();
            label2 = new Label();
            digitosDeseadosTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 257);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 41;
            label6.Text = "Modulo";
            // 
            // moduloTextBox
            // 
            moduloTextBox.Location = new Point(195, 254);
            moduloTextBox.Name = "moduloTextBox";
            moduloTextBox.Size = new Size(100, 23);
            moduloTextBox.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 202);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 37;
            label4.Text = "Constante multiplicativa:";
            // 
            // constanteMultiplicativaTextBox
            // 
            constanteMultiplicativaTextBox.Location = new Point(195, 199);
            constanteMultiplicativaTextBox.Name = "constanteMultiplicativaTextBox";
            constanteMultiplicativaTextBox.Size = new Size(100, 23);
            constanteMultiplicativaTextBox.TabIndex = 36;
            // 
            // resultRichTextBox
            // 
            resultRichTextBox.Location = new Point(358, 104);
            resultRichTextBox.Name = "resultRichTextBox";
            resultRichTextBox.Size = new Size(415, 322);
            resultRichTextBox.TabIndex = 35;
            resultRichTextBox.Text = "";
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(121, 385);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(75, 23);
            botonCalcular.TabIndex = 34;
            botonCalcular.Text = "Calcular";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 33;
            label3.Text = "Semilla:";
            // 
            // semillaTextBox
            // 
            semillaTextBox.Location = new Point(195, 148);
            semillaTextBox.Name = "semillaTextBox";
            semillaTextBox.Size = new Size(100, 23);
            semillaTextBox.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 104);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 31;
            label2.Text = "Digitos deseados:";
            // 
            // digitosDeseadosTextBox
            // 
            digitosDeseadosTextBox.Location = new Point(195, 101);
            digitosDeseadosTextBox.Name = "digitosDeseadosTextBox";
            digitosDeseadosTextBox.Size = new Size(100, 23);
            digitosDeseadosTextBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(563, 45);
            label1.TabIndex = 29;
            label1.Text = "Metodo Congruencial Multiplicativo";
            // 
            // MetodoCongruencialMultiplicativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(moduloTextBox);
            Controls.Add(label4);
            Controls.Add(constanteMultiplicativaTextBox);
            Controls.Add(resultRichTextBox);
            Controls.Add(botonCalcular);
            Controls.Add(label3);
            Controls.Add(semillaTextBox);
            Controls.Add(label2);
            Controls.Add(digitosDeseadosTextBox);
            Controls.Add(label1);
            Name = "MetodoCongruencialMultiplicativo";
            Text = "MetodoCongruencialMultiplicativo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox moduloTextBox;
        private Label label4;
        private TextBox constanteMultiplicativaTextBox;
        private RichTextBox resultRichTextBox;
        private Button botonCalcular;
        private Label label3;
        private TextBox semillaTextBox;
        private Label label2;
        private TextBox digitosDeseadosTextBox;
        private Label label1;
    }
}