using Builder.Enums;

namespace Builder.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen.
    /// It should have attributes like broth, type of noodle, toppings, and extras.
    /// </summary>
    public class RamenBowl
    {
        // TODO#1: Add properties for each enum in IngredientEnums.cs file
        public BrothType Broth { get; set; }

        public NoodleType Noodle { get; set; }

        public List<Topping> Toppings { get; set; } = new List<Topping>();

        public List<Extra> Extras { get; set; } = new List<Extra>();

        // TODO#2: Return the description of the finished bowl of ramen
        public static string FinishedBowlOfRamen(RamenBowl ramen)
        {
            string description = "This bowl of ramen contains:";

            if (ramen.Broth != 0) // Assuming 0 is the default value for BrothType, you might need to adjust this check based on your actual default value.
            {
                description += $" Broth: {ramen.Broth} \n";
            }

            if (ramen.Noodle != 0) // Assuming 0 is the default value for NoodleType, you might need to adjust this check based on your actual default value.
            {
                description += $" Noodles: {ramen.Noodle}\n";
            }

            if (ramen.Toppings != null && ramen.Toppings.Count > 0)
            {
                description += " Toppings: " + string.Join(", ", ramen.Toppings) + "\n";
            }

            if (ramen.Extras != null && ramen.Extras.Count > 0)
            {
                description += " Extras: " + string.Join(", ", ramen.Extras) + "\n";
            }

            return description;
        }
    }
}
