using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logic;
using DataAccess.DTO;

namespace XboxGamepass_API_SOA
{
    /// <summary>
    /// Summary description for API_MostrarServicioPXG
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class API_MostrarServicioPXG : System.Web.Services.WebService
    {
        LogicIntegrationService _context = new LogicIntegrationService();

        [WebMethod]
        public LogicDataService mostrarServicio()
        {
            return _context.mostrarServicio();
        }

        [WebMethod]
        public List<MostrarPagosPXG> mostrarPagosPXG(string cedula)
        {
            return _context.mostrarPagosPXG(cedula);
        }

        [WebMethod]
        public bool actualizarEstado(string codPago)
        {
            return _context.actualizarEstado(codPago);
        }

    }
}
