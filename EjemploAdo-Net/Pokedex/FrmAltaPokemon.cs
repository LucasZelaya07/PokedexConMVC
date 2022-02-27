using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;

namespace Pokedex
{
    public partial class FrmAltaPokemon : Form
    {
        private Pokemon pokemon = null;

        private OpenFileDialog archivo = null;

        public FrmAltaPokemon()
        {
            InitializeComponent();
        }
        public FrmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar pokemon";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if(pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(TxBxNumero.Text);
                pokemon.Nombre = TxBxNombre.Text;
                pokemon.Descripcion = TxBxDescripcion.Text;
                pokemon.UrlImagen = TxtBxUrlImagen.Text;
                pokemon.Tipo = (Elemento)CmbBxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)CmbBxDebilidad.SelectedItem;
                //Para saber si la persona quiere modificar
                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                //Para saber si la persona quiere agregar
                else
                {
                    negocio.Agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }
                //Para guardar la imagen localmente
                if(archivo != null && !(TxtBxUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    //Guardar la imagen
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Images-Folder"] + archivo.SafeFileName);
                }
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
                //ValueMember es lo que esta escondido para la vista
                CmbBxTipo.ValueMember = "Id";
                //DisplayMember es el que se ve
                CmbBxTipo.DisplayMember = "Descripcion";
                CmbBxDebilidad.DataSource = elementoNegocio.listar();
                CmbBxDebilidad.ValueMember = "Id";
                CmbBxDebilidad.DisplayMember = "Descripcion";
                if(pokemon != null)
                {
                    TxBxNumero.Text = pokemon.Numero.ToString();
                    TxBxNombre.Text = pokemon.Nombre;
                    TxBxDescripcion.Text = pokemon.Descripcion;
                    TxtBxUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    CmbBxTipo.SelectedValue = pokemon.Tipo.Id;
                    CmbBxDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
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
        
        private void BtnUrlImagen_Click(object sender, EventArgs e)
        {
            //Subir imagenes desde archivo local
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg | png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                //Para guardar la ruta completa
                TxtBxUrlImagen.Text = archivo.FileName;
                //Para cargar la imagen
                cargarImagen(archivo.FileName);
            }
        }
    }
}
