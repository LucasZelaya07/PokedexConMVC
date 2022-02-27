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
    public partial class FrmPokedex : Form
    {
        private List<Pokemon> listaPokemon;
        public FrmPokedex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
            CmbBxCampo.Items.Add("Numero");
            CmbBxCampo.Items.Add("Nombre");
            CmbBxCampo.Items.Add("Descripcion");
        }

        private void DGVPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if(DGVPokemon.CurrentRow != null)
            {
                //Cuando cambie la selección, cambiara la imagen
                //Devuelve un objeto pero yo se que es un pokemon, asi que lo convierto
                //Con un casteo explicito para guardarlo en una variable pokemon
                Pokemon Seleccionado = (Pokemon)DGVPokemon.CurrentRow.DataBoundItem;
                cargarImagen(Seleccionado.UrlImagen);
            }
        }
        private void Cargar()
        {
            //Creo una variable de PokemonNegocio y una instancia de PokemonNegocio
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                //Negocio.listaPokemon va a la base de datos y devuelve una lista de datos
                //DGVPokemon.DataSource recibe un origen de datos y lo modela en la tabla
                //DataSource lee con "Reflexion" la estructura de los datos y la mapea
                //Los datos que trae negocio.listaPokemon los guardo en un atributo privado
                listaPokemon = negocio.listaPokemon();
                DGVPokemon.DataSource = listaPokemon;
                //Oculto la columna "UrlImagen"
                OcultarColumnas();
                //Cargo la imagen de los pokemones
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void OcultarColumnas()
        {
            DGVPokemon.Columns ["UrlImagen"].Visible = false;
            DGVPokemon.Columns ["Id"].Visible = false;
        }
        private void cargarImagen(string Imagen)
        {
            //Modulo la funcion para que ejecute el Load
            //Creo una excepción para que no se rompa la app cuando una url no exista mas
            try
            {
                //Si va bien, mostrará la imagen de manera correcta
                PcBxPokemon.Load(Imagen);
            }
            catch (Exception)
            {
                //En caso de que no exista o este rota, se mostrará un "image placeholder"
                PcBxPokemon.Load("https://ducasseindustrial.com/wp-content/uploads/2020/07/placeholder.png");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPokemon alta = new FrmAltaPokemon();
            alta.ShowDialog();
            Cargar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)DGVPokemon.CurrentRow.DataBoundItem;
            FrmAltaPokemon modificar = new FrmAltaPokemon(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void BtnEliminarFisico_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnEliminarLogico_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }
        private void Eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de querer eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)DGVPokemon.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.EliminarLogico(seleccionado.Id);
                    else
                        negocio.Eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool ValidarFiltro()
        {
            if(CmbBxCampo.SelectedIndex == -1 )
            {
                MessageBox.Show("Por favor, seleccionar el campo para filtrar");
                return true;
            }
            if(CmbBxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccionar el criterio para filtrar");
                return true;
            }
            if (CmbBxCampo.SelectedItem.ToString() == "Numero")
            {
                if(string.IsNullOrEmpty(TxtBxFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debe cargar el filtro para numéricos...");
                    return true;
                }
                if(!(SoloNumeros(TxtBxFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Ingrese solo números en el Filtro avanzado, por favor");
                    return true;
                }
            }
                return false;
        }
        private bool SoloNumeros(string Cadena)
        {
            foreach (char caracter in Cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (ValidarFiltro())
                    return;
                string campo = CmbBxCampo.SelectedItem.ToString();
                string criterio = CmbBxCriterio.SelectedItem.ToString();
                string filtro = TxtBxFiltroAvanzado.Text;
                DGVPokemon.DataSource = negocio.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void TxtBxFiltro_TextChanged(object sender, EventArgs e)
        {
            //Cada vez que se va ingresando un caracter, empieza a buscar con ese ingreso
            List<Pokemon> ListaFiltrada;
            string filtro = TxtBxFiltro.Text;
            //Aplico un minimo de 2 caracteres para que empiece a buscar
            if (filtro.Length >= 2)
            {
                //Este metodo ya devuelve un objeto, así que uso ese resultado y lo guardo en la Lista
                //Le aplico la función ToLower() para que convierta todo en minuscula y no discrimine
                //a la hora de buscar entre minuscula y mayuscula
                //Uso .Contains para que busque si en mi base de datos hay algo que coincida con el ingreso en el filtro
                //Si busco "Pi" y coinciden 2 cosas que contienen Pi en su nombre, me las mostrará.
                ListaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Tipo.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                ListaFiltrada = listaPokemon;
            }
            DGVPokemon.DataSource = null;
            DGVPokemon.DataSource = ListaFiltrada;
            OcultarColumnas();
        }

        private void CmbBxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = CmbBxCampo.SelectedItem.ToString();
            if(opcion == "Numero")
            {
                CmbBxCriterio.Items.Clear();
                CmbBxCriterio.Items.Add("Mayor a");
                CmbBxCriterio.Items.Add("Menor a");
                CmbBxCriterio.Items.Add("Igual a");
            }
            else
            {
                CmbBxCriterio.Items.Clear();
                CmbBxCriterio.Items.Add("Comienza con");
                CmbBxCriterio.Items.Add("Termina con");
                CmbBxCriterio.Items.Add("Contiene");
            }
        }
    }
}
