using Budgeter.BL.Core.Handlers;
using Budgeter.BL.Core.Handlers.GenericResults;
using Budgeter.BL.Core.Mapping;
using Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory;
using Budgeter.Domain;
using Budgeter.Entrypoint.API.Controllers.ResourceEntryCategories.Models;
using Budgeter.Entrypoint.API.Mapping.ApiToBL;
using Microsoft.AspNetCore.Mvc;

namespace Budgeter.Entrypoint.API.Controllers.ResourceEntryCategories
{
    [Route(ApiConstants.ApiRoot + "resourceEntryCategories")]
    public class ResourceEntryCategoriesController : Controller
    {
        private readonly IOperationHandlersFactory _handlersFactory;
        private readonly IContextualMapper<ApiToBlContext> _mapper;

        public ResourceEntryCategoriesController(IOperationHandlersFactory handlersFactory,
            IContextualMapper<ApiToBlContext> mapper)
        {
            _handlersFactory = handlersFactory;
            _mapper = mapper;
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
            var command = _mapper.Spawn().Map<CreateResourceEntryCategoryDto, AddResourceEntryCategoryCommand>(dto);
            var handler =
                _handlersFactory.Get<AddResourceEntryCategoryCommand, AddEntityResult<ResourceEntryCategory>>();
            handler.Handle(command);
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