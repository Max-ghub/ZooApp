using ZooApp.Foods;

namespace ZooApp.Animals {
  public class Reptile : Animal {
    public Reptile(int id, 
      string name, 
      AnimalType animalType, 
      FoodType foodType, 
      double dailyFood
    ) : base(id, name, animalType, foodType, dailyFood) { }
  }
}
