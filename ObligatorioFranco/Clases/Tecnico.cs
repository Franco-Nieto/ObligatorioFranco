using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatorioFranco.Clases
{
    public class Tecnico
    {
        private static int IdIncremental = 0;
        public int Id { get; set; } 
        public string Nombre {  get; set; }
        public string Apellido {  get; set; }
        public string Ci{  get; set; }
        public EspecialidadTecnico Especialidad{  get; set; }
        public List<string> Comentarios { get; set; }
        
        public Tecnico(string nombre, string apellido, string ci, EspecialidadTecnico especialidad)
        {
            Id = ++IdIncremental;
            Nombre = nombre;
            Apellido = apellido;
            Ci = ci;
            Especialidad = especialidad;
        }
        public void setId(int id) { Id = id; }
        public int getId() { return Id; }
        public void setNombre(string nombre) { Nombre = nombre; }
        public string getNombre() { return Nombre; }
        public void setApellido(string apellido) { Apellido = apellido; }
        public string getApellido() { return Apellido; }
        public void setCi(string ci) { Ci = ci; }
        public string getCi() { return Ci; }
        public void setEspecialidad(EspecialidadTecnico especialidad) { Especialidad = especialidad; }
        public EspecialidadTecnico getEspecialidad() { return Especialidad; }
    }
}