using ZooApp.Foods;

namespace ZooApp.Animals {
  public abstract class Animal {
    public int id { get; set; }
    public string name { get; set; }
    public AnimalType animalType { get; set; }
    public Food food { get; set; }
    public double dailyFood { get; set; }

    protected Animal(int id, string name, AnimalType animalType, FoodType foodType, double dailyFood) {
      this.id = id;
      this.name = name;
      this.animalType = animalType;
      this.food = FoodFactory.CreateFood(foodType);
      this.dailyFood = dailyFood;
    }

    public override string ToString() {
      return $"Id: {id}, name: {name}, type: {animalType}, food: {food}, dailyFood: {dailyFood} kg";
    }
  }
}
