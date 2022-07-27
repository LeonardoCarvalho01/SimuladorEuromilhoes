namespace ExEuromilhoes
{
    partial class frmMilhoes
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtEstrelas = new System.Windows.Forms.TextBox();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblEstrelas = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeros
            // 
            this.txtNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeros.Location = new System.Drawing.Point(81, 165);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(151, 55);
            this.txtNumeros.TabIndex = 7;
            // 
            // txtEstrelas
            // 
            this.txtEstrelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstrelas.Location = new System.Drawing.Point(404, 165);
            this.txtEstrelas.Multiline = true;
            this.txtEstrelas.Name = "txtEstrelas";
            this.txtEstrelas.Size = new System.Drawing.Size(96, 55);
            this.txtEstrelas.TabIndex = 13;
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.Location = new System.Drawing.Point(98, 97);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(124, 31);
            this.lblNumeros.TabIndex = 14;
            this.lblNumeros.Text = "Números";
            // 
            // lblEstrelas
            // 
            this.lblEstrelas.AutoSize = true;
            this.lblEstrelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrelas.Location = new System.Drawing.Point(398, 97);
            this.lblEstrelas.Name = "lblEstrelas";
            this.lblEstrelas.Size = new System.Drawing.Size(113, 31);
            this.lblEstrelas.TabIndex = 15;
            this.lblEstrelas.Text = "Estrelas";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(509, 328);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(79, 28);
            this.btnJogar.TabIndex = 16;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(376, 328);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 28);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmMilhoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 422);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblEstrelas);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.txtEstrelas);
            this.Controls.Add(this.txtNumeros);
            this.Name = "frmMilhoes";
            this.Text = "EuroMilhões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.TextBox txtEstrelas;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblEstrelas;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

