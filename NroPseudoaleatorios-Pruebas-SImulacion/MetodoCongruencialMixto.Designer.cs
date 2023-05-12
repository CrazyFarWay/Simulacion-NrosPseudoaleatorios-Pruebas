namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    partial class MetodoCongruencialMixto
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
            label4 = new Label();
            constanteMultiplicativaTextBox = new TextBox();
            resultRichTextBox = new RichTextBox();
            botonCalcular = new Button();
            label3 = new Label();
            semillaTextBox = new TextBox();
            label2 = new Label();
            digitosDeseadosTextBox = new TextBox();
            label1 = new Label();
            label5 = new Label();
            constanteAditivaTextBox = new TextBox();
            label6 = new Label();
            moduloTextBox = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 195);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 24;
            label4.Text = "Constante multiplicativa:";
            // 
            // constanteMultiplicativaTextBox
            // 
            constanteMultiplicativaTextBox.Location = new Point(186, 192);
            constanteMultiplicativaTextBox.Name = "constanteMultiplicativaTextBox";
            constanteMultiplicativaTextBox.Size = new Size(100, 23);
            constanteMultiplicativaTextBox.TabIndex = 23;
            // 
            // resultRichTextBox
            // 
            resultRichTextBox.Location = new Point(349, 97);
            resultRichTextBox.Name = "resultRichTextBox";
            resultRichTextBox.Size = new Size(415, 322);
            resultRichTextBox.TabIndex = 22;
            resultRichTextBox.Text = "";
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(112, 378);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(75, 23);
            botonCalcular.TabIndex = 21;
            botonCalcular.Text = "Calcular";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 20;
            label3.Text = "Semilla:";
            // 
            // semillaTextBox
            // 
            semillaTextBox.Location = new Point(186, 141);
            semillaTextBox.Name = "semillaTextBox";
            semillaTextBox.Size = new Size(100, 23);
            semillaTextBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 97);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 18;
            label2.Text = "Digitos deseados:";
            // 
            // digitosDeseadosTextBox
            // 
            digitosDeseadosTextBox.Location = new Point(186, 94);
            digitosDeseadosTextBox.Name = "digitosDeseadosTextBox";
            digitosDeseadosTextBox.Size = new Size(100, 23);
            digitosDeseadosTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(445, 45);
            label1.TabIndex = 16;
            label1.Text = "Metodo Congruencial Mixto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 250);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 26;
            label5.Text = "Constante aditiva:";
            // 
            // constanteAditivaTextBox
            // 
            constanteAditivaTextBox.Location = new Point(186, 247);
            constanteAditivaTextBox.Name = "constanteAditivaTextBox";
            constanteAditivaTextBox.Size = new Size(100, 23);
            constanteAditivaTextBox.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 306);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 28;
            label6.Text = "Modulo";
            // 
            // moduloTextBox
            // 
            moduloTextBox.Location = new Point(186, 303);
            moduloTextBox.Name = "moduloTextBox";
            moduloTextBox.Size = new Size(100, 23);
            moduloTextBox.TabIndex = 27;
            // 
            // MetodoCongruencialMixto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(moduloTextBox);
            Controls.Add(label5);
            Controls.Add(constanteAditivaTextBox);
            Controls.Add(label4);
            Controls.Add(constanteMultiplicativaTextBox);
            Controls.Add(resultRichTextBox);
            Controls.Add(botonCalcular);
            Controls.Add(label3);
            Controls.Add(semillaTextBox);
            Controls.Add(label2);
            Controls.Add(digitosDeseadosTextBox);
            Controls.Add(label1);
            Name = "MetodoCongruencialMixto";
            Text = "MetodoCongruencialMixto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox constanteMultiplicativaTextBox;
        private RichTextBox resultRichTextBox;
        private Button botonCalcular;
        private Label label3;
        private TextBox semillaTextBox;
        private Label label2;
        private TextBox digitosDeseadosTextBox;
        private Label label1;
        private Label label5;
        private TextBox constanteAditivaTextBox;
        private Label label6;
        private TextBox moduloTextBox;
    }
}