namespace NroPseudoaleatorios_Pruebas_SImulacion
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
            label1 = new Label();
            digitosDeseadosTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            semillaTextBox = new TextBox();
            botonCalcular = new Button();
            resultRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(626, 45);
            label1.TabIndex = 0;
            label1.Text = "Metodo de la parte central del cuadrado";
            // 
            // digitosDeseadosTextBox
            // 
            digitosDeseadosTextBox.Location = new Point(125, 86);
            digitosDeseadosTextBox.Name = "digitosDeseadosTextBox";
            digitosDeseadosTextBox.Size = new Size(100, 23);
            digitosDeseadosTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Digitos deseados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 89);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Semilla:";
            // 
            // semillaTextBox
            // 
            semillaTextBox.Location = new Point(328, 86);
            semillaTextBox.Name = "semillaTextBox";
            semillaTextBox.Size = new Size(100, 23);
            semillaTextBox.TabIndex = 3;
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(499, 86);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(75, 23);
            botonCalcular.TabIndex = 5;
            botonCalcular.Text = "Calcular";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // resultRichTextBox
            // 
            resultRichTextBox.Location = new Point(20, 136);
            resultRichTextBox.Name = "resultRichTextBox";
            resultRichTextBox.Size = new Size(256, 290);
            resultRichTextBox.TabIndex = 6;
            resultRichTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultRichTextBox);
            Controls.Add(botonCalcular);
            Controls.Add(label3);
            Controls.Add(semillaTextBox);
            Controls.Add(label2);
            Controls.Add(digitosDeseadosTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox digitosDeseadosTextBox;
        private Label label2;
        private Label label3;
        private TextBox semillaTextBox;
        private Button botonCalcular;
        private RichTextBox resultRichTextBox;
    }
}