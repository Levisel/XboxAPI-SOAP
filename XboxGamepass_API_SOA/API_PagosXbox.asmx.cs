using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataAccess;
using Logic;

namespace XboxGamepass_API_SOA
{
    /// <summary>
    /// Summary description for API_PagosXbox
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class API_PagosXbox : System.Web.Services.WebService
    {
        LogicPago logic = new LogicPago();

        #region Métodos de Inserción/Actualización/Eliminación


        [WebMethod]
        public void Insertar(Pago pago)
        {
            logic.Insertar(pago);
        }

        [WebMethod]
        public void Actualizar(Pago pago)
        {
            logic.Actualizar(pago);
        }

        [WebMethod]
        public void Eliminar(int id)
        {
            logic.Eliminar(id);
        }

        #endregion

        #region Métodos de Seleccion/Lectura

        [WebMethod]
        public List<Pago> Listar()
        {
            return logic.Listar();
        }

        [WebMethod]
        public Pago buscarPorId(int id)
        {
            return logic.buscarPorId(id);
        }

        [WebMethod]
        public Pago buscarPorCodigo(string codigo)
        {
            return logic.buscarPorCodigo(codigo);
        }
        #endregion
    }
}
