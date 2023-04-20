<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosEnv.aspx.cs" Inherits="ConsumirArqui.Envio.DatosEnv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1> Pagina de Cliente</h1>
    <div class="row">
        <div class="col-md-3">
			<asp:TextBox ID="txtCurp" runat="server" PlaceHolder="Curp" ></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtDom" runat="server" PlaceHolder="Domicilio"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtCp" runat="server" PlaceHolder="Codigo Postal"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtRefe" runat="server" PlaceHolder="Referencia"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtGm" runat="server" PlaceHolder="Gmail"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <asp:DropDownList ID="DropDownListEstados" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="estado" DataValueField="cve_estado"></asp:DropDownList>
            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT cve_estado, estado FROM Estado"></asp:SqlDataSource>
        </div>
        <div class="col-md-4">
            <asp:DropDownList ID="DropDownListMuni" runat="server" AutoPostBack="True" DataSourceID="DataSourceMuni" DataTextField="municipio" DataValueField="cve_municipio"></asp:DropDownList>
            <asp:SqlDataSource runat="server" ID="DataSourceMuni" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT cve_municipio, municipio FROM municipio WHERE (cve_estado = @cve_estado)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownListEstados" PropertyName="SelectedValue" Name="cve_estado"></asp:ControlParameter>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
        <div class="col-md-4">
            <asp:DropDownList ID="DropDownListLoca" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="localidad" DataValueField="cve_loc"></asp:DropDownList>
            <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT cve_loc, localidad FROM localidad WHERE (cve_estdo = @cve_estdo) AND (cve_mun = @cve_mun) ORDER BY localidad">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownListEstados" PropertyName="SelectedValue" Name="cve_estdo"></asp:ControlParameter>
                    <asp:ControlParameter ControlID="DropDownListMuni" PropertyName="SelectedValue" Name="cve_mun"></asp:ControlParameter>
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource runat="server" ID="SqlDataSourceLoca"></asp:SqlDataSource>
        </div>
    </div>
    <div class="row">
        <asp:Button ID="btnInsertar" runat="server" Text="Agregar" OnClick="btnInsertar_Click"  />
        <asp:Button ID="btnModi" runat="server" Text="Modificar"  />
        <asp:Button ID="btnEli" runat="server" Text="Eliminar" />
    </div>
</asp:Content>
