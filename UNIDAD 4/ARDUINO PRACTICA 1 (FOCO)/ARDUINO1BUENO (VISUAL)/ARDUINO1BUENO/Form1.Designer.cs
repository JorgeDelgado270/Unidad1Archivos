namespace ARDUINO1BUENO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OFF = new System.Windows.Forms.Button();
            this.ON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OFF
            // 
            this.OFF.Image = ((System.Drawing.Image)(resources.GetObject("OFF.Image")));
            this.OFF.Location = new System.Drawing.Point(36, 64);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(573, 562);
            this.OFF.TabIndex = 0;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // ON
            // 
            this.ON.Image = ((System.Drawing.Image)(resources.GetObject("ON.Image")));
            this.ON.Location = new System.Drawing.Point(615, 64);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(547, 562);
            this.ON.TabIndex = 1;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 667);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.OFF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Button ON;
    }
}

