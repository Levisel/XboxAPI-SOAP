using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logic;
using DataAccess;
using System.Web.UI.WebControls;

namespace XboxGamepass_API_SOA
{
    /// <summary>
    /// Summary description for API_StoredProceduresXbox
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class API_StoredProceduresXbox : System.Web.Services.WebService
    {

        LogicSPClientesConSuscripcionActivaInactiva logicSPClientesConSuscripcionActivaInactiva = new LogicSPClientesConSuscripcionActivaInactiva();
        LogicSPObtenerClientesConRenovacionAutomatica logicSPObtenerClientesConRenovacionAutomatica = new LogicSPObtenerClientesConRenovacionAutomatica();
        LogicSPObtenerClientesPorPaisYPlan logicSPObtenerClientesPorPaisYPlan = new LogicSPObtenerClientesPorPaisYPlan();
        LogicSPObtenerClientesPorPlataforma logicSPObtenerClientesPorPlataforma = new LogicSPObtenerClientesPorPlataforma();
        LogicSPObtenerNumeroClientesPorPais logicSPObtenerNumeroClientesPorPais = new LogicSPObtenerNumeroClientesPorPais();    
        LogicSPObtenerPagosPorPlan logicSPObtenerPagosPorPlan = new LogicSPObtenerPagosPorPlan();

        [WebMethod]
        public List<SPClientesConSuscripcionActivaInactiva_Result> ListarClientesConSuscripcionActivaInactiva()
        {
            return logicSPClientesConSuscripcionActivaInactiva.Listar();
        }

        [WebMethod]
        public List<SPObtenerClientesConRenovacionAutomatica_Result> ListarClientesConRenovacionAutomatica()
        {
            return logicSPObtenerClientesConRenovacionAutomatica.Listar();
        }

        [WebMethod]
        public List<SPObtenerClientesPorPaisYPlan_Result> ListarClientesPorPaisYPlan()
        {
            return logicSPObtenerClientesPorPaisYPlan.Listar();
        }

        [WebMethod]
        public List<SPObtenerClientesPorPlataforma_Result> ListarClientesPorPlataforma()
        {
            return logicSPObtenerClientesPorPlataforma.Listar();
        }

        [WebMethod]
        public List<SPObtenerNumeroClientesPorPais_Result> ListarNumeroClientesPorPais()
        {
            return logicSPObtenerNumeroClientesPorPais.Listar();
        }

        [WebMethod]
        public SPObtenerPagosPorPlan_Result buscarPorId(string nombrePlan)
        {
            return logicSPObtenerPagosPorPlan.buscarPorId(nombrePlan);
        }



    }
}
