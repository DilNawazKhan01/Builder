using Builder.Enums;
using Builder.Models;

namespace Builder.Builders
{
    internal class SpicyRamenBuilder : Builder.IRamenBuilder
    {
        private readonly RamenBowl ramen;

        public SpicyRamenBuilder()
        {
            ramen = new RamenBowl();
        }

        public void SetBroth()
        {
            ramen.Broth = BrothType.SpicyTonkotsu;
        }

        public void SetNoodle()
        {
            ramen.Noodle = NoodleType.Thin; 
        }

        public void AddTopping()
        {
            ramen.Toppings.Add(Topping.ChashuPork);
            ramen.Toppings.Add(Topping.GreenOnions);
        }

        public void AddExtra()
        {
            ramen.Extras.Add(Extra.ExtraSpice);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
