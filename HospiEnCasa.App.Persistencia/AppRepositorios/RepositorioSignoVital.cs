using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSignoVital : IRepositorioSignoVital
    {
        private readonly AppContext _appContext;   /// Solo puedo leer

        public RepositorioSignoVital(AppContext appContext)
        {
            _appContext = appContext;
        }
        SignoVital IRepositorioSignoVital.AddSignoVital(SignoVital signoVital)
        {
            var signoAdicionado= _appContext.SignosVitales.Add(signoVital);
            _appContext.SaveChanges();
            return signoAdicionado.Entity;
            
        }

        void IRepositorioSignoVital.DeleteSignoVital(int idSignoVital)
        {
            var signoEncontrado = _appContext.SignosVitales.FirstOrDefault(p => p.Id == idSignoVital);
            if (signoEncontrado==null)
            return;
            _appContext.SignosVitales.Remove(signoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<SignoVital> IRepositorioSignoVital.GetAllSignosVitales()
        {
            return _appContext.SignosVitales;
        }

        SignoVital IRepositorioSignoVital.GetSignoVital(int idSignoVital)
        {
             return _appContext.SignosVitales.FirstOrDefault(p => p.Id == idSignoVital);
             
        }

        SignoVital IRepositorioSignoVital.UpdateSignoVital(SignoVital signoVital)
        {
           var signoEncontrado = _appContext.SignosVitales.FirstOrDefault(p => p.Id == signoVital.Id);
           if (signoEncontrado!=null)
           {
            signoEncontrado.FechaHora = signoVital.FechaHora;
            signoEncontrado.Valor = signoVital.Valor;
            signoEncontrado.Signo = signoVital.Signo;
            
            _appContext.SaveChanges();
            }
            return signoEncontrado;
        
        }

    }

}
