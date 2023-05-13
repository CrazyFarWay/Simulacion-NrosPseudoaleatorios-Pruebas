namespace NroPseudoaleatorios_Pruebas_SImulacion
{
    partial class SeleccionarPrueba
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 34);
            label1.Name = "label1";
            label1.Size = new Size(228, 62);
            label1.TabIndex = 0;
            label1.Text = "Pruebas";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(86, 173);
            button1.Name = "button1";
            button1.Size = new Size(134, 60);
            button1.TabIndex = 1;
            button1.Text = "P. Promedios";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(333, 173);
            button2.Name = "button2";
            button2.Size = new Size(134, 60);
            button2.TabIndex = 2;
            button2.Text = "P. Frecuencia";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Location = new Point(575, 173);
            button3.Name = "button3";
            button3.Size = new Size(134, 60);
            button3.TabIndex = 3;
            button3.Text = "P. Serie";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Location = new Point(212, 280);
            button4.Name = "button4";
            button4.Size = new Size(134, 60);
            button4.TabIndex = 4;
            button4.Text = "P. Kolmogorov -Smirnov (k - s)";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.Location = new Point(458, 280);
            button5.Name = "button5";
            button5.Size = new Size(134, 60);
            button5.TabIndex = 5;
            button5.Text = "P. Corrida Arriba y Abajo de la Media";
            button5.UseVisualStyleBackColor = false;
            // 
            // SeleccionarPrueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "SeleccionarPrueba";
            Text = "SeleccionarPrueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}