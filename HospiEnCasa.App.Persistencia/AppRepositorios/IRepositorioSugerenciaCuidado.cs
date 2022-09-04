using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia{
    public  interface IRepositorioSugerenciaCuidado{
        IEnumerable<SugerenciaCuidado> GetAllSugerenciasCuidado();
        SugerenciaCuidado AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        SugerenciaCuidado UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        void DeleteSugerenciaCuidado(int idSugerenciaCuidado);
        SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado);
        
    }
}