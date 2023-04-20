using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumirArqui.Pedido
{
    public partial class pedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArticulo .Text = grArticulos.SelectedRow.Cells[1].Text.ToString();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceArticuloPedidoSoapClient web2 = new ServiceReference1.ServiceArticuloPedidoSoapClient();
            web2.Insertar(txtArticulo.Text, txtCURP.Text, txtCantidad.Text);
            grArticulos.DataBind();
        }
    }
}