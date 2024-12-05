using ZooApp.Foods;

namespace ZooApp.Animals {
  public class Bird : Animal {
    public Bird(
      int id,
      string name,
      AnimalType animalType,
      FoodType foodType,
      double dailyFood
    ) : base(id, name, animalType, foodType, dailyFood) { }
  }
}
