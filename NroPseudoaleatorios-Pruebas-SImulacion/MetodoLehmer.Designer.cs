namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    partial class MetodoLehmer
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
            resultRichTextBox = new RichTextBox();
            botonCalcular = new Button();
            label3 = new Label();
            semillaTextBox = new TextBox();
            label2 = new Label();
            digitosDeseadosTextBox = new TextBox();
            label1 = new Label();
            label4 = new Label();
            numeroEnteroTextBox = new TextBox();
            SuspendLayout();
            // 
            // resultRichTextBox
            // 
            resultRichTextBox.Location = new Point(20, 136);
            resultRichTextBox.Name = "resultRichTextBox";
            resultRichTextBox.Size = new Size(256, 290);
            resultRichTextBox.TabIndex = 13;
            resultRichTextBox.Text = "";
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(699, 86);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(75, 23);
            botonCalcular.TabIndex = 12;
            botonCalcular.Text = "Calcular";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 89);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Semilla:";
            // 
            // semillaTextBox
            // 
            semillaTextBox.Location = new Point(328, 86);
            semillaTextBox.Name = "semillaTextBox";
            semillaTextBox.Size = new Size(100, 23);
            semillaTextBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 9;
            label2.Text = "Digitos deseados:";
            // 
            // digitosDeseadosTextBox
            // 
            digitosDeseadosTextBox.Location = new Point(125, 86);
            digitosDeseadosTextBox.Name = "digitosDeseadosTextBox";
            digitosDeseadosTextBox.Size = new Size(100, 23);
            digitosDeseadosTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 45);
            label1.TabIndex = 7;
            label1.Text = "Metodo de Lehmer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 90);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 15;
            label4.Text = "Numero entero:";
            // 
            // numeroEnteroTextBox
            // 
            numeroEnteroTextBox.Location = new Point(556, 86);
            numeroEnteroTextBox.Name = "numeroEnteroTextBox";
            numeroEnteroTextBox.Size = new Size(100, 23);
            numeroEnteroTextBox.TabIndex = 14;
            // 
            // MetodoLehmer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(numeroEnteroTextBox);
            Controls.Add(resultRichTextBox);
            Controls.Add(botonCalcular);
            Controls.Add(label3);
            Controls.Add(semillaTextBox);
            Controls.Add(label2);
            Controls.Add(digitosDeseadosTextBox);
            Controls.Add(label1);
            Name = "MetodoLehmer";
            Text = "MetodoLehmer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox resultRichTextBox;
        private Button botonCalcular;
        private Label label3;
        private TextBox semillaTextBox;
        private Label label2;
        private TextBox digitosDeseadosTextBox;
        private Label label1;
        private Label label4;
        private TextBox numeroEnteroTextBox;
    }
}