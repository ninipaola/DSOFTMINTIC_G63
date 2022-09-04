using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliarDesignado : IRepositorioFamiliarDesignado
    {
        private readonly AppContext _appContext;   /// Solo puedo leer

        public RepositorioFamiliarDesignado(AppContext appContext)
        {
            _appContext = appContext;
        }
        FamiliarDesignado IRepositorioFamiliarDesignado.AddFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
            var familiarAdicionado= _appContext.FamiliaresDesignados.Add(familiarDesignado);
            _appContext.SaveChanges();
            return familiarAdicionado.Entity;
            
        }

        void IRepositorioFamiliarDesignado.DeleteFamiliarDesignado(int idFamiliarDesignado)
        {
            var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
            if (familiarEncontrado==null)
            return;
            _appContext.FamiliaresDesignados.Remove(familiarEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<FamiliarDesignado> IRepositorioFamiliarDesignado.GetAllFamiliaresDesignados()
        {
            return _appContext.FamiliaresDesignados;
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.GetFamiliarDesignado(int idFamiliarDesignado)
        {
             return _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
             
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.UpdateFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
           var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == familiarDesignado.Id);
           if (familiarEncontrado!=null)
           {
            familiarEncontrado.Nombre = familiarDesignado.Nombre;
            familiarEncontrado.Apellidos = familiarDesignado.Apellidos;
            familiarEncontrado.NumeroTelefono = familiarDesignado.NumeroTelefono;
            familiarEncontrado.Genero = familiarDesignado.Genero;
            familiarEncontrado.Parentesco = familiarDesignado.Parentesco;
            familiarEncontrado.Correo = familiarDesignado.Correo;
            
            _appContext.SaveChanges();
            }
            return familiarEncontrado;
        
        }

    }

}