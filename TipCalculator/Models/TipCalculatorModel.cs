using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please enter a meal cost.")]
        [Range(0.0, Int32.MaxValue, ErrorMessage =
               "Meal cost must be greater than 0.")]
        public decimal? MealCost { get; set; }

        public decimal? CalculateFifteenTip()
        {
            return MealCost * 0.15m;
        }

        public decimal? CalculateTwentyTip()
        {
            return MealCost * 0.20m;
        }

        public decimal? CalculateTwentyFiveTip()
        {
            return MealCost * 0.25m;
        }
    }
}
