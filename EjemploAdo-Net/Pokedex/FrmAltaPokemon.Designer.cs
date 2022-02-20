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
            this.CmbBxTipo = new System.Windows.Forms.ComboBox();
            this.CmbBxDebilidad = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblDebilidad = new System.Windows.Forms.Label();
            this.TxtBxUrlImagen = new System.Windows.Forms.TextBox();
            this.LblUrlImagen = new System.Windows.Forms.Label();
            this.PctBxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNumero
            // 
            this.LblNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(52, 44);
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
            this.LblNombre.Location = new System.Drawing.Point(52, 94);
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
            this.LblDescripcion.Location = new System.Drawing.Point(52, 134);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // TxBxNumero
            // 
            this.TxBxNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBxNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxNumero.Location = new System.Drawing.Point(172, 38);
            this.TxBxNumero.Name = "TxBxNumero";
            this.TxBxNumero.Size = new System.Drawing.Size(185, 26);
            this.TxBxNumero.TabIndex = 0;
            // 
            // TxBxNombre
            // 
            this.TxBxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxNombre.Location = new System.Drawing.Point(172, 88);
            this.TxBxNombre.Name = "TxBxNombre";
            this.TxBxNombre.Size = new System.Drawing.Size(185, 26);
            this.TxBxNombre.TabIndex = 1;
            // 
            // TxBxDescripcion
            // 
            this.TxBxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxBxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxDescripcion.Location = new System.Drawing.Point(172, 128);
            this.TxBxDescripcion.MaxLength = 50;
            this.TxBxDescripcion.Name = "TxBxDescripcion";
            this.TxBxDescripcion.Size = new System.Drawing.Size(185, 26);
            this.TxBxDescripcion.TabIndex = 2;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAceptar.Location = new System.Drawing.Point(56, 306);
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
            this.BtnCancelar.Location = new System.Drawing.Point(272, 317);
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
            this.LblAltaPokemon.Location = new System.Drawing.Point(263, 9);
            this.LblAltaPokemon.Name = "LblAltaPokemon";
            this.LblAltaPokemon.Size = new System.Drawing.Size(190, 25);
            this.LblAltaPokemon.TabIndex = 8;
            this.LblAltaPokemon.Text = "ALTA POKEMON";
            this.LblAltaPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbBxTipo
            // 
            this.CmbBxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbBxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxTipo.FormattingEnabled = true;
            this.CmbBxTipo.Location = new System.Drawing.Point(172, 217);
            this.CmbBxTipo.Name = "CmbBxTipo";
            this.CmbBxTipo.Size = new System.Drawing.Size(185, 28);
            this.CmbBxTipo.TabIndex = 4;
            // 
            // CmbBxDebilidad
            // 
            this.CmbBxDebilidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbBxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxDebilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxDebilidad.FormattingEnabled = true;
            this.CmbBxDebilidad.Location = new System.Drawing.Point(172, 252);
            this.CmbBxDebilidad.Name = "CmbBxDebilidad";
            this.CmbBxDebilidad.Size = new System.Drawing.Size(185, 28);
            this.CmbBxDebilidad.TabIndex = 5;
            // 
            // LblTipo
            // 
            this.LblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(52, 217);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(39, 20);
            this.LblTipo.TabIndex = 11;
            this.LblTipo.Text = "Tipo";
            // 
            // LblDebilidad
            // 
            this.LblDebilidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDebilidad.AutoSize = true;
            this.LblDebilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDebilidad.Location = new System.Drawing.Point(52, 252);
            this.LblDebilidad.Name = "LblDebilidad";
            this.LblDebilidad.Size = new System.Drawing.Size(75, 20);
            this.LblDebilidad.TabIndex = 12;
            this.LblDebilidad.Text = "Debilidad";
            // 
            // TxtBxUrlImagen
            // 
            this.TxtBxUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBxUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUrlImagen.Location = new System.Drawing.Point(172, 171);
            this.TxtBxUrlImagen.Name = "TxtBxUrlImagen";
            this.TxtBxUrlImagen.Size = new System.Drawing.Size(185, 26);
            this.TxtBxUrlImagen.TabIndex = 3;
            this.TxtBxUrlImagen.Leave += new System.EventHandler(this.TxtBxUrlImagen_Leave);
            // 
            // LblUrlImagen
            // 
            this.LblUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUrlImagen.AutoSize = true;
            this.LblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrlImagen.Location = new System.Drawing.Point(52, 177);
            this.LblUrlImagen.Name = "LblUrlImagen";
            this.LblUrlImagen.Size = new System.Drawing.Size(87, 20);
            this.LblUrlImagen.TabIndex = 13;
            this.LblUrlImagen.Text = "Url Imagen";
            // 
            // PctBxImagen
            // 
            this.PctBxImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PctBxImagen.Location = new System.Drawing.Point(426, 38);
            this.PctBxImagen.Name = "PctBxImagen";
            this.PctBxImagen.Size = new System.Drawing.Size(260, 242);
            this.PctBxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBxImagen.TabIndex = 15;
            this.PctBxImagen.TabStop = false;
            // 
            // FrmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(698, 363);
            this.Controls.Add(this.PctBxImagen);
            this.Controls.Add(this.TxtBxUrlImagen);
            this.Controls.Add(this.LblUrlImagen);
            this.Controls.Add(this.LblDebilidad);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.CmbBxDebilidad);
            this.Controls.Add(this.CmbBxTipo);
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
            this.Load += new System.EventHandler(this.FrmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxImagen)).EndInit();
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
        private System.Windows.Forms.ComboBox CmbBxTipo;
        private System.Windows.Forms.ComboBox CmbBxDebilidad;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblDebilidad;
        private System.Windows.Forms.TextBox TxtBxUrlImagen;
        private System.Windows.Forms.Label LblUrlImagen;
        private System.Windows.Forms.PictureBox PctBxImagen;
    }
}