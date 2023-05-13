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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(102, 217);
            button1.Name = "button1";
            button1.Size = new Size(121, 48);
            button1.TabIndex = 0;
            button1.Text = "Cuadrado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(339, 217);
            button2.Name = "button2";
            button2.Size = new Size(121, 48);
            button2.TabIndex = 3;
            button2.Text = "Lehemer";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(580, 217);
            button3.Name = "button3";
            button3.Size = new Size(121, 48);
            button3.TabIndex = 4;
            button3.Text = "Congruencial Mixto";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(220, 319);
            button4.Name = "button4";
            button4.Size = new Size(121, 48);
            button4.TabIndex = 5;
            button4.Text = "Congruencial Aditivo";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(461, 319);
            button5.Name = "button5";
            button5.Size = new Size(121, 48);
            button5.TabIndex = 6;
            button5.Text = "Congruencial Multiplicativo";
            button5.UseVisualStyleBackColor = false;
            // 
            // SeleccionarMetodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "SeleccionarMetodo";
            Text = "interfazInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}