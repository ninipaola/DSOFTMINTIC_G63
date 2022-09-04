// See https://aka.ms/new-console-template for more information
using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola{
    class Program{
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
        static void Main (String[]args){
            Console.WriteLine("Hello, World EF!");
            //AddPaciente();
            BuscarPaciente(1);
        }

        private static void AddPaciente(){
            var paciente = new Paciente{
                Nombre = "Jesús",
                Apellidos = "Peña",
                NumeroTelefono = "3225788503",
                Genero= Genero.masculino,
                Direccion = "Turbaco,Calle 13 No 7-4",
                Longitud = 5.07052F,
                Latitud = -75.52225F,
                
                FechaNacimiento = new DateTime(1990, 02, 16)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente){
            var paciente= _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+""+paciente.Apellidos);
        }
    }
}