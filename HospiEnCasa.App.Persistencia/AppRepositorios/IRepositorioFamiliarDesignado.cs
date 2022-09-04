using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia{
    public  interface IRepositorioFamiliarDesignado{
        IEnumerable<FamiliarDesignado> GetAllFamiliaresDesignados();
        FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado familiarDesignado);
        FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado familiarDesignado);
        void DeleteFamiliarDesignado(int idFamiliarDesignado);
        FamiliarDesignado GetFamiliarDesignado(int idFamiliarDesignado);
      
    }
}