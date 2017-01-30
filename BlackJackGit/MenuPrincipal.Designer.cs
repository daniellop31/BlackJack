namespace BlackJackGit
{
    partial class MenuPrincipal
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
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnDosJugadores = new System.Windows.Forms.Button();
            this.btnUnJugador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(12, 70);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(93, 23);
            this.btnInforme.TabIndex = 5;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            // 
            // btnDosJugadores
            // 
            this.btnDosJugadores.Location = new System.Drawing.Point(12, 41);
            this.btnDosJugadores.Name = "btnDosJugadores";
            this.btnDosJugadores.Size = new System.Drawing.Size(93, 23);
            this.btnDosJugadores.TabIndex = 4;
            this.btnDosJugadores.Text = "Dos jugadores";
            this.btnDosJugadores.UseVisualStyleBackColor = true;
            this.btnDosJugadores.Click += new System.EventHandler(this.btnDosJugadores_Click);
            // 
            // btnUnJugador
            // 
            this.btnUnJugador.Location = new System.Drawing.Point(12, 12);
            this.btnUnJugador.Name = "btnUnJugador";
            this.btnUnJugador.Size = new System.Drawing.Size(93, 23);
            this.btnUnJugador.TabIndex = 3;
            this.btnUnJugador.Text = "Un jugador";
            this.btnUnJugador.UseVisualStyleBackColor = true;
            this.btnUnJugador.Click += new System.EventHandler(this.btnUnJugador_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 333);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnDosJugadores);
            this.Controls.Add(this.btnUnJugador);
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnDosJugadores;
        private System.Windows.Forms.Button btnUnJugador;
    }
}