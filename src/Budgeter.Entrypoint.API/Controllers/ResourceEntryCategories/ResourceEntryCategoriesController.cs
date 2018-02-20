using Budgeter.BL.Core;
using Budgeter.BL.Core.GenericResults;
using Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory;
using Budgeter.Domain;
using Budgeter.Entrypoint.API.Controllers.ResourceDeltaCategories.Models;
using Microsoft.AspNetCore.Mvc;

namespace Budgeter.Entrypoint.API.Controllers.ResourceEntryCategories
{
    [Route(ApiConstants.ApiRoot + "resourceEntryCategories")]
    public class ResourceEntryCategoriesController : Controller
    {
        private readonly IOperationHandlersFactory _handlersFactory;

        public ResourceEntryCategoriesController(IOperationHandlersFactory handlersFactory)
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
        public void Post([FromBody] CreateResourceEntryCategoryDto dto)
        {
            var handler =
                _handlersFactory.Get<AddResourceEntryCategoryCommand, AddEntityResult<ResourceEntryCategory>>();
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