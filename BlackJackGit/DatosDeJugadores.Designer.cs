namespace BlackJackGit
{
    partial class DatosDeJugadores
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApuestaJ2 = new System.Windows.Forms.TextBox();
            this.txtApuestaJ1 = new System.Windows.Forms.TextBox();
            this.btnHecho = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreJ2 = new System.Windows.Forms.TextBox();
            this.txtNombreJ1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Apuesta de jugador 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apuesta de jugador 1 :";
            // 
            // txtApuestaJ2
            // 
            this.txtApuestaJ2.Location = new System.Drawing.Point(135, 84);
            this.txtApuestaJ2.Name = "txtApuestaJ2";
            this.txtApuestaJ2.Size = new System.Drawing.Size(96, 20);
            this.txtApuestaJ2.TabIndex = 17;
            this.txtApuestaJ2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApuestaJ2_KeyPress);
            // 
            // txtApuestaJ1
            // 
            this.txtApuestaJ1.Location = new System.Drawing.Point(135, 32);
            this.txtApuestaJ1.Name = "txtApuestaJ1";
            this.txtApuestaJ1.Size = new System.Drawing.Size(96, 20);
            this.txtApuestaJ1.TabIndex = 16;
            this.txtApuestaJ1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApuestaJ1_KeyPress);
            // 
            // btnHecho
            // 
            this.btnHecho.Location = new System.Drawing.Point(12, 110);
            this.btnHecho.Name = "btnHecho";
            this.btnHecho.Size = new System.Drawing.Size(257, 23);
            this.btnHecho.TabIndex = 15;
            this.btnHecho.Text = "Hecho";
            this.btnHecho.UseVisualStyleBackColor = true;
            this.btnHecho.Click += new System.EventHandler(this.btnHecho_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre del jugador 2 : ";
            // 
            // txtNombreJ2
            // 
            this.txtNombreJ2.Location = new System.Drawing.Point(135, 58);
            this.txtNombreJ2.Name = "txtNombreJ2";
            this.txtNombreJ2.Size = new System.Drawing.Size(134, 20);
            this.txtNombreJ2.TabIndex = 13;
            this.txtNombreJ2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreJ2_KeyPress);
            // 
            // txtNombreJ1
            // 
            this.txtNombreJ1.Location = new System.Drawing.Point(135, 6);
            this.txtNombreJ1.Name = "txtNombreJ1";
            this.txtNombreJ1.Size = new System.Drawing.Size(134, 20);
            this.txtNombreJ1.TabIndex = 12;
            this.txtNombreJ1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreJ1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre del jugador 1 : ";
            // 
            // DatosDeJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 155);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApuestaJ2);
            this.Controls.Add(this.txtApuestaJ1);
            this.Controls.Add(this.btnHecho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreJ2);
            this.Controls.Add(this.txtNombreJ1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(313, 194);
            this.MinimumSize = new System.Drawing.Size(313, 194);
            this.Name = "DatosDeJugadores";
            this.Text = "Datos de los jugadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtApuestaJ2;
        private System.Windows.Forms.TextBox txtApuestaJ1;
        private System.Windows.Forms.Button btnHecho;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNombreJ2;
        public System.Windows.Forms.TextBox txtNombreJ1;
        private System.Windows.Forms.Label label1;
    }
}