using ExternalLibrary;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIpoc2.IoC;
using WebAPIpoc2.Models;

namespace WebAPIpoc2.Controllers
{
    public class NormalController : ApiController
    {
        //Here we can inject
        private ILoggingComponent _loggingComponent = Container.GetContainer().Resolve<ILoggingComponent>();

        // GET: api/Normal
        public IEnumerable<string> Get()
        {
            #region Option 1 - Injecting a Logger
            _loggingComponent.LogBeginCall();

            var result = ExampleModel.GetResult();

            _loggingComponent.LogEndCall();
            #endregion

            #region Option 2 - Generics
            //var result = _loggingComponent.Logger<string>(ExampleModel.GetResult);
            #endregion

            

            return result;
        }

        // GET: api/Normal/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Normal
        public void Post([FromBody]string value)
        {            
        }

        // PUT: api/Normal/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Normal/5
        public void Delete(int id)
        {
        }
    }
}
