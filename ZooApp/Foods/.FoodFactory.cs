using System;
using System.Text;

namespace ZooApp.Foods {
  public static class FoodFactory {
    public static Food CreateFood(FoodType foodType) {
      switch (foodType) {
        case FoodType.Meat:
          return new Meat(FoodType.Meat, 299.99m);
        case FoodType.Fruits:
          return new Fruits(FoodType.Fruits, 149.99m);
        case FoodType.Grain:
          return new Grain(FoodType.Grain, 49.99m);
        case FoodType.Vegetables:
          return new Vegetables(FoodType.Vegetables, 69.59m);
        default:
          throw new ArgumentException("Unknown FoodType");
      }
    }

    public static string FormatFoodsCost() {
      var formatResult = new StringBuilder("All Foods:\r\n");

      foreach (FoodType foodType in Enum.GetValues(typeof(FoodType))) {
        var food = CreateFood(foodType);
        formatResult.AppendLine($"{food.type} - {food.costPerKg} rub.");
      }

      return formatResult.ToString().TrimEnd();
    }
  }
}
