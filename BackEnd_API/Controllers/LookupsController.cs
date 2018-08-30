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
    public class LookupsController : ApiController
    {
        private CentralDepKeyStageEntities db = new CentralDepKeyStageEntities();
        


        [HttpPost]
        public HttpResponseMessage SelectLookup(LookupParams obj,int pageNumber = 1,int pageSize = 10)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var lookups = db.LookupSelect(obj.ID,
                    obj.Title,
                    obj.Note,
                    obj.IsDeleted,
                    obj.LookupOrder,
                    obj.LookupTypeID,
                    null,
                    pageNumber,
                    pageSize);
                return Request.CreateResponse(HttpStatusCode.OK, lookups);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage InsertLookup(LookupParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var lookups = db.LookupInsert(obj.Title,obj.Note,obj.LookupOrder,obj.LookupTypeID);
                return Request.CreateResponse(HttpStatusCode.OK, lookups);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage UpdateLookup(LookupParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var lookups = db.LookupUpdate(obj.ID,obj.Title,obj.Note,obj.LookupOrder,obj.LookupTypeID);
                return Request.CreateResponse(HttpStatusCode.OK, lookups);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage DeleteLookup(LookupParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var lookups = db.LookupDelete(obj.ID);
                return Request.CreateResponse(HttpStatusCode.OK, lookups);
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