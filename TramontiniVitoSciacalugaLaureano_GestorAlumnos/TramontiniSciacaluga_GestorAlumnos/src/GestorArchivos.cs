using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
// IMPORTANTE: Esto conecta con tu clase Alumno correcta
using TramontiniSciacaluga_GestorAlumnos.Models;

// IMPORTANTE: El namespace debe coincidir con tu proyecto
namespace TramontiniSciacaluga_GestorAlumnos
{
    public class GestorArchivos
    {
        // === GESTIÓN DE BACKUPS ===
        public void CrearBackup(string rutaOriginal)
        {
            if (File.Exists(rutaOriginal))
            {
                string rutaBackup = rutaOriginal + ".bak";
                File.Copy(rutaOriginal, rutaBackup, true);
            }
        }

        // === GUARDADO ===
        public void GuardarArchivo(string rutaCompleta, string extension, List<Alumno> alumnos)
        {
            switch (extension.ToLower())
            {
                case ".txt": GuardarTxt(rutaCompleta, alumnos); break;
                case ".csv": GuardarCsv(rutaCompleta, alumnos); break;
                case ".json": GuardarJson(rutaCompleta, alumnos); break;
                case ".xml": GuardarXml(rutaCompleta, alumnos); break;
                default: throw new Exception("Formato no soportado.");
            }
        }

        // === LECTURA ===
        public List<Alumno> LeerAlumnosDesdeArchivo(string extension, string rutaCompleta)
        {
            if (!File.Exists(rutaCompleta)) return new List<Alumno>();

            switch (extension.ToLower())
            {
                case ".txt": return LeerTxt(rutaCompleta);
                case ".csv": return LeerCsv(rutaCompleta);
                case ".json": return LeerJson(rutaCompleta);
                case ".xml": return LeerXml(rutaCompleta);
                default: throw new Exception("Formato no soportado.");
            }
        }

        public bool ValidarExistencia(string ruta) => File.Exists(ruta);

        public void EliminarArchivo(string ruta)
        {
            if (File.Exists(ruta)) File.Delete(ruta);
            else throw new FileNotFoundException("Archivo no encontrado.");
        }

        // === PRIVADOS (Motores de lectura/escritura) ===
        private void GuardarTxt(string ruta, List<Alumno> l)
        {
            using (StreamWriter w = new StreamWriter(ruta))
                foreach (var a in l) w.WriteLine(a.AFormatoTxt());
        }
        private void GuardarCsv(string ruta, List<Alumno> l)
        {
            using (StreamWriter w = new StreamWriter(ruta))
            {
                w.WriteLine("Legajo,Apellido,Nombre,Documento,Email,Telefono");
                foreach (var a in l) w.WriteLine(a.AFormatoCsv());
            }
        }
        private void GuardarJson(string ruta, List<Alumno> l) => File.WriteAllText(ruta, JsonSerializer.Serialize(l, new JsonSerializerOptions { WriteIndented = true }));

        private void GuardarXml(string ruta, List<Alumno> l)
        {
            XmlSerializer s = new XmlSerializer(typeof(List<Alumno>), new XmlRootAttribute("Alumnos"));
            using (StreamWriter w = new StreamWriter(ruta)) s.Serialize(w, l);
        }

        private List<Alumno> LeerTxt(string ruta)
        {
            var l = new List<Alumno>();
            foreach (var line in File.ReadAllLines(ruta))
            {
                var d = line.Split('|');
                if (d.Length >= 6) l.Add(new Alumno(d[0], d[1], d[2], d[3], d[4], d[5]));
            }
            return l;
        }
        private List<Alumno> LeerCsv(string ruta)
        {
            var l = new List<Alumno>();
            var lines = File.ReadAllLines(ruta);
            for (int i = 1; i < lines.Length; i++)
            {
                var d = lines[i].Split(',');
                if (d.Length >= 6) l.Add(new Alumno(d[0], d[1], d[2], d[3], d[4], d[5]));
            }
            return l;
        }
        private List<Alumno> LeerJson(string r) => JsonSerializer.Deserialize<List<Alumno>>(File.ReadAllText(r)) ?? new List<Alumno>();

        private List<Alumno> LeerXml(string r)
        {
            XmlSerializer s = new XmlSerializer(typeof(List<Alumno>), new XmlRootAttribute("Alumnos"));
            using (StreamReader sr = new StreamReader(r)) return (List<Alumno>)s.Deserialize(sr);
        }
    }
}