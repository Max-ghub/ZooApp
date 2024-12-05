using System;
using ZooApp.Animals;
using ZooApp.Foods;

namespace ZooApp {
  internal static class Program {
    static void Main() {
      var animalFactory = new AnimalFactory();

      animalFactory.AddAnimal("Parrot", AnimalType.Bird, FoodType.Grain, 1.2);
      animalFactory.AddAnimal("Hawk", AnimalType.Bird, FoodType.Meat, 1.5);
      animalFactory.AddAnimal("Penguin", AnimalType.Bird, FoodType.Meat, 2);

      animalFactory.AddAnimal("Dog", AnimalType.Mammal, FoodType.Meat, 0.8);
      animalFactory.AddAnimal("Horse", AnimalType.Mammal, FoodType.Grain, 10);
      animalFactory.AddAnimal("Gorilla", AnimalType.Mammal, FoodType.Fruits, 5);
      animalFactory.AddAnimal("Rabbit", AnimalType.Mammal, FoodType.Vegetables, 0.5);
      animalFactory.AddAnimal("Bear", AnimalType.Mammal, FoodType.Fruits, 8);

      animalFactory.AddAnimal("Alligator", AnimalType.Reptile, FoodType.Meat, 3);
      animalFactory.AddAnimal("Turtle", AnimalType.Reptile, FoodType.Vegetables, 0.3);
      animalFactory.AddAnimal("Chameleon", AnimalType.Reptile, FoodType.Meat, 0.05);
      animalFactory.AddAnimal("Crocodile", AnimalType.Reptile, FoodType.Meat, 5);
      animalFactory.AddAnimal("Lizard", AnimalType.Reptile, FoodType.Fruits, 0.2);

      Console.WriteLine(animalFactory.FormatAnimals());
      Console.WriteLine();
      Console.WriteLine(animalFactory.FormatAnimalsDailyCost());
      Console.WriteLine();
      Console.WriteLine(FoodFactory.FormatFoodsCost());
    }
  }
}
