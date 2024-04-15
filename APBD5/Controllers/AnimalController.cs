namespace DefaultNamespace;

[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    private readonly AnimalService _animalService;
    public AnimalsController(AnimalService animalService)
    {
        _animalService = animalService;
    }
    
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal animal)
    {
        if (id != animal.Id)
            return BadRequest();

        _animalService.UpdateAnimal(animal);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        _animalService.DeleteAnimal(id);
        return NoContent();
    }
}