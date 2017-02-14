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
            this.gbOpcionesJ2 = new System.Windows.Forms.GroupBox();
            this.lbDineroJ2 = new System.Windows.Forms.Label();
            this.btnApostarJ2 = new System.Windows.Forms.Button();
            this.lbPuntageJ2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApuestaJ2 = new System.Windows.Forms.TextBox();
            this.btnPedirCartaJ2 = new System.Windows.Forms.Button();
            this.btnPasarJ2 = new System.Windows.Forms.Button();
            this.gbOpcionesJ1 = new System.Windows.Forms.GroupBox();
            this.btnApostarJ1 = new System.Windows.Forms.Button();
            this.lbDineroJ1 = new System.Windows.Forms.Label();
            this.lbPuntageJ1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApuestaJ1 = new System.Windows.Forms.TextBox();
            this.btnPedirCartaJ1 = new System.Windows.Forms.Button();
            this.btnPasarJ1 = new System.Windows.Forms.Button();
            this.imgCarta1J2 = new System.Windows.Forms.PictureBox();
            this.imgCarta2J2 = new System.Windows.Forms.PictureBox();
            this.imgCarta2J1 = new System.Windows.Forms.PictureBox();
            this.imgCarta1J1 = new System.Windows.Forms.PictureBox();
            this.lbGanadasJ1 = new System.Windows.Forms.Label();
            this.lbGanadasJ2 = new System.Windows.Forms.Label();
            this.gbOpcionesJ2.SuspendLayout();
            this.gbOpcionesJ1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta1J2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta2J2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta2J1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta1J1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpcionesJ2
            // 
            this.gbOpcionesJ2.Controls.Add(this.lbDineroJ2);
            this.gbOpcionesJ2.Controls.Add(this.btnApostarJ2);
            this.gbOpcionesJ2.Controls.Add(this.lbPuntageJ2);
            this.gbOpcionesJ2.Controls.Add(this.label1);
            this.gbOpcionesJ2.Controls.Add(this.txtApuestaJ2);
            this.gbOpcionesJ2.Controls.Add(this.btnPedirCartaJ2);
            this.gbOpcionesJ2.Controls.Add(this.btnPasarJ2);
            this.gbOpcionesJ2.Location = new System.Drawing.Point(552, 392);
            this.gbOpcionesJ2.Name = "gbOpcionesJ2";
            this.gbOpcionesJ2.Size = new System.Drawing.Size(222, 112);
            this.gbOpcionesJ2.TabIndex = 9;
            this.gbOpcionesJ2.TabStop = false;
            // 
            // lbDineroJ2
            // 
            this.lbDineroJ2.AutoSize = true;
            this.lbDineroJ2.Location = new System.Drawing.Point(131, 53);
            this.lbDineroJ2.Name = "lbDineroJ2";
            this.lbDineroJ2.Size = new System.Drawing.Size(41, 13);
            this.lbDineroJ2.TabIndex = 16;
            this.lbDineroJ2.Text = "Dinero:";
            // 
            // btnApostarJ2
            // 
            this.btnApostarJ2.Enabled = false;
            this.btnApostarJ2.Location = new System.Drawing.Point(109, 19);
            this.btnApostarJ2.Name = "btnApostarJ2";
            this.btnApostarJ2.Size = new System.Drawing.Size(75, 23);
            this.btnApostarJ2.TabIndex = 14;
            this.btnApostarJ2.Text = "Apostar";
            this.btnApostarJ2.UseVisualStyleBackColor = true;
            this.btnApostarJ2.Click += new System.EventHandler(this.btnApostarJ2_Click);
            // 
            // lbPuntageJ2
            // 
            this.lbPuntageJ2.AutoSize = true;
            this.lbPuntageJ2.Location = new System.Drawing.Point(131, 80);
            this.lbPuntageJ2.Name = "lbPuntageJ2";
            this.lbPuntageJ2.Size = new System.Drawing.Size(46, 13);
            this.lbPuntageJ2.TabIndex = 13;
            this.lbPuntageJ2.Text = "Puntaje:";
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
            this.txtApuestaJ2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApuestaJ2_KeyPress);
            // 
            // btnPedirCartaJ2
            // 
            this.btnPedirCartaJ2.Enabled = false;
            this.btnPedirCartaJ2.Location = new System.Drawing.Point(6, 48);
            this.btnPedirCartaJ2.Name = "btnPedirCartaJ2";
            this.btnPedirCartaJ2.Size = new System.Drawing.Size(97, 23);
            this.btnPedirCartaJ2.TabIndex = 1;
            this.btnPedirCartaJ2.Text = "Pedir una carta";
            this.btnPedirCartaJ2.UseVisualStyleBackColor = true;
            this.btnPedirCartaJ2.Click += new System.EventHandler(this.btnPedirCartaJ2_Click);
            // 
            // btnPasarJ2
            // 
            this.btnPasarJ2.Enabled = false;
            this.btnPasarJ2.Location = new System.Drawing.Point(6, 19);
            this.btnPasarJ2.Name = "btnPasarJ2";
            this.btnPasarJ2.Size = new System.Drawing.Size(97, 23);
            this.btnPasarJ2.TabIndex = 0;
            this.btnPasarJ2.Text = "Pasar";
            this.btnPasarJ2.UseVisualStyleBackColor = true;
            this.btnPasarJ2.Click += new System.EventHandler(this.btnPasarJ2_Click);
            // 
            // gbOpcionesJ1
            // 
            this.gbOpcionesJ1.Controls.Add(this.btnApostarJ1);
            this.gbOpcionesJ1.Controls.Add(this.lbDineroJ1);
            this.gbOpcionesJ1.Controls.Add(this.lbPuntageJ1);
            this.gbOpcionesJ1.Controls.Add(this.label6);
            this.gbOpcionesJ1.Controls.Add(this.txtApuestaJ1);
            this.gbOpcionesJ1.Controls.Add(this.btnPedirCartaJ1);
            this.gbOpcionesJ1.Controls.Add(this.btnPasarJ1);
            this.gbOpcionesJ1.Location = new System.Drawing.Point(12, 392);
            this.gbOpcionesJ1.Name = "gbOpcionesJ1";
            this.gbOpcionesJ1.Size = new System.Drawing.Size(228, 112);
            this.gbOpcionesJ1.TabIndex = 8;
            this.gbOpcionesJ1.TabStop = false;
            // 
            // btnApostarJ1
            // 
            this.btnApostarJ1.Enabled = false;
            this.btnApostarJ1.Location = new System.Drawing.Point(115, 19);
            this.btnApostarJ1.Name = "btnApostarJ1";
            this.btnApostarJ1.Size = new System.Drawing.Size(75, 23);
            this.btnApostarJ1.TabIndex = 13;
            this.btnApostarJ1.Text = "Apostar";
            this.btnApostarJ1.UseVisualStyleBackColor = true;
            this.btnApostarJ1.Click += new System.EventHandler(this.btnApostarJ1_Click);
            // 
            // lbDineroJ1
            // 
            this.lbDineroJ1.AutoSize = true;
            this.lbDineroJ1.Location = new System.Drawing.Point(131, 58);
            this.lbDineroJ1.Name = "lbDineroJ1";
            this.lbDineroJ1.Size = new System.Drawing.Size(41, 13);
            this.lbDineroJ1.TabIndex = 15;
            this.lbDineroJ1.Text = "Dinero:";
            // 
            // lbPuntageJ1
            // 
            this.lbPuntageJ1.AutoSize = true;
            this.lbPuntageJ1.Location = new System.Drawing.Point(131, 80);
            this.lbPuntageJ1.Name = "lbPuntageJ1";
            this.lbPuntageJ1.Size = new System.Drawing.Size(46, 13);
            this.lbPuntageJ1.TabIndex = 12;
            this.lbPuntageJ1.Text = "Puntaje:";
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
            this.txtApuestaJ1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApuestaJ1_KeyPress);
            // 
            // btnPedirCartaJ1
            // 
            this.btnPedirCartaJ1.Location = new System.Drawing.Point(6, 48);
            this.btnPedirCartaJ1.Name = "btnPedirCartaJ1";
            this.btnPedirCartaJ1.Size = new System.Drawing.Size(97, 23);
            this.btnPedirCartaJ1.TabIndex = 1;
            this.btnPedirCartaJ1.Text = "Pedir una carta";
            this.btnPedirCartaJ1.UseVisualStyleBackColor = true;
            this.btnPedirCartaJ1.Click += new System.EventHandler(this.btnPedirCartaJ1_Click);
            // 
            // btnPasarJ1
            // 
            this.btnPasarJ1.Location = new System.Drawing.Point(6, 19);
            this.btnPasarJ1.Name = "btnPasarJ1";
            this.btnPasarJ1.Size = new System.Drawing.Size(97, 23);
            this.btnPasarJ1.TabIndex = 0;
            this.btnPasarJ1.Text = "Pasar";
            this.btnPasarJ1.UseVisualStyleBackColor = true;
            this.btnPasarJ1.Click += new System.EventHandler(this.btnPasarJ1_Click);
            // 
            // imgCarta1J2
            // 
            this.imgCarta1J2.Location = new System.Drawing.Point(552, 231);
            this.imgCarta1J2.Name = "imgCarta1J2";
            this.imgCarta1J2.Size = new System.Drawing.Size(108, 155);
            this.imgCarta1J2.TabIndex = 14;
            this.imgCarta1J2.TabStop = false;
            // 
            // imgCarta2J2
            // 
            this.imgCarta2J2.Location = new System.Drawing.Point(666, 231);
            this.imgCarta2J2.Name = "imgCarta2J2";
            this.imgCarta2J2.Size = new System.Drawing.Size(108, 155);
            this.imgCarta2J2.TabIndex = 13;
            this.imgCarta2J2.TabStop = false;
            // 
            // imgCarta2J1
            // 
            this.imgCarta2J1.Location = new System.Drawing.Point(132, 231);
            this.imgCarta2J1.Name = "imgCarta2J1";
            this.imgCarta2J1.Size = new System.Drawing.Size(108, 155);
            this.imgCarta2J1.TabIndex = 12;
            this.imgCarta2J1.TabStop = false;
            // 
            // imgCarta1J1
            // 
            this.imgCarta1J1.Location = new System.Drawing.Point(18, 231);
            this.imgCarta1J1.Name = "imgCarta1J1";
            this.imgCarta1J1.Size = new System.Drawing.Size(108, 155);
            this.imgCarta1J1.TabIndex = 11;
            this.imgCarta1J1.TabStop = false;
            // 
            // lbGanadasJ1
            // 
            this.lbGanadasJ1.AutoSize = true;
            this.lbGanadasJ1.Location = new System.Drawing.Point(15, 215);
            this.lbGanadasJ1.Name = "lbGanadasJ1";
            this.lbGanadasJ1.Size = new System.Drawing.Size(53, 13);
            this.lbGanadasJ1.TabIndex = 15;
            this.lbGanadasJ1.Text = "Ganadas:";
            // 
            // lbGanadasJ2
            // 
            this.lbGanadasJ2.AutoSize = true;
            this.lbGanadasJ2.Location = new System.Drawing.Point(555, 215);
            this.lbGanadasJ2.Name = "lbGanadasJ2";
            this.lbGanadasJ2.Size = new System.Drawing.Size(53, 13);
            this.lbGanadasJ2.TabIndex = 16;
            this.lbGanadasJ2.Text = "Ganadas:";
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 516);
            this.Controls.Add(this.lbGanadasJ2);
            this.Controls.Add(this.lbGanadasJ1);
            this.Controls.Add(this.imgCarta1J2);
            this.Controls.Add(this.imgCarta2J2);
            this.Controls.Add(this.imgCarta2J1);
            this.Controls.Add(this.imgCarta1J1);
            this.Controls.Add(this.gbOpcionesJ2);
            this.Controls.Add(this.gbOpcionesJ1);
            this.MaximumSize = new System.Drawing.Size(802, 555);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(802, 555);
            this.Name = "Tablero";
            this.Text = "Tablero";
            this.gbOpcionesJ2.ResumeLayout(false);
            this.gbOpcionesJ2.PerformLayout();
            this.gbOpcionesJ1.ResumeLayout(false);
            this.gbOpcionesJ1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta1J2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta2J2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta2J1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta1J1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox gbOpcionesJ2;
        public System.Windows.Forms.TextBox txtApuestaJ2;
        private System.Windows.Forms.Button btnPedirCartaJ2;
        private System.Windows.Forms.Button btnPasarJ2;
        public System.Windows.Forms.GroupBox gbOpcionesJ1;
        public System.Windows.Forms.TextBox txtApuestaJ1;
        private System.Windows.Forms.Button btnPedirCartaJ1;
        private System.Windows.Forms.Button btnPasarJ1;
        public System.Windows.Forms.PictureBox imgCarta1J1;
        public System.Windows.Forms.PictureBox imgCarta2J1;
        public System.Windows.Forms.PictureBox imgCarta2J2;
        public System.Windows.Forms.PictureBox imgCarta1J2;
        public System.Windows.Forms.Label lbPuntageJ2;
        public System.Windows.Forms.Label lbPuntageJ1;
        private System.Windows.Forms.Button btnApostarJ2;
        private System.Windows.Forms.Button btnApostarJ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbDineroJ2;
        public System.Windows.Forms.Label lbDineroJ1;
        private System.Windows.Forms.Label lbGanadasJ1;
        private System.Windows.Forms.Label lbGanadasJ2;
    }
}