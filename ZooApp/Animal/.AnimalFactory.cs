using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Foods;

namespace ZooApp.Animals {
  public class AnimalFactory {
    private int _idCounter = 0;
    public List<Animal> animalList = new List<Animal>();

    public void AddAnimal(string name, AnimalType animalType, FoodType foodType, double dailyFood) {
      switch (animalType) {
        case AnimalType.Bird:
          this.animalList.Add(new Bird(_idCounter++, name, animalType, foodType, dailyFood));
          break;
        case AnimalType.Mammal:
          this.animalList.Add(new Mammal(_idCounter++, name, animalType, foodType, dailyFood));
          break;
        case AnimalType.Reptile:
          this.animalList.Add(new Reptile(_idCounter++, name, animalType, foodType, dailyFood));
          break;
        default:
          throw new ArgumentException("Unknown AnimalType");
      }
    }

    public string FormatAnimals() {
      StringBuilder formatResult = new StringBuilder("All Animals:\r\n");
      foreach (var animal in this.animalList) {
        formatResult.AppendLine($"{animal}");
      }
      return formatResult.ToString().TrimEnd();
    }
    private static decimal GetAnimalsDailyCost(Animal animal) {
      return animal.food.costPerKg * (decimal)animal.dailyFood;
    }
    public string FormatAnimalsDailyCost() {
      StringBuilder formatResult = new StringBuilder("Animals daily food cost:\r\n");

      foreach (var animal in this.animalList) {
        var (name, dailyFood) = (animal.name, animal.dailyFood);
        formatResult.AppendLine($"{name}: kg {dailyFood} - {GetAnimalsDailyCost(animal):F2} rub.");
      }

      return formatResult.ToString().TrimEnd();
    }
  }
}