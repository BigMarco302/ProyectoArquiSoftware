<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="ConsumirArqui.Cliente.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Pagina de Cliente</h1>
    <div class="row">
        <div class="col-md-3">
			<asp:TextBox ID="txtEmail" runat="server" PlaceHolder="Email"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtPsw" runat="server" PlaceHolder="Contraseña"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtNombre" runat="server" PlaceHolder="Nombre"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtApe" runat="server" PlaceHolder="Apellido"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtTel" runat="server" PlaceHolder="Telefono"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtCate" runat="server" PlaceHolder="Categoria"></asp:TextBox>
        </div>
    </div>
    <asp:Button ID="btnInsertar" runat="server" Text="Agregar" OnClick="btnInsertar_Click" />
    <asp:Button ID="btnModi" runat="server" Text="Modificar" />
    <asp:Button ID="btnEli" runat="server" Text="Eliminar" />
</asp:Content>
