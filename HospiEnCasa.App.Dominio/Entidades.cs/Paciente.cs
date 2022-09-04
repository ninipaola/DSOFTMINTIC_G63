using System;
namespace HospiEnCasa.App.Dominio{
    public class Paciente : Persona{
        public int Id{get;set;}
        public string Direccion { get; set; }
        // Coordenada de la dirección del Paciente
        public float Latitud{get;set;}
        // Coordenada de la dirección del Paciente
        public float Longitud{get;set;}
        public string Ciudad{get;set;}
        public DateTime FechaNacimiento{get;set;}   
        // Relacion entre Paciente y su FamiliarDesignado para cuidarlo     
        public FamiliarDesignado FamiliarDesignado {get;set;}
        public Enfermera Enfermera{get;set;}
        public Medico Medico{get;set;}
        // Relacion entre Paciente y su Historia clínica
        public Historia Historia{get;set;}
        /// <summary>
        ///  Referencia a la lista de signos vitales de un Paciente 
        /// </summary>
        /// <value></value>
        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
        
    }

}