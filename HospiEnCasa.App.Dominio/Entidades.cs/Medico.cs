using System;
namespace HospiEnCasa.App.Dominio{
    public class Medico : Persona{
        public int Id{get;set;}
        // Código único del médico
        public string Especialidad{get;set;}
        public string Codigo{get;set;}
        // Registro Unico Nacional del Talento Humano 
        public string RegistroReTHUS{get;set;}
        // Relacion entre Medico y la Historia clínica
        public Historia Historia{get;set;}
        }
}