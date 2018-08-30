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
    public class NotificationsController : ApiController
    {
        private CentralDepKeyStageEntities db = new CentralDepKeyStageEntities();
        [HttpPost]
        public HttpResponseMessage SelectNotification(NotificationParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var Notifications = db.NotificationSelect(obj.RelatedID, obj.IsSeen);
                return Request.CreateResponse(HttpStatusCode.OK, Notifications);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage InsertNotification(NotificationParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var Notification = db.NotificationInsert(obj.Description, obj.RelatedID);
                return Request.CreateResponse(HttpStatusCode.OK, Notification);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage UpdateNotification(NotificationParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var Notification = db.NotificationUpdate(obj.RelatedID);
                return Request.CreateResponse(HttpStatusCode.OK, Notification);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            ThrowBadRequest:
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
        [HttpPost]
        public HttpResponseMessage CountNotification(NotificationParams obj)
        {
            try
            {
                if (obj == null)
                    goto ThrowBadRequest;

                var Notification = db.NotificationNotSeenCount();
                return Request.CreateResponse(HttpStatusCode.OK, Notification);
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