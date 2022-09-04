using System;
namespace HospiEnCasa.App.Dominio{
    public class Historia {
        // Identificador único de la Historia
        public int Id{get;set;}
        public string Diagnostico{get;set;}
        // Descripción de la casa y habitación del Paciente
        public string SitioHospitalizacion{get;set;}
        // Referencia la lista de sugerencias registradas en la Historia del Paciente
        public List<SugerenciaCuidado> Sugerencias{get; set; }
                                
        }
}