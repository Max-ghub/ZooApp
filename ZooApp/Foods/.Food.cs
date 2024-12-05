namespace ZooApp.Foods {
  public abstract class Food {
    public FoodType type { get; }
    public decimal costPerKg { get; set; }

    public Food(FoodType type, decimal costPerKg) {
      this.type = type;
      this.costPerKg = costPerKg;
    }

    public override string ToString() {
      return this.type.ToString();
    }
  }
}
