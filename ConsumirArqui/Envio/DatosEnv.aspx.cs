using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumirArqui.Envio
{
    public partial class DatosEnv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            webEnvio.DatosEnvioSoapClient env = new webEnvio.DatosEnvioSoapClient();
            env.Insertar(txtCurp.Text, txtDom.Text, txtCp.Text, txtRefe.Text, DropDownListEstados.SelectedValue, DropDownListMuni.SelectedValue, DropDownListLoca.SelectedValue,txtGm.Text);
            txtCurp.Text = "";
            txtDom.Text = "";
            txtCp.Text = "";
            DropDownListEstados.SelectedValue = "";
            DropDownListMuni.SelectedValue = "";
            DropDownListLoca.SelectedValue = "";
            txtGm.Text = "";
        }
    }
}