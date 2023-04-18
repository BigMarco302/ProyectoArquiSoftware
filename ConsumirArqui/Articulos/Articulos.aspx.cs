using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumirArqui.Articulos
{
    public partial class Articulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

            webArticulo.ServiceArquiSoapClient  web = new webArticulo.ServiceArquiSoapClient();
            web.Insertar(txtIdArticulo.Text  , txtNombre.Text, txtPrecio.Text, txtCosto.Text, txtStok.Text, txtMaterial.Text, txtCategoria.Text, txtDescripcion.Text);
            txtIdArticulo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCosto.Text = "";
            txtStok.Text = "";
            txtMaterial.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            grArticulos.DataBind(); 
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            webArticulo.ServiceArquiSoapClient web = new webArticulo.ServiceArquiSoapClient();
            web.Eliminar (txtIdArticulo.Text);
            txtIdArticulo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCosto.Text = "";
            txtStok.Text = "";
            txtMaterial.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            grArticulos.DataBind();

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            webArticulo.ServiceArquiSoapClient web = new webArticulo.ServiceArquiSoapClient();
            web.Modificar(txtIdArticulo.Text, txtNombre.Text, txtPrecio.Text, txtCosto.Text, txtStok.Text, txtMaterial.Text, txtCategoria.Text, txtDescripcion.Text);
            txtIdArticulo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCosto.Text = "";
            txtStok.Text = "";
            txtMaterial.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            grArticulos.DataBind();
        }

        protected void grArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdArticulo.Text = grArticulos.SelectedRow.Cells[1].Text.ToString();
            txtNombre.Text = grArticulos.SelectedRow.Cells[2].Text.ToString();
            txtPrecio.Text = grArticulos.SelectedRow.Cells[3].Text.ToString();
            txtCosto.Text = grArticulos.SelectedRow.Cells[4].Text.ToString();
            txtStok.Text = grArticulos.SelectedRow.Cells[5].Text.ToString();
            txtMaterial.Text = grArticulos.SelectedRow.Cells[6].Text.ToString();
            txtCategoria.Text = grArticulos.SelectedRow.Cells[7].Text.ToString();
            txtDescripcion.Text = grArticulos.SelectedRow.Cells[8].Text.ToString();
        }
    }


}