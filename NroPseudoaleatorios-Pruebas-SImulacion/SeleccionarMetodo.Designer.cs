namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    partial class SeleccionarMetodo
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
            botonMetodoCuadrado = new Button();
            label1 = new Label();
            label2 = new Label();
            botonMetodoLehmer = new Button();
            botonMetodoCongruencialMixto = new Button();
            botonMetodoCongruencialAditivo = new Button();
            botonMetodoCongruencialMultiplicativo = new Button();
            SuspendLayout();
            // 
            // botonMetodoCuadrado
            // 
            botonMetodoCuadrado.BackColor = Color.Gold;
            botonMetodoCuadrado.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            botonMetodoCuadrado.Location = new Point(102, 217);
            botonMetodoCuadrado.Name = "botonMetodoCuadrado";
            botonMetodoCuadrado.Size = new Size(121, 48);
            botonMetodoCuadrado.TabIndex = 0;
            botonMetodoCuadrado.Text = "Cuadrado";
            botonMetodoCuadrado.UseVisualStyleBackColor = false;
            botonMetodoCuadrado.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Imprint MT Shadow", 30F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(735, 47);
            label1.TabIndex = 1;
            label1.Text = "Generador de Números Pseudo Aleatorios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("High Tower Text", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(334, 121);
            label2.Name = "label2";
            label2.Size = new Size(133, 37);
            label2.TabIndex = 2;
            label2.Text = "Metodos";
            // 
            // botonMetodoLehmer
            // 
            botonMetodoLehmer.BackColor = Color.Gold;
            botonMetodoLehmer.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            botonMetodoLehmer.Location = new Point(339, 217);
            botonMetodoLehmer.Name = "botonMetodoLehmer";
            botonMetodoLehmer.Size = new Size(121, 48);
            botonMetodoLehmer.TabIndex = 3;
            botonMetodoLehmer.Text = "Lehemer";
            botonMetodoLehmer.UseVisualStyleBackColor = false;
            botonMetodoLehmer.Click += botonMetodoLehmer_Click;
            // 
            // botonMetodoCongruencialMixto
            // 
            botonMetodoCongruencialMixto.BackColor = Color.Gold;
            botonMetodoCongruencialMixto.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            botonMetodoCongruencialMixto.Location = new Point(580, 217);
            botonMetodoCongruencialMixto.Name = "botonMetodoCongruencialMixto";
            botonMetodoCongruencialMixto.Size = new Size(121, 48);
            botonMetodoCongruencialMixto.TabIndex = 4;
            botonMetodoCongruencialMixto.Text = "Congruencial Mixto";
            botonMetodoCongruencialMixto.UseVisualStyleBackColor = false;
            botonMetodoCongruencialMixto.Click += botonMetodoCongruencialMixto_Click;
            // 
            // botonMetodoCongruencialAditivo
            // 
            botonMetodoCongruencialAditivo.BackColor = Color.Gold;
            botonMetodoCongruencialAditivo.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            botonMetodoCongruencialAditivo.Location = new Point(220, 319);
            botonMetodoCongruencialAditivo.Name = "botonMetodoCongruencialAditivo";
            botonMetodoCongruencialAditivo.Size = new Size(121, 48);
            botonMetodoCongruencialAditivo.TabIndex = 5;
            botonMetodoCongruencialAditivo.Text = "Congruencial Aditivo";
            botonMetodoCongruencialAditivo.UseVisualStyleBackColor = false;
            botonMetodoCongruencialAditivo.Click += botonMetodoCongruencialAditivo_Click;
            // 
            // botonMetodoCongruencialMultiplicativo
            // 
            botonMetodoCongruencialMultiplicativo.BackColor = Color.Gold;
            botonMetodoCongruencialMultiplicativo.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            botonMetodoCongruencialMultiplicativo.Location = new Point(461, 319);
            botonMetodoCongruencialMultiplicativo.Name = "botonMetodoCongruencialMultiplicativo";
            botonMetodoCongruencialMultiplicativo.Size = new Size(121, 48);
            botonMetodoCongruencialMultiplicativo.TabIndex = 6;
            botonMetodoCongruencialMultiplicativo.Text = "Congruencial Multiplicativo";
            botonMetodoCongruencialMultiplicativo.UseVisualStyleBackColor = false;
            botonMetodoCongruencialMultiplicativo.Click += botonMetodoCongruencialMultiplicativo_Click;
            // 
            // SeleccionarMetodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(800, 450);
            Controls.Add(botonMetodoCongruencialMultiplicativo);
            Controls.Add(botonMetodoCongruencialAditivo);
            Controls.Add(botonMetodoCongruencialMixto);
            Controls.Add(botonMetodoLehmer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonMetodoCuadrado);
            Name = "SeleccionarMetodo";
            Text = "interfazInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonMetodoCuadrado;
        private Label label1;
        private Label label2;
        private Button botonMetodoLehmer;
        private Button botonMetodoCongruencialMixto;
        private Button botonMetodoCongruencialAditivo;
        private Button botonMetodoCongruencialMultiplicativo;
    }
}