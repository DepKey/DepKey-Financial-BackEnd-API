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
    public class BranchesController : ApiController
    {
        private CentralDepKeyStageEntities db = new CentralDepKeyStageEntities();
        [HttpPost]
        public HttpResponseMessage SelectBranch(BranchParams obj,int pageNumber = 1,int pageSize = 10)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var branches = db.BranchSelect(obj.ID,obj.Name,obj.IsDeleted,pageNumber,pageSize);
                return Request.CreateResponse(HttpStatusCode.OK, branches);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage InsertBranch(BranchParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var branch = db.BranchInsert(obj.Name,obj.Telephone,obj.Address);
                return Request.CreateResponse(HttpStatusCode.OK, branch);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage UpdateBranch(BranchParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var branch = db.BranchUpdate(obj.ID,obj.Name, obj.Telephone, obj.Address);
                return Request.CreateResponse(HttpStatusCode.OK, branch);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage DeleteBranch(BranchParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var branch = db.BranchDelete(obj.ID);
                return Request.CreateResponse(HttpStatusCode.OK, branch);
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