<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ObligatorioFranco._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
      <asp:GridView runat="server" ID="GVordenes"></asp:GridView>
       
        <div style="margin-bottom: 40px;">
            <asp:Button runat="server" Text="Gestión de Clientes" PostBackUrl="GestionClientes.aspx"/>
            <asp:Button runat="server" Text="Gestión de Técnicos" PostBackUrl="GestionTecnicos.aspx"/>
            <asp:Button runat="server" Text="Nueva Orden" PostBackUrl="GestionOrdenes.aspx"/>
        </div>
        
        <asp:GridView runat="server" ID="GridView1" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
                <asp:BoundField DataField="NombreTecnico" HeaderText="Técnico" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
            </Columns>
        </asp:GridView>
            
    </main>

</asp:Content>
