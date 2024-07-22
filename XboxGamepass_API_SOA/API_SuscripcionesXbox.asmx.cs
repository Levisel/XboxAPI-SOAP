using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logic;
using DataAccess;

namespace XboxGamepass_API_SOA
{
    /// <summary>
    /// Summary description for API_SuscripcionesXbox
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class API_SuscripcionesXbox : System.Web.Services.WebService
    {
        LogicSuscripcion logic = new LogicSuscripcion();

        #region Métodos de Inserción/Actualización/Eliminación

        [WebMethod]
        public void Insertar(Suscripcion suscripcion)
        {
            logic.Insertar(suscripcion);
        }
        [WebMethod]
        public void Actualizar(Suscripcion suscripcion)
        {
            logic.Actualizar(suscripcion);
        }
        [WebMethod]
        public void Eliminar(string id)
        {
            logic.Eliminar(id);
        }
        #endregion

        #region Métodos de Seleccion/Lectura
        [WebMethod]
        public List<Suscripcion> Listar()
        {
            return logic.Listar();
        }
        [WebMethod]
        public Suscripcion buscarPorId(string id)
        {
            return logic.buscarPorId(id);
        }
        #endregion

    }
}
