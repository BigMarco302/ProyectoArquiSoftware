<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="ConsumirArqui.Carrito.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <br>
        <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <h1>Carrito
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
            <asp:Label ID="Label1" runat="server" Text="Label">Cantidad</asp:Label>
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
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-warning"  />
 
    </div>
          <div class="col-md-4">
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger"  />
 
    </div>
        </div>
       <br>
    <br>
    <div class="row">
       
          <div class="col-md-12">
              <asp:GridView ID="grCarrito" runat="server" DataSourceID="SqlDataSourceCarrito" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="grCarrito_SelectedIndexChanged">
                  <Columns>
                      <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                      <asp:BoundField DataField="idCURP" HeaderText="idCURP" SortExpression="idCURP"></asp:BoundField>
                      <asp:BoundField DataField="idEmail" HeaderText="idEmail" SortExpression="idEmail"></asp:BoundField>
                      <asp:BoundField DataField="idArticulo_Pedido" HeaderText="idArticulo_Pedido" ReadOnly="True" InsertVisible="False" SortExpression="idArticulo_Pedido"></asp:BoundField>
                      <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
                      <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio"></asp:BoundField>
                      <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad"></asp:BoundField>
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



              <asp:SqlDataSource runat="server" ID="SqlDataSourceCarrito" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT DatosEnvio.idCURP, Cliente.idEmail, Articulo_Pedido.idArticulo_Pedido, Articulo.Nombre, Articulo.Precio, Articulo_Pedido.Cantidad FROM Articulo INNER JOIN Articulo_Pedido ON Articulo.idArticulo = Articulo_Pedido.idArticulo INNER JOIN DatosEnvio ON Articulo_Pedido.idCURP = DatosEnvio.idCURP INNER JOIN Cliente ON DatosEnvio.idClienteGmail = Cliente.idEmail WHERE (Articulo_Pedido.idCURP = @idCURP)">
                  <SelectParameters>
                      <asp:ControlParameter ControlID="txtCURP" PropertyName="Text" DefaultValue="NULL" Name="idCURP"></asp:ControlParameter>
                  </SelectParameters>
              </asp:SqlDataSource>
          </div>
        </div>
       <br>
    <br>

</asp:Content>
