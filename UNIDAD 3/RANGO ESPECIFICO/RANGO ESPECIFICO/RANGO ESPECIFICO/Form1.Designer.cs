﻿namespace RANGO_ESPECIFICO
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            label4 = new Label();
            textBox3 = new TextBox();
            BotonImprime = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 56);
            label1.Name = "label1";
            label1.Size = new Size(476, 25);
            label1.TabIndex = 0;
            label1.Text = "Imprime numeros de un rango especifico y calcula la suma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 132);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Rango Inferior";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 126);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 2;
            label3.Text = "Rango Superior";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(561, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(419, 163);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 229);
            listBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 400);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 6;
            label4.Text = "Suma";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(432, 407);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // BotonImprime
            // 
            BotonImprime.Location = new Point(202, 261);
            BotonImprime.Name = "BotonImprime";
            BotonImprime.Size = new Size(112, 34);
            BotonImprime.TabIndex = 8;
            BotonImprime.Text = "Imprime";
            BotonImprime.UseVisualStyleBackColor = true;
            BotonImprime.Click += BotonImprime_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonImprime);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Label label4;
        private TextBox textBox3;
        private Button BotonImprime;
    }
}
