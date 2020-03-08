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
            ViewData["DataVideo"] = BaseHelper.ejecutarConsulta("select* from video", CommandType.Text);
            return View();
        }
       
        public ActionResult Create()//muestra 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int reproducciones, string url)//guarda
        {
            List<SqlParameter>Parametros= new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            Parametros.Add(new SqlParameter("@titulo",titulo));
            Parametros.Add(new SqlParameter("@reproducciones",reproducciones));
            Parametros.Add(new SqlParameter("@url",url));

            BaseHelper.ejecutarSentencia("sp_video_insertar",
                                        CommandType.StoredProcedure,
                                        Parametros);
            //lblMensaje.Text = "Registrado correctamente";
            //guarda el video 
            return RedirectToAction("Index","Video");
           
        }
        public ActionResult Delete()//muestra
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int idVideo)//guarda
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo",idVideo));
            BaseHelper.ejecutarSentencia("sp_video_eliminar",
                                        CommandType.StoredProcedure,
                                        Parametros);
            return RedirectToAction("Index","Video");
        }

        public ActionResult Edit()//muestra
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int idVideo, string titulo,int reproducciones,string url)//guarda
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo",idVideo));
            Parametros.Add(new SqlParameter("@titulo",titulo));
            Parametros.Add(new SqlParameter("@reproducciones",reproducciones));
            Parametros.Add(new SqlParameter("@url",url));

            BaseHelper.ejecutarSentencia("sp_video_actualizar",CommandType.StoredProcedure,Parametros);

            return RedirectToAction ("Index","Video");
        }
        public ActionResult Buscar()//muestra
        {
            return View();
        }
         [HttpPost]
        public ActionResult Buscar(int idVideo)//muestra
        {   
            List<SqlParameter>Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo",idVideo));
            BaseHelper.ejecutarConsulta("sp_video_buscar",CommandType.StoredProcedure,Parametros);

            return RedirectToAction("Index","Video");
        }

    }
}
