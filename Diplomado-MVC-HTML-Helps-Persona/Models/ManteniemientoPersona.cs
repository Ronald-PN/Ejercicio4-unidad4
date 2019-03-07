using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_HTML_Helps_Persona.Models
{
    public class ManteniemientoPersona
    {

        List<Persona> ListaPersonas = new List<Persona>()
        {
            new Persona() { Codigo = 3,
                            Nombre = "Julian Perez Cuevas",
                            Peso = 87.8f,
                            Trabaja = false,
                            FechaNacimiento = new DateTime(1998,11,15)},
            new Persona() { Codigo =4 ,
                            Nombre = "Alex Arismendi",
                            Peso = 94.7f,
                            Trabaja = true,
                            FechaNacimiento = new DateTime(2001,09,19)},
            new Persona() { Codigo = 5,
                            Nombre = "Pedro Granado",
                            Peso = 84.7f,
                            Trabaja = true,
                            FechaNacimiento = new DateTime(1999,11,30)},

        };
        public Persona Retornar(int cod)
        {
            foreach (var per in ListaPersonas)
                if (per.Codigo == cod)
                    return per;
            return null;

        }
    }
}