using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObligatorioFranco.Clases
{
    public class Cliente
    {
        private static int IdIncremental = 0;
        public int Id {  get; set; }
        public string Nombre {  get; set; }
        public string Apellido {  get; set; }
        public string Ci {  get; set; }
        public string Direccion {  get; set; }
        public string Telefono {  get; set; }
        public string Email {  get; set; }

        public Cliente(string nombre, string apellido, string ci, string direccion, string telefono, string email)
        {
            Id = ++IdIncremental;
            Nombre = nombre;
            Apellido = apellido;
            Ci = ci;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
        public Cliente(string nombre, string apellido, string ci, string direccion, string telefono)
        {
            Id = ++IdIncremental;
            Nombre = nombre;
            Apellido = apellido;
            Ci = ci;
            Direccion = direccion;
            Telefono = telefono;
        }


        public void setId(int id) { Id = id; }
        public int getId() { return Id; }       
        public void setNombre(string nombre){ Nombre = nombre;}
        public string getNombre() { return Nombre; }
        public void setApellido(string apellido) { Apellido = apellido; }
        public string getApellido() { return Apellido; }
        public void setCi(string ci) { Ci = ci; }
        public string getCi() { return Ci; }
        public void setDireccion(string direccion) { Direccion = direccion; }
        public string getDireccion() { return Direccion; }
        public void setTelefono(string telefono) { Telefono = telefono; }
        public string getTelefono() { return Telefono; }
        public void setEmail(string email) { Email = email; }
        public string getEmail() { return Email; }
      
    }
}