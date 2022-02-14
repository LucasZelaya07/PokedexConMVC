namespace Pokedex
{
    partial class FrmPokedex
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVPokemon = new System.Windows.Forms.DataGridView();
            this.PcBxPokemon = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPokemon
            // 
            this.DGVPokemon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPokemon.Location = new System.Drawing.Point(119, 38);
            this.DGVPokemon.Name = "DGVPokemon";
            this.DGVPokemon.Size = new System.Drawing.Size(599, 219);
            this.DGVPokemon.TabIndex = 0;
            this.DGVPokemon.SelectionChanged += new System.EventHandler(this.DGVPokemon_SelectionChanged);
            // 
            // PcBxPokemon
            // 
            this.PcBxPokemon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PcBxPokemon.Location = new System.Drawing.Point(743, 38);
            this.PcBxPokemon.Name = "PcBxPokemon";
            this.PcBxPokemon.Size = new System.Drawing.Size(260, 219);
            this.PcBxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBxPokemon.TabIndex = 1;
            this.PcBxPokemon.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(128, 291);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(175, 53);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 502);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.PcBxPokemon);
            this.Controls.Add(this.DGVPokemon);
            this.Name = "FrmPokedex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPokemon;
        private System.Windows.Forms.PictureBox PcBxPokemon;
        private System.Windows.Forms.Button BtnAgregar;
    }
}

