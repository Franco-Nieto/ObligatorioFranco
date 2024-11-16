<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="ObligatorioFranco.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
		<h1>Clientes:</h1>
<div class="row">
	<div class="col-12"></div>
	<asp:GridView ID="GVClientes" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false">
		<Columns>
			<asp:BoundField DataField="Id" HeaderText="ID" />
			<asp:BoundField DataField="Nombre" HeaderText="Nombre" />
			<asp:BoundField DataField="Apellido" HeaderText="Apellido" />
			<asp:BoundField DataField="Ci" HeaderText="Cedula" />
			<asp:BoundField DataField="Direccion" HeaderText="Direccion" />
			<asp:BoundField DataField="Telefono" HeaderText="Telefono" />
			<asp:BoundField DataField="Email" HeaderText="Email*" />
			<asp:TemplateField>
				<ItemTemplate>
					<asp:LinkButton runat="server"  
						CssClass="btn btn-sm btn-primary" CommandArgument='<%#Eval("id") %>'>
					Editar</asp:LinkButton>
					<asp:LinkButton runat="server"
						CssClass="btn btn-sm btn-danger"  OnClientClick="return confirm('Desea eliminar?')" CommandArgument='<%#Eval("Id") %>'>
					Eliminar
					</asp:LinkButton>

				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
	</asp:GridView>
</div>
</asp:Content>
