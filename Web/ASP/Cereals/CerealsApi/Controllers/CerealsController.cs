using CerealsApi.Db;
using CerealsApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CerealsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CerealsController : ControllerBase 
    {
        Repository<Cereal> repository;

        public CerealsController() : base()
        {
            repository = new Repository<Cereal>(new CerealsDbContext());
        }

        // GET: api/<CerealsController>
        [HttpGet]
        public IEnumerable<Cereal> Get()
        {
            return repository.Get();
        }

        // GET api/<CerealsController>/5
        [HttpGet("{id}")]
        public Cereal? Get(int id)
        {
            return repository.Get(id);
        }
        //public Cereal Get(int id) => context.Cereals.Single(c => c.CerealId == id);

        // POST api/<CerealsController>
        [HttpPost]
        public void Post([FromBody] Cereal value)
        {
            repository.Add(value);
        }

        // PUT api/<CerealsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cereal value)
        {
            value.Id = id;
            repository.Update(value);
        }

        // DELETE api/<CerealsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
