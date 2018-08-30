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
    public class LookupTypesController : ApiController
    {
        private CentralDepKeyStageEntities db = new CentralDepKeyStageEntities();
        


        [HttpPost]
        public HttpResponseMessage SelectLookupType(LookupTypeParams obj,int pageNumber = 1,int pageSize = 10)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var lookups = db.LookupTypeSelect(obj.ID == 0 ? null : (int?)obj.ID, obj.Title, obj.IsDeleted, pageNumber, pageSize);
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
        public HttpResponseMessage InsertLookupType(LookupTypeParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var lookups = db.LookupTypeInsert(obj.Title);
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
        public HttpResponseMessage UpdateLookupType(LookupTypeParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var lookups = db.LookupTypeUpdate(obj.ID,obj.Title);
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
        public HttpResponseMessage DeleteLookupType(LookupTypeParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var lookups = db.LookupTypeDelete(obj.ID);
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

        private bool LookupTypeExists(int id)
        {
            return db.LookupTypes.Count(e => e.ID == id) > 0;
        }
    }
}