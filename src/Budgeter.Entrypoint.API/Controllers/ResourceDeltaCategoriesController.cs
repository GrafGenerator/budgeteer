using Budgeter.DAL.CQRS.Repository;
using Budgeter.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Budgeter.Entrypoint.API.Controllers
{
    [Route(ApiConstants.ApiRoot + "resourceDeltaCategories")]
    public class ResourceDeltaCategoriesController : Controller
    {
        private readonly IRepository<ResourceDelta> _repository;

        public ResourceDeltaCategoriesController(IRepository<ResourceDelta> repository)
        {
            _repository = repository;
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