using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()//solo muestra
        {
            return View();
        }
       
        public ActionResult Create()//muestra 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int idVideo, string Titulo, int Repro, string url)//guarda
        {
            List<SqlParameter>Parametros= new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            Parametros.Add(new SqlParameter("@Titulo",Titulo));
            Parametros.Add(new SqlParameter("@Repro",Repro));
            Parametros.Add(new SqlParameter("@url",url));

            BaseHelper.ejecutarSentencia("sp_Video_Insertar",
                                        CommandType.StoredProcedure,
                                        Parametros);


            //guarda el video 
            return RedirectToAction("Index","Video");
        }
        public ActionResult Delete(int idVideo)//muestra
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int idVideo)//guarda
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("idVideo",@idVideo));
            return View();
        }

        public ActionResult Edit()//muestra
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int idVideo, string Titulo,int Repro,string url)//guarda
        {
            return View();
        }

    }
}
