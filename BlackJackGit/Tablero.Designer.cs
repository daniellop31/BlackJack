namespace BlackJackGit
{
    partial class Tablero
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbOpcionesJ2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApuestaJ2 = new System.Windows.Forms.TextBox();
            this.btnPedirCartaJ2 = new System.Windows.Forms.Button();
            this.btnPasarJ2 = new System.Windows.Forms.Button();
            this.gbOpcionesJ1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApuestaJ1 = new System.Windows.Forms.TextBox();
            this.btnPedirCartaJ1 = new System.Windows.Forms.Button();
            this.btnPasarJ1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbOpcionesJ2.SuspendLayout();
            this.gbOpcionesJ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 163);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::BlackJackGit.Properties.Resources.carta_1;
            this.pictureBox1.Location = new System.Drawing.Point(29, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJackGit.Properties.Resources.carta_1;
            this.pictureBox2.Location = new System.Drawing.Point(59, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 175);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // gbOpcionesJ2
            // 
            this.gbOpcionesJ2.Controls.Add(this.label1);
            this.gbOpcionesJ2.Controls.Add(this.txtApuestaJ2);
            this.gbOpcionesJ2.Controls.Add(this.btnPedirCartaJ2);
            this.gbOpcionesJ2.Controls.Add(this.btnPasarJ2);
            this.gbOpcionesJ2.Location = new System.Drawing.Point(574, 392);
            this.gbOpcionesJ2.Name = "gbOpcionesJ2";
            this.gbOpcionesJ2.Size = new System.Drawing.Size(200, 112);
            this.gbOpcionesJ2.TabIndex = 9;
            this.gbOpcionesJ2.TabStop = false;
            this.gbOpcionesJ2.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "$";
            // 
            // txtApuestaJ2
            // 
            this.txtApuestaJ2.Enabled = false;
            this.txtApuestaJ2.Location = new System.Drawing.Point(6, 77);
            this.txtApuestaJ2.Name = "txtApuestaJ2";
            this.txtApuestaJ2.Size = new System.Drawing.Size(100, 20);
            this.txtApuestaJ2.TabIndex = 2;
            // 
            // btnPedirCartaJ2
            // 
            this.btnPedirCartaJ2.Location = new System.Drawing.Point(6, 48);
            this.btnPedirCartaJ2.Name = "btnPedirCartaJ2";
            this.btnPedirCartaJ2.Size = new System.Drawing.Size(97, 23);
            this.btnPedirCartaJ2.TabIndex = 1;
            this.btnPedirCartaJ2.Text = "Pedir una carta";
            this.btnPedirCartaJ2.UseVisualStyleBackColor = true;
            // 
            // btnPasarJ2
            // 
            this.btnPasarJ2.Location = new System.Drawing.Point(6, 19);
            this.btnPasarJ2.Name = "btnPasarJ2";
            this.btnPasarJ2.Size = new System.Drawing.Size(97, 23);
            this.btnPasarJ2.TabIndex = 0;
            this.btnPasarJ2.Text = "Pasar";
            this.btnPasarJ2.UseVisualStyleBackColor = true;
            // 
            // gbOpcionesJ1
            // 
            this.gbOpcionesJ1.Controls.Add(this.label6);
            this.gbOpcionesJ1.Controls.Add(this.txtApuestaJ1);
            this.gbOpcionesJ1.Controls.Add(this.btnPedirCartaJ1);
            this.gbOpcionesJ1.Controls.Add(this.btnPasarJ1);
            this.gbOpcionesJ1.Location = new System.Drawing.Point(12, 392);
            this.gbOpcionesJ1.Name = "gbOpcionesJ1";
            this.gbOpcionesJ1.Size = new System.Drawing.Size(200, 112);
            this.gbOpcionesJ1.TabIndex = 8;
            this.gbOpcionesJ1.TabStop = false;
            this.gbOpcionesJ1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "$";
            // 
            // txtApuestaJ1
            // 
            this.txtApuestaJ1.Enabled = false;
            this.txtApuestaJ1.Location = new System.Drawing.Point(6, 77);
            this.txtApuestaJ1.Name = "txtApuestaJ1";
            this.txtApuestaJ1.Size = new System.Drawing.Size(100, 20);
            this.txtApuestaJ1.TabIndex = 2;
            // 
            // btnPedirCartaJ1
            // 
            this.btnPedirCartaJ1.Location = new System.Drawing.Point(6, 48);
            this.btnPedirCartaJ1.Name = "btnPedirCartaJ1";
            this.btnPedirCartaJ1.Size = new System.Drawing.Size(97, 23);
            this.btnPedirCartaJ1.TabIndex = 1;
            this.btnPedirCartaJ1.Text = "Pedir una carta";
            this.btnPedirCartaJ1.UseVisualStyleBackColor = true;
            // 
            // btnPasarJ1
            // 
            this.btnPasarJ1.Location = new System.Drawing.Point(6, 19);
            this.btnPasarJ1.Name = "btnPasarJ1";
            this.btnPasarJ1.Size = new System.Drawing.Size(97, 23);
            this.btnPasarJ1.TabIndex = 0;
            this.btnPasarJ1.Text = "Pasar";
            this.btnPasarJ1.UseVisualStyleBackColor = true;
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 516);
            this.Controls.Add(this.gbOpcionesJ2);
            this.Controls.Add(this.gbOpcionesJ1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tablero";
            this.Text = "Tablero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbOpcionesJ2.ResumeLayout(false);
            this.gbOpcionesJ2.PerformLayout();
            this.gbOpcionesJ1.ResumeLayout(false);
            this.gbOpcionesJ1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.GroupBox gbOpcionesJ2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtApuestaJ2;
        private System.Windows.Forms.Button btnPedirCartaJ2;
        private System.Windows.Forms.Button btnPasarJ2;
        public System.Windows.Forms.GroupBox gbOpcionesJ1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtApuestaJ1;
        private System.Windows.Forms.Button btnPedirCartaJ1;
        private System.Windows.Forms.Button btnPasarJ1;
    }
}