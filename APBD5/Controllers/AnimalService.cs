namespace DefaultNamespace;

public class AnimalService
{
    private List<Animal> _animals;

    public AnimalService()
    {
        _animals = new List<Animal>
        {
            new Animal { Id = 1, Name = "Max", Category = "Dog", Weight = 10.5, FurColor = "Brown" },
            new Animal { Id = 2, Name = "Fluffy", Category = "Cat", Weight = 5.2, FurColor = "White" },
            new Animal { Id = 3, Name = "Charlie", Category = "Bird", Weight = 0.3, FurColor = "Red" }
        };
    }

    public IEnumerable<Animal> GetAllAnimals()
    {
        return _animals;
    }

    public Animal GetAnimalById(int id)
    {
        return _animals.FirstOrDefault(a => a.Id == id);
    }

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
    }

    public void UpdateAnimal(Animal updatedAnimal)
    {
        var existingAnimal = _animals.FirstOrDefault(a => a.Id == updatedAnimal.Id);
        if (existingAnimal != null)
        {
            existingAnimal.Name = updatedAnimal.Name;
            existingAnimal.Category = updatedAnimal.Category;
            existingAnimal.Weight = updatedAnimal.Weight;
            existingAnimal.FurColor = updatedAnimal.FurColor;
        }
    }

    public void DeleteAnimal(int id)
    {
        var animalToRemove = _animals.FirstOrDefault(a => a.Id == id);
        if (animalToRemove != null)
        {
            _animals.Remove(animalToRemove);
        }
    }
}