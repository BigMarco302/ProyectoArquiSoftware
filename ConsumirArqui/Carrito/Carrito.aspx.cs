using ConsumirArqui.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumirArqui.Carrito
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = grCarrito.SelectedRow.Cells[6].Text.ToString();
            txtArticulo .Text = grCarrito.SelectedRow.Cells[3].Text.ToString();
        }
    }
}