using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSugerenciaCuidado : IRepositorioSugerenciaCuidado
    {
        private readonly AppContext _appContext;   /// Solo puedo leer

        public RepositorioSugerenciaCuidado(AppContext appContext)
        {
            _appContext = appContext;
        }
        SugerenciaCuidado IRepositorioSugerenciaCuidado.AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaCuidadoAdicionada= _appContext.SugerenciasCuidado.Add(sugerenciaCuidado);
            _appContext.SaveChanges();
            return sugerenciaCuidadoAdicionada.Entity;
            
        }

        void IRepositorioSugerenciaCuidado.DeleteSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrada = _appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == idSugerenciaCuidado);
            if (sugerenciaCuidadoEncontrada==null)
            return;
            _appContext.SugerenciasCuidado.Remove(sugerenciaCuidadoEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<SugerenciaCuidado> IRepositorioSugerenciaCuidado.GetAllSugerenciasCuidado()
        {
            return _appContext.SugerenciasCuidado;
        }

        SugerenciaCuidado IRepositorioSugerenciaCuidado.GetSugerenciaCuidado(int idSugerenciaCuidado)
        {
             return _appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == idSugerenciaCuidado);
             
        }

        SugerenciaCuidado IRepositorioSugerenciaCuidado.UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
           var sugerenciaEncontrada = _appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == sugerenciaCuidado.Id);
           if (sugerenciaEncontrada!=null)
           {
            sugerenciaEncontrada.FechaHora = sugerenciaCuidado.FechaHora;
            sugerenciaEncontrada.Descripcion = sugerenciaCuidado.Descripcion;
            
            _appContext.SaveChanges();
            }
            return sugerenciaEncontrada;
        
        }

    }

}