using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Pokedex
{
    public partial class FrmAltaPokemon : Form
    {
        public FrmAltaPokemon()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon Poke = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                Poke.Numero = int.Parse(TxBxNumero.Text);
                Poke.Nombre = TxBxNombre.Text;
                Poke.Descripcion = TxBxDescripcion.Text;
                negocio.Agregar(Poke);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
