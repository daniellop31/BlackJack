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
            this.btnUnJugador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnJugador
            // 
            this.btnUnJugador.Location = new System.Drawing.Point(12, 12);
            this.btnUnJugador.Name = "btnUnJugador";
            this.btnUnJugador.Size = new System.Drawing.Size(75, 23);
            this.btnUnJugador.TabIndex = 0;
            this.btnUnJugador.Text = "Un jugador";
            this.btnUnJugador.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUnJugador);
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnJugador;
    }
}

