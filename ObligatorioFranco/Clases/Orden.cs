using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatorioFranco.Clases
{
    public class Orden
    {
        private static int IdIncremental = 0;
        public int IdOrden;
        public Cliente Cliente;
        public Tecnico Tecnico;
        public string Descripcion;
        public DateTime Fecha;
        public EstadoOrden EstadoOrden;
        public List<string> Comentarios;

        public Orden(Cliente cliente, Tecnico tecnico, string descripcion, DateTime fecha, EstadoOrden estadoOrden, List<string> comentarios)
        {
            IdOrden = ++IdIncremental;
            Cliente = cliente;
            Tecnico = tecnico;
            Descripcion = descripcion;
            Fecha = fecha;
            EstadoOrden = estadoOrden;
            Comentarios = comentarios;
        }
        public int getIdOrden() { return IdOrden; }
        public void setCliente(Cliente cliente) { Cliente = cliente; }
        public Cliente getCliente() { return Cliente; }
        public void setTecnico(Tecnico tecnico) { Tecnico = tecnico; }
        public Tecnico getTecnico() { return Tecnico; }
        public void setDescripcion(string descripcion) { Descripcion = descripcion; }
        public string getDescripcion() { return Descripcion; }
        public void setFecha(DateTime fecha) { Fecha = fecha; }
        public DateTime getFecha() { return Fecha; }
        public void setEstadoOrden(EstadoOrden estadoOrden) {EstadoOrden = estadoOrden; }
        public EstadoOrden getEstadoOrden() {return EstadoOrden; }
        public void AgregarComentarios(string comentarios) { Comentarios.Add(comentarios); }
        public List<string> VerComentarios()
        {
            return Comentarios;
        }

    }
}