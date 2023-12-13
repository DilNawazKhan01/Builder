using Builder.Enums;
using Builder.Models;

namespace Builder.Builders
{
    internal class MisoRamenBuilder : IRamenBuilder
    {
        // NOTE: Since in this assignment we are using IRamenBuilder, which is an interface, remember to create the RamenBowl object
        //       inside each ramen type builder class => private RamenBowl ramen = new RamenBowl();
        private readonly RamenBowl ramen;

        public MisoRamenBuilder()
        {
            ramen = new RamenBowl();
        }

        public void SetBroth()
        {
            ramen.Broth = BrothType.Miso;
        }

        public void SetNoodle()
        {
            ramen.Noodle = NoodleType.Udon;
        }

        public void AddTopping()
        {
            ramen.Toppings.Add(Topping.GreenOnions);
        }

        public void AddExtra()
        {
            ramen.Extras.Add(Extra.Corn);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
