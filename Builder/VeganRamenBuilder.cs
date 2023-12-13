using Builder.Enums;
using Builder.Models;

namespace Builder.Builders
{
    internal class VeganRamenBuilder : IRamenBuilder
    {
        private readonly RamenBowl ramen;

        public VeganRamenBuilder()
        {
            ramen = new RamenBowl();
        }

        public void SetBroth()
        {
            ramen.Broth = BrothType.Vegan;
        }

        public void SetNoodle()
        {
            ramen.Noodle = NoodleType.Soba;
        }

        public void AddTopping()
        {
            ramen.Toppings.Add(Topping.BambooShoots);
            ramen.Toppings.Add(Topping.Seaweed);
        }

        public void AddExtra()
        {
            ramen.Extras = null;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
