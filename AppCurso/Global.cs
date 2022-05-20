using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCurso
{
    internal class Global
    {
        //Defenir las listas con sus valores
        public static List<Modulo> Modulos = new List<Modulo>()
        {
            new Modulo(1,"Conceptos Básicos de las Bases de Datos"),
            new Modulo(2,"Acciones sobre una Base de Datos"),
            new Modulo (3,"Manejo de Tablas Dinámicas"),
            new Modulo (4,"Acciones sobre una Base de Datos")
        };
        public static List<Curso> Cursos = new List<Curso>()
        {
               new Curso(1,"Conceptos básicos de Bases de Datos en Excel"," Gestión de la Información #1",
                "https://goo.gl/Rof9Yf",1),
            new Curso(2,"Ejemplos de Bases de Datos en Excel"," Gestión de la Información #2",
                "https://goo.gl/iUF2rL",1),
             new Curso(3,"¿Que es una Tabla Resumen en Excel y que es una Base de Datos? "," Gestión de la Información #4",
                "https://goo.gl/hj8vYo",1),
            new Curso(4,"¿Cómo ingresar datos en una Base de Datos de Excel?","Gestión de la Información #5",
                 "https://goo.gl/5kEcGd",2),
            new Curso(5,"Aprende a ordenar Bases de Datos en Excel","Gestión de la Información #6",
                 "https://goo.gl/eGZ5j9",2),
            new Curso(6,"¿Cómo crear Tablas Dinámicas en Excel?","Gestión de la Información #11",
                 "https://goo.gl/2npG6Y",3),
            new Curso(7,"Mostrar datos como porcentaje de fila o columna","Gestión de la Información #13",
                 "https://goo.gl/urrrP5",3),
            new Curso(8,"Combinando correspondencia con Word y una base de datos en Excel",
                "Gestión de la Información #15","https://goo.gl/LPM51S",4),
            new Curso(9,"Formato condicional en Excel Parte 1",
                "Gestión de la Información #16","https://goo.gl/fxXnqo",4),
            new Curso(10,"Formato condicional en Excel Parte 2",
                "Gestión de la Información #17","https://goo.gl/1ybnkZ",4),

        };
    }
    //Definir las estructuras, clases
    public class Modulo
    {
        //definir campos
        int id;
        string nombre;
        //Constructor
        public Modulo(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
    public class Curso
    {
        //campos 
        int id;
        string nom_curso;
        string desc;
        string url;
        int idModulo;

        //Controlador
        public Curso(int id, string nom_curso, string desc, string url, int idModulo)
        {
            this.Id = id;
            this.Nom_curso = nom_curso;
            this.Desc = desc;
            this.Url = url;
            this.IdModulo = idModulo;
        }
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Nom_curso { get => nom_curso; set => nom_curso = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Url { get => url; set => url = value; }
        public int IdModulo { get => idModulo; set => idModulo = value; }
    }
}