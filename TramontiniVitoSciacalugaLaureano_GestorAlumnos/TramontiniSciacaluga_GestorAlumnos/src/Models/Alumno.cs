using System;

// FORZAMOS este namespace para que todos lo encuentren fácil
namespace TramontiniSciacaluga_GestorAlumnos.Models
{
    public class Alumno
    {
        public string Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Alumno() { }

        public Alumno(string legajo, string apellido, string nombre, string documento, string email, string telefono)
        {
            Legajo = legajo;
            Apellido = apellido;
            Nombre = nombre;
            Documento = documento;
            Email = email;
            Telefono = telefono;
        }

        public string AFormatoTxt() => $"{Legajo}|{Apellido}|{Nombre}|{Documento}|{Email}|{Telefono}";
        public string AFormatoCsv() => $"{Legajo},{Apellido},{Nombre},{Documento},{Email},{Telefono}";
    }
}