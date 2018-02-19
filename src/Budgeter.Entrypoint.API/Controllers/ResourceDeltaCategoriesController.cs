using Budgeter.BL.Core;
using Budgeter.BL.Core.GenericResults;
using Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory;
using Budgeter.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Budgeter.Entrypoint.API.Controllers
{
    [Route(ApiConstants.ApiRoot + "resourceDeltaCategories")]
    public class ResourceDeltaCategoriesController : Controller
    {
        private readonly IOperationHandlersFactory _handlersFactory;

        public ResourceDeltaCategoriesController(IOperationHandlersFactory handlersFactory)
        {
            _handlersFactory = handlersFactory;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var handler =
                _handlersFactory.Get<AddResourceDeltaCategoryCommand, AddEntityResult<ResourceDeltaCategory>>();
            handler.Handle(null);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}