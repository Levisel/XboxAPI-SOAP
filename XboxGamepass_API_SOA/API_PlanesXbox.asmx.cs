﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataAccess;
using Logic;

namespace XboxGamepass_API_SOA
{
    /// <summary>
    /// Summary description for API_PlanesXbox
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class API_PlanesXbox : System.Web.Services.WebService
    {
        LogicPlan logic = new LogicPlan();

        #region Métodos de Inserción/Actualización/Eliminación

        [WebMethod]
        public void Insertar(Plan plan)
        {
            logic.Insertar(plan);
        }
        [WebMethod]
        public void Actualizar(Plan plan)
        {
            logic.Actualizar(plan);
        }
        [WebMethod]
        public void Eliminar(int id)
        {
            logic.Eliminar(id);
        }
  
        #endregion

        #region Métodos de Seleccion/Lectura

        [WebMethod]
        public List<Plan> Listar()
        {
            return logic.Listar();
        }
        [WebMethod]
        public Plan buscarPorId(int id)
        {
            return logic.buscarPorId(id);
        }
        #endregion


    }
}