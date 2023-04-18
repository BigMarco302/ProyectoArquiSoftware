<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="ConsumirArqui.Articulos.Articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
        <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <h1>Articulos</h1>
        </div>
        <div class="col-md-4">
        </div>
        <br>
    </div>
    <br>
    <br>
    
    <div class="row">
        <div class="col-md-3">
            <asp:Label ID="Label1" runat="server" Text="Label">Id del Articulo</asp:Label>
            <asp:TextBox ID="txtIdArticulo" CssClass="form-control" runat="server" PlaceHolder="IdArticulo"></asp:TextBox>

        </div>
        <div class="col-md-3">
            <asp:Label ID="Label2" runat="server" Text="Label">Nombre del Articulo</asp:Label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" PlaceHolder="Nombre"></asp:TextBox>

        </div>
        <div class="col-md-3">
            <asp:Label ID="Label3" runat="server" Text="Label">Precio del Articulo</asp:Label>
            <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server" PlaceHolder="Precio"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Label ID="Label8" runat="server" Text="Label">Costo del Articulo</asp:Label>
            <asp:TextBox ID="txtCosto" CssClass="form-control" runat="server" PlaceHolder="Costo"></asp:TextBox>
        </div>
        
    </div>
    <br>

        <div class="row">
            <div class="col-md-3">
                <asp:Label ID="Label4" runat="server" Text="Label">Stok del Articulo</asp:Label>
            <asp:TextBox ID="txtStok" CssClass="form-control" runat="server" PlaceHolder="Stok"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Label ID="Label5" runat="server" Text="Label">Material del Articulo</asp:Label>
            <asp:TextBox ID="txtMaterial" CssClass="form-control" runat="server" PlaceHolder="Material"></asp:TextBox>

        </div>
        <div class="col-md-3"><asp:Label ID="Label6" runat="server" Text="Label">Categoria del Articulo</asp:Label>
            <asp:TextBox ID="txtCategoria" CssClass="form-control" runat="server" PlaceHolder="Categoria"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Label ID="Label7" runat="server" Text="Label">Descripcion del Articulo</asp:Label>
            <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server" PlaceHolder="Descripcion"></asp:TextBox>
    </div>
    </div>
      <br>
    <div class="row">
        <div class="col-md-3">
            <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-success" OnClick="btnInsertar_Click" />

        </div>
        <div class="col-md-3">
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-warning" OnClick="btnEliminar_Click" />
        </div>
        <div class="col-md-3">
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-danger" OnClick="btnModificar_Click" />
    </div>
        </div>
        <div class="col-md-3">
           

    </div>

      <br>
      <br>

     <div class="row">
        <div class="col-md-11">
            <asp:GridView ID="grArticulos" runat="server" DataSourceID="SqlDataSourceArticulos" AutoGenerateColumns="False" DataKeyNames="idArticulo" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="grArticulos_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
            <asp:BoundField DataField="idArticulo" HeaderText="idArticulo" ReadOnly="True" SortExpression="idArticulo"></asp:BoundField>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
            <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio"></asp:BoundField>
            <asp:BoundField DataField="Costo" HeaderText="Costo" SortExpression="Costo"></asp:BoundField>
            <asp:BoundField DataField="Stok" HeaderText="Stok" SortExpression="Stok"></asp:BoundField>
            <asp:BoundField DataField="Material" HeaderText="Material" SortExpression="Material"></asp:BoundField>
            <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria"></asp:BoundField>
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion"></asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099"></FooterStyle>

        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC"></HeaderStyle>

        <PagerStyle HorizontalAlign="Center" BackColor="#FFFFCC" ForeColor="#330099"></PagerStyle>

        <RowStyle BackColor="White" ForeColor="#330099"></RowStyle>

        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#FEFCEB"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#AF0101"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#F6F0C0"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#7E0000"></SortedDescendingHeaderStyle>
    </asp:GridView>


   
            <asp:SqlDataSource runat="server" ID="SqlDataSourceArticulos" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT idArticulo, Nombre, Precio, Costo, Stok, Material, Categoria, Descripcion FROM Articulo"></asp:SqlDataSource>
      </div>
    </div>
    <br>


</asp:Content>
