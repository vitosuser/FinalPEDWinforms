using System;

namespace TramontiniSciacaluga_GestorAlumnos.Models
{
    public class Alumno
    {
        public string Legajo { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefono { get; set; } = null!;

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