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
    public class OutstandingController : ApiController
    {
        private CentralDepKeyStageEntities db = new CentralDepKeyStageEntities();

        [HttpPost]
        public HttpResponseMessage InsertOutstanding(OutstandingParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;
                var Outstanding = db.OutStandingInsert(obj.OsNumber, obj.Amount, obj.StatusID, obj.JournalMovementID);
                return Request.CreateResponse(HttpStatusCode.OK, Outstanding);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        public HttpResponseMessage SelectOutstanding(OutstandingParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var Outstanding = db.OutStandingSelect(obj.AccountID, obj.DateFrom, obj.DateTo);
                return Request.CreateResponse(HttpStatusCode.OK, Outstanding);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        public HttpResponseMessage SelectOutstandingPartial(OutstandingParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var Outstanding = db.OutStandingSelectPartial(obj.JournalMovementID);
                return Request.CreateResponse(HttpStatusCode.OK, Outstanding);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        public HttpResponseMessage OutStandingSelectMaxOsNumber(OutstandingParams obj)
        {
            try
            {
                var Outstanding = db.OutStandingSelectMaxOsNumber();
                return Request.CreateResponse(HttpStatusCode.OK, Outstanding);
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