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
                Poke.UrlImagen = TxtBxUrlImagen.Text;
                Poke.Tipo = (Elemento)CmbBxTipo.SelectedItem;
                Poke.Debilidad = (Elemento)CmbBxDebilidad.SelectedItem;
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

        private void FrmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                CmbBxTipo.DataSource = elementoNegocio.listar();
                CmbBxDebilidad.DataSource = elementoNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void TxtBxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(TxtBxUrlImagen.Text);
        }

        private void cargarImagen(string Imagen)
        {
            try
            {
                PctBxImagen.Load(Imagen);
            }
            catch (Exception)
            {
                PctBxImagen.Load("https://ducasseindustrial.com/wp-content/uploads/2020/07/placeholder.png");
            }
        }
    }
}
