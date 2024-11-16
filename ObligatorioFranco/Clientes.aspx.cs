using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObligatorioFranco
{
	public partial class Clientes : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			GVClientes.DataSource = BaseDeDatos.ListaClientes;
			GVClientes.DataBind();
		}
	}
}