namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    partial class PruebaPromedio
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
            label2 = new Label();
            digitosDeseadosTextBox = new TextBox();
            label1 = new Label();
            semillasRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // resultRichTextBox
            // 
            resultRichTextBox.Location = new Point(326, 101);
            resultRichTextBox.Name = "resultRichTextBox";
            resultRichTextBox.Size = new Size(435, 264);
            resultRichTextBox.TabIndex = 48;
            resultRichTextBox.Text = "";
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(82, 320);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(103, 45);
            botonCalcular.TabIndex = 47;
            botonCalcular.Text = "Calcular";
            botonCalcular.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 46;
            label3.Text = "Semillas: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 104);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 44;
            label2.Text = "Estadistico:";
            // 
            // digitosDeseadosTextBox
            // 
            digitosDeseadosTextBox.Location = new Point(129, 101);
            digitosDeseadosTextBox.Name = "digitosDeseadosTextBox";
            digitosDeseadosTextBox.Size = new Size(100, 23);
            digitosDeseadosTextBox.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(409, 45);
            label1.TabIndex = 42;
            label1.Text = "Pruebas de los Promedios";
            // 
            // semillasRichTextBox
            // 
            semillasRichTextBox.Location = new Point(129, 148);
            semillasRichTextBox.Name = "semillasRichTextBox";
            semillasRichTextBox.Size = new Size(100, 121);
            semillasRichTextBox.TabIndex = 54;
            semillasRichTextBox.Text = "";
            // 
            // PruebaPromedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(semillasRichTextBox);
            Controls.Add(resultRichTextBox);
            Controls.Add(botonCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(digitosDeseadosTextBox);
            Controls.Add(label1);
            Name = "PruebaPromedio";
            Text = "Pruebas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox resultRichTextBox;
        private Button botonCalcular;
        private Label label3;
        private Label label2;
        private TextBox digitosDeseadosTextBox;
        private Label label1;
        private RichTextBox semillasRichTextBox;
    }
}