﻿using ConsumirArqui.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumirArqui.Cliente
{
    public partial class Cliente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            webClient.WebClienteSoapClient web = new webClient.WebClienteSoapClient();
            web.Insertar(txtEmail.Text, txtPsw.Text, txtNombre.Text, txtApe.Text, txtTel.Text, txtCate.Text);
            txtEmail.Text = "";
            txtPsw.Text = "";
            txtNombre.Text = "";
            txtApe.Text = "";
            txtTel.Text = "";
            txtCate.Text = "";
        }

        protected void btnModi_Click(object sender, EventArgs e)
        {
            webClient.WebClienteSoapClient web = new webClient.WebClienteSoapClient();
            web.Modificar(txtEmail.Text, txtPsw.Text, txtNombre.Text, txtApe.Text, txtTel.Text, txtCate.Text);
            txtEmail.Text = "";
            txtPsw.Text = "";
            txtNombre.Text = "";
            txtApe.Text = "";
            txtTel.Text = "";
            txtCate.Text = "";
        }

        protected void btnEli_Click(object sender, EventArgs e)
        {
            webClient.WebClienteSoapClient web = new webClient.WebClienteSoapClient();
            web.Eliminar(txtEmail.Text);
            txtEmail.Text = "";
            txtPsw.Text = "";
            txtNombre.Text = "";
            txtApe.Text = "";
            txtTel.Text = "";
            txtCate.Text = "";
        }
    }
}