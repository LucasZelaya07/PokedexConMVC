namespace Pokedex
{
    partial class FrmAltaPokemon
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
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxBxNumero = new System.Windows.Forms.TextBox();
            this.TxBxNombre = new System.Windows.Forms.TextBox();
            this.TxBxDescripcion = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblAltaPokemon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNumero
            // 
            this.LblNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(79, 55);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(65, 20);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Numero";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(79, 106);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(79, 165);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // TxBxNumero
            // 
            this.TxBxNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxNumero.Location = new System.Drawing.Point(207, 55);
            this.TxBxNumero.Name = "TxBxNumero";
            this.TxBxNumero.Size = new System.Drawing.Size(185, 26);
            this.TxBxNumero.TabIndex = 3;
            // 
            // TxBxNombre
            // 
            this.TxBxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxNombre.Location = new System.Drawing.Point(207, 106);
            this.TxBxNombre.Name = "TxBxNombre";
            this.TxBxNombre.Size = new System.Drawing.Size(185, 26);
            this.TxBxNombre.TabIndex = 4;
            // 
            // TxBxDescripcion
            // 
            this.TxBxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxDescripcion.Location = new System.Drawing.Point(207, 165);
            this.TxBxDescripcion.Name = "TxBxDescripcion";
            this.TxBxDescripcion.Size = new System.Drawing.Size(185, 26);
            this.TxBxDescripcion.TabIndex = 5;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAceptar.Location = new System.Drawing.Point(83, 239);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(88, 35);
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelar.Location = new System.Drawing.Point(307, 240);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(85, 34);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblAltaPokemon
            // 
            this.LblAltaPokemon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAltaPokemon.AutoSize = true;
            this.LblAltaPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltaPokemon.Location = new System.Drawing.Point(133, 9);
            this.LblAltaPokemon.Name = "LblAltaPokemon";
            this.LblAltaPokemon.Size = new System.Drawing.Size(190, 25);
            this.LblAltaPokemon.TabIndex = 8;
            this.LblAltaPokemon.Text = "ALTA POKEMON";
            this.LblAltaPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 363);
            this.Controls.Add(this.LblAltaPokemon);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxBxDescripcion);
            this.Controls.Add(this.TxBxNombre);
            this.Controls.Add(this.TxBxNumero);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblNumero);
            this.Name = "FrmAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Pokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxBxNumero;
        private System.Windows.Forms.TextBox TxBxNombre;
        private System.Windows.Forms.TextBox TxBxDescripcion;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblAltaPokemon;
    }
}