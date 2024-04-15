namespace DefaultNamespace;

[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
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
}