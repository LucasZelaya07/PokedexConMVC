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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminarFisico = new System.Windows.Forms.Button();
            this.BtnEliminarLogico = new System.Windows.Forms.Button();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.TxtBxFiltro = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblCampo = new System.Windows.Forms.Label();
            this.CmbBxCampo = new System.Windows.Forms.ComboBox();
            this.CmbBxCriterio = new System.Windows.Forms.ComboBox();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.LblFiltroAvanzado = new System.Windows.Forms.Label();
            this.TxtBxFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPokemon
            // 
            this.DGVPokemon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVPokemon.Location = new System.Drawing.Point(119, 38);
            this.DGVPokemon.MultiSelect = false;
            this.DGVPokemon.Name = "DGVPokemon";
            this.DGVPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(119, 310);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 34);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(278, 310);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(120, 34);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminarFisico
            // 
            this.BtnEliminarFisico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarFisico.Location = new System.Drawing.Point(437, 310);
            this.BtnEliminarFisico.Name = "BtnEliminarFisico";
            this.BtnEliminarFisico.Size = new System.Drawing.Size(120, 34);
            this.BtnEliminarFisico.TabIndex = 4;
            this.BtnEliminarFisico.Text = "Eliminar(Fisico)";
            this.BtnEliminarFisico.UseVisualStyleBackColor = true;
            this.BtnEliminarFisico.Click += new System.EventHandler(this.BtnEliminarFisico_Click);
            // 
            // BtnEliminarLogico
            // 
            this.BtnEliminarLogico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminarLogico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarLogico.Location = new System.Drawing.Point(596, 310);
            this.BtnEliminarLogico.Name = "BtnEliminarLogico";
            this.BtnEliminarLogico.Size = new System.Drawing.Size(120, 34);
            this.BtnEliminarLogico.TabIndex = 5;
            this.BtnEliminarLogico.Text = "Eliminar(Logico)";
            this.BtnEliminarLogico.UseVisualStyleBackColor = true;
            this.BtnEliminarLogico.Click += new System.EventHandler(this.BtnEliminarLogico_Click);
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltro.Location = new System.Drawing.Point(119, 13);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(78, 16);
            this.LblFiltro.TabIndex = 6;
            this.LblFiltro.Text = "Filtro rápido";
            // 
            // TxtBxFiltro
            // 
            this.TxtBxFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxFiltro.Location = new System.Drawing.Point(223, 10);
            this.TxtBxFiltro.Name = "TxtBxFiltro";
            this.TxtBxFiltro.Size = new System.Drawing.Size(344, 22);
            this.TxtBxFiltro.TabIndex = 7;
            this.TxtBxFiltro.TextChanged += new System.EventHandler(this.TxtBxFiltro_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(749, 380);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(119, 383);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(51, 16);
            this.LblCampo.TabIndex = 9;
            this.LblCampo.Text = "Campo";
            // 
            // CmbBxCampo
            // 
            this.CmbBxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxCampo.FormattingEnabled = true;
            this.CmbBxCampo.Location = new System.Drawing.Point(192, 379);
            this.CmbBxCampo.Name = "CmbBxCampo";
            this.CmbBxCampo.Size = new System.Drawing.Size(121, 24);
            this.CmbBxCampo.TabIndex = 10;
            this.CmbBxCampo.SelectedIndexChanged += new System.EventHandler(this.CmbBxCampo_SelectedIndexChanged);
            // 
            // CmbBxCriterio
            // 
            this.CmbBxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxCriterio.FormattingEnabled = true;
            this.CmbBxCriterio.Location = new System.Drawing.Point(406, 379);
            this.CmbBxCriterio.Name = "CmbBxCriterio";
            this.CmbBxCriterio.Size = new System.Drawing.Size(121, 24);
            this.CmbBxCriterio.TabIndex = 11;
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCriterio.Location = new System.Drawing.Point(335, 383);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(49, 16);
            this.LblCriterio.TabIndex = 12;
            this.LblCriterio.Text = "Criterio";
            // 
            // LblFiltroAvanzado
            // 
            this.LblFiltroAvanzado.AutoSize = true;
            this.LblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltroAvanzado.Location = new System.Drawing.Point(549, 383);
            this.LblFiltroAvanzado.Name = "LblFiltroAvanzado";
            this.LblFiltroAvanzado.Size = new System.Drawing.Size(36, 16);
            this.LblFiltroAvanzado.TabIndex = 13;
            this.LblFiltroAvanzado.Text = "Filtro";
            // 
            // TxtBxFiltroAvanzado
            // 
            this.TxtBxFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxFiltroAvanzado.Location = new System.Drawing.Point(607, 381);
            this.TxtBxFiltroAvanzado.Name = "TxtBxFiltroAvanzado";
            this.TxtBxFiltroAvanzado.Size = new System.Drawing.Size(120, 22);
            this.TxtBxFiltroAvanzado.TabIndex = 14;
            // 
            // FrmPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 502);
            this.Controls.Add(this.TxtBxFiltroAvanzado);
            this.Controls.Add(this.LblFiltroAvanzado);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.CmbBxCriterio);
            this.Controls.Add(this.CmbBxCampo);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBxFiltro);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.BtnEliminarLogico);
            this.Controls.Add(this.BtnEliminarFisico);
            this.Controls.Add(this.BtnModificar);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPokemon;
        private System.Windows.Forms.PictureBox PcBxPokemon;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminarFisico;
        private System.Windows.Forms.Button BtnEliminarLogico;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.TextBox TxtBxFiltro;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.ComboBox CmbBxCampo;
        private System.Windows.Forms.ComboBox CmbBxCriterio;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.Label LblFiltroAvanzado;
        private System.Windows.Forms.TextBox TxtBxFiltroAvanzado;
    }
}

