<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ObligatorioFranco._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
		<asp:GridView runat="server" ID="GVordenes">
			<Columns>
				<asp:BoundField DataField="NombreCliente" HeaderText="Cliente" />
				<asp:BoundField DataField="NombreTecnico" HeaderText="Técnico" />
				<asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
				<asp:BoundField DataField="Fecha" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha" />
				<asp:BoundField DataField="Estado" HeaderText="Estado" />
			</Columns>
		</asp:GridView>
</asp:Content>
