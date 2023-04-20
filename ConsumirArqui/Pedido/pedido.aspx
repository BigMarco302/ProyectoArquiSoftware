<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pedido.aspx.cs" Inherits="ConsumirArqui.Pedido.pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
        <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <h1>Catalogo
            </h1>
        </div>
        <div class="col-md-4">
        </div>
        <br>
    </div>
    <br>
    <br>
    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="Label1" runat="server" Text="Label">CURP</asp:Label>
            <asp:TextBox ID="txtCURP" CssClass="form-control" runat="server" PlaceHolder="CURP"></asp:TextBox>

        </div>
        <div class="col-md-4">
            <asp:Label ID="Label2" runat="server" Text="Label">Cantidad</asp:Label>
            <asp:TextBox ID="txtCantidad" CssClass="form-control" runat="server" PlaceHolder="Cantidad"></asp:TextBox>
 
    </div>
        <div class="col-md-4">
            <asp:Label ID="Label3" runat="server" Text="Label">No. Articulo</asp:Label>
            <asp:TextBox ID="txtArticulo" CssClass="form-control" runat="server" PlaceHolder="No. Articulo"></asp:TextBox>
 
    </div>
    </div>
    <br>
    <br>

    <div class="row">
       
        <div class="col-md-4">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
 
    </div>
         </div>
       <br>
    <br>

    <div class="row">
        <div class="col-md-12">
           
            <asp:GridView ID="grArticulos" runat="server" AutoGenerateColumns="False" DataKeyNames="idArticulo" DataSourceID="SqlDataSourcePedido" OnSelectedIndexChanged="grArticulos_SelectedIndexChanged" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC"></AlternatingRowStyle>
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Seleccionar"></asp:CommandField>
                    <asp:BoundField DataField="idArticulo" HeaderText="idArticulo" ReadOnly="True" SortExpression="idArticulo"></asp:BoundField>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
                    <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio"></asp:BoundField>
                    <asp:BoundField DataField="Stok" HeaderText="Stok" SortExpression="Stok"></asp:BoundField>
                    <asp:BoundField DataField="Material" HeaderText="Material" SortExpression="Material"></asp:BoundField>
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion"></asp:BoundField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC"></FooterStyle>

                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"></HeaderStyle>

                <PagerStyle HorizontalAlign="Center" BackColor="#999999" ForeColor="Black"></PagerStyle>

                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

                <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

                <SortedAscendingHeaderStyle BackColor="#808080"></SortedAscendingHeaderStyle>

                <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

                <SortedDescendingHeaderStyle BackColor="#383838"></SortedDescendingHeaderStyle>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSourcePedido" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT idArticulo, Nombre, Precio, Stok, Material, Descripcion FROM Articulo"></asp:SqlDataSource>
        </div>
    </div>





</asp:Content>
