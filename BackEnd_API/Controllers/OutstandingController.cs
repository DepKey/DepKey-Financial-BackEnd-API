using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BackEnd_API;
using Newtonsoft.Json;
using BackEnd_API.Models.SearchParams;
namespace BackEnd_API.Controllers
{
    public class DashboardController : ApiController
    {
        private CentralDepKeyStageEntities db = new CentralDepKeyStageEntities();
        [HttpPost]
        public HttpResponseMessage DashboardGetProfit()
        {
            try
            {
                var Dashboard = db.DashboardGetProfit();
                return Request.CreateResponse(HttpStatusCode.OK, Dashboard);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}