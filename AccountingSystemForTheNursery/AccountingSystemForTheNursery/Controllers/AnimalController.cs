using AccountingSystemForTheNursery.Models;
using AccountingSystemForTheNursery.Models.Requests;
using AccountingSystemForTheNursery.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AccountingSystemForTheNursery.Services.Impl;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

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
            Animal animal = new Animal();
            animal.AnimalName = createAnimalRequest.AnimalName;
            animal.AnimalClass = createAnimalRequest.AnimalClass;
            animal.ListOfAnimalCommands = createAnimalRequest.ListOfAnimalCommands;
            int res = _animalRepository.Create(animal);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] 
                                     UpdateAnimalRequest updateAnimalRequest)
        {
            Animal animal = new Animal();
            animal.AnimalId = updateAnimalRequest.AnimalId;
            animal.AnimalName = updateAnimalRequest.AnimalName;
            animal.AnimalClass = updateAnimalRequest.AnimalClass;
            animal.ListOfAnimalCommands = updateAnimalRequest.ListOfAnimalCommands;
            int res = _animalRepository.Update(animal);
            return Ok(res);
        }

        [HttpDelete("delete")]
        public ActionResult<int> Delete([FromQuery] int animalId)
        {
            int res = _animalRepository.Delete(animalId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public ActionResult<IList<Animal>> GetAll()
        {
            IList<Animal> animals = _animalRepository.GetAll();
            return Ok(animals);
        }

        [HttpGet("get-by-id/{animalId}")]
        public ActionResult<Animal> GetById([FromRoute] int animalId)
        {
            Animal animal = _animalRepository.GetById(animalId);
            return Ok(animal);
        }
    }
}
