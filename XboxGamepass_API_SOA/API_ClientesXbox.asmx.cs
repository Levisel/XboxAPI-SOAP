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
    /// Summary description for API_XboxGamepass
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class API_XboxGamepass : System.Web.Services.WebService
    {
        LogicCliente logic = new LogicCliente();

        #region Métodos de Inserción/Actualización/Eliminación


        [WebMethod]
        public void Insertar(Cliente cliente)
        {
            logic.Insertar(cliente);
        }

        [WebMethod]
        public void Actualizar(Cliente cliente)
        {
            logic.Actualizar(cliente);
        }

        [WebMethod]
        public void Eliminar(string cedula)
        {
            logic.Eliminar(cedula);
        }

        #endregion

        #region Métodos de Seleccion/Lectura

        [WebMethod]
        public List<Cliente> Listar()
        {
            return logic.Listar();
        }
        [WebMethod]
        public Cliente buscarPorId(string id)
        {
            return logic.buscarPorId(id);
        }

        #endregion
    }
}
