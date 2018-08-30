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
    public class LogsController : ApiController
    {
        private CentralDepKeyStageEntities db = new CentralDepKeyStageEntities();
        [HttpPost]
        public HttpResponseMessage SelectLog(LogParams obj,int pageNumber = 1,int pageSize = 10)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var logs = db.LogSelect(pageNumber, pageSize,obj.DateFrom,obj.DateTo,obj.Action,obj.RelatedID,obj.StaffID,obj.Type,obj.TicketNumber);
                return Request.CreateResponse(HttpStatusCode.OK, logs);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage InsertLog(LogParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var log = db.LogInsert(obj.Details,obj.Action,obj.RelatedID,obj.RelatedID,obj.Type);
                return Request.CreateResponse(HttpStatusCode.OK, log);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
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