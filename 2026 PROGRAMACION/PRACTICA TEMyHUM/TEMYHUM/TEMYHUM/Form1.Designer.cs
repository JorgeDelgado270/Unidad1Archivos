namespace HyT
{
    partial class Form1
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.temperaturaLabel = new System.Windows.Forms.Label();
            this.humedadLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.botonConectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(656, 75);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(480, 324);
            this.listBox2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TEMYHUM.Properties.Resources.downloadTEMP;
            this.pictureBox3.Location = new System.Drawing.Point(214, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(215, 227);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // temperaturaLabel
            // 
            this.temperaturaLabel.AutoSize = true;
            this.temperaturaLabel.Location = new System.Drawing.Point(299, 313);
            this.temperaturaLabel.Name = "temperaturaLabel";
            this.temperaturaLabel.Size = new System.Drawing.Size(100, 20);
            this.temperaturaLabel.TabIndex = 2;
            this.temperaturaLabel.Text = "Temperatura";
            // 
            // humedadLabel
            // 
            this.humedadLabel.AutoSize = true;
            this.humedadLabel.Location = new System.Drawing.Point(279, 568);
            this.humedadLabel.Name = "humedadLabel";
            this.humedadLabel.Size = new System.Drawing.Size(79, 20);
            this.humedadLabel.TabIndex = 3;
            this.humedadLabel.Text = "Humedad";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TEMYHUM.Properties.Resources.download__1_wet;
            this.pictureBox4.Location = new System.Drawing.Point(214, 352);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(218, 174);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1061, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // botonConectar
            // 
            this.botonConectar.Location = new System.Drawing.Point(604, 440);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(157, 54);
            this.botonConectar.TabIndex = 6;
            this.botonConectar.Text = "Conectar";
            this.botonConectar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1395, 655);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.humedadLabel);
            this.Controls.Add(this.temperaturaLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.listBox2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label temperaturaLabel;
        private System.Windows.Forms.Label humedadLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button botonConectar;
    }
}

