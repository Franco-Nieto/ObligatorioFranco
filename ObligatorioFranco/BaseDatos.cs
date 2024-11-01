using ObligatorioFranco.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatorioFranco
{
    public static class BaseDeDatos
    {
        public static List<Cliente> ListaClientes = new List<Cliente>
        {
            new Cliente("Pepe", "Sanchez", "30302553", "Carlos Paez 2204", "095989898", "pepesanchez@gmail.com"),
            new Cliente("Carlos", "Garcia", "30503553", "18 de Julio 204", "099123591"),
            new Cliente("Marta", "De Leon", "40015532", "Rincon 305", "093982112")
        };

        public static List<Tecnico> ListaTecnicos { get; set; } = new List<Tecnico>
        {
            new Tecnico("Nacho", "Culebra", "33490543", EspecialidadTecnico.Informatica),
            new Tecnico("Julia", "Lopez", "43223541", EspecialidadTecnico.Electrodomesticos),
            new Tecnico("Pablo", "Clavito", "52518522", EspecialidadTecnico.Redes)
        };

        public static List<Orden> ListaOrdenes = new List<Orden>
        {
            new Orden(ListaClientes[0], ListaTecnicos[0], "Limpiar virus", DateTime.Now, EstadoOrden.Completada, ListaTecnicos[0].Comentarios),
            new Orden(ListaClientes[1], ListaTecnicos[1], "Arreglar Heladera", DateTime.Now, EstadoOrden.EnProgreso, ListaTecnicos[1].Comentarios),
            new Orden(ListaClientes[2], ListaTecnicos[2], "Instalar luces", DateTime.Now, EstadoOrden.Pendiente, ListaTecnicos[2].Comentarios)
        };

    }
}