using ZooApp.Foods;

namespace ZooApp.Animals {
  public class Mammal : Animal {
    public Mammal(int id, 
      string name, 
      AnimalType animalType, 
      FoodType foodType, 
      double dailyFood
    ) : base(id, name, animalType, foodType, dailyFood) { }
  }
}
