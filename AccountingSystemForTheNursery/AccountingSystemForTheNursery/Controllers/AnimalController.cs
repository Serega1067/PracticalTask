using AccountingSystemForTheNursery.Models;
using AccountingSystemForTheNursery.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AccountingSystemForTheNursery.Services.Impl;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using AccountingSystemForTheNursery.Models.Animals;
using AccountingSystemForTheNursery.Models.Requests;

namespace AccountingSystemForTheNursery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private IAnimalRepository _animalRepository;

        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        [HttpPost("create")]
        public ActionResult<int> Create([FromBody] 
                                         CreateAnimalRequest createAnimalRequest)
        {
            Animal animal = CreateAnimal.create(createAnimalRequest.Type);
            // Animal animal = new Animal();
            animal.Name = createAnimalRequest.Name;
            // animal.Type = createAnimalRequest.Type;
            animal.Commands = createAnimalRequest.Commands.Split(", ").ToList();
            animal.Birthday = createAnimalRequest.Birthday;
            int res = _animalRepository.Create(animal);
            return Ok(res);
        }

        [HttpPut("update")]
        public ActionResult<int> Update([FromBody] 
                                     UpdateAnimalRequest updateAnimalRequest)
        {
            Animal animal = CreateAnimal.create(updateAnimalRequest.Type);
            // Animal animal = new Animal();
            animal.Id = updateAnimalRequest.Id;
            animal.Name = updateAnimalRequest.Name;
            // animal.Type = updateAnimalRequest.Type;
            animal.Commands = updateAnimalRequest.Commands.Split(", ").ToList();
            animal.Birthday = updateAnimalRequest.Birthday;
            int res = _animalRepository.Update(animal);
            return Ok(res);
        }

        [HttpDelete("delete")]
        public ActionResult<int> Delete([FromQuery] int id)
        {
            int res = _animalRepository.Delete(id);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public ActionResult<List<Animal>> GetAll()
        {
            // IList<Animal> animals = _animalRepository.GetAll();
            return Ok(_animalRepository.GetAll());
        }

        [HttpGet("get-by-id/{id}")]
        public ActionResult<Animal> GetById([FromRoute] int id)
        {
            Animal animal = _animalRepository.GetById(id);
            return Ok(animal);
        }
    }
}
