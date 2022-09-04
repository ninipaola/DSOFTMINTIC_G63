using System;
namespace HospiEnCasa.App.Dominio{
    public class Enfermera : Persona{
        public int Id {get; set;}
        public string TarjetaProfesional{get;set;}
        public int HorasExtra{get;set;}
        // Relacion entre Enfermera y la Historia clínica
        public Historia Historia{get;set;}
        }
}