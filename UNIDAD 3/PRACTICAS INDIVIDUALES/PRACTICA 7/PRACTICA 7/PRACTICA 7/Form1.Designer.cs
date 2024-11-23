namespace PRACTICA_7
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
            label2 = new Label();
            valor = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            Resultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 31);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 0;
            label1.Text = "DATOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 80);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Valor:";
            // 
            // valor
            // 
            valor.Location = new Point(259, 80);
            valor.Name = "valor";
            valor.Size = new Size(150, 31);
            valor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 130);
            label3.Name = "label3";
            label3.Size = new Size(225, 25);
            label3.TabIndex = 3;
            label3.Text = "Opciones de Conversion";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(108, 173);
            button1.Name = "button1";
            button1.Size = new Size(145, 81);
            button1.TabIndex = 4;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(259, 173);
            button2.Name = "button2";
            button2.Size = new Size(142, 80);
            button2.TabIndex = 5;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(198, 285);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 337);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 7;
            label4.Text = "Resultado en Grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 375);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 8;
            label5.Text = "Equivalente en grados:";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(130, 418);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(225, 31);
            Resultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 504);
            Controls.Add(Resultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox valor;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox Resultado;
    }
}
