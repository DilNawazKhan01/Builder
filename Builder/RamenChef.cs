using Builder.Builders;
using Builder.Models;

namespace Builder
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            // TODO#1: Call each builder step declared in IRamenBuilder interface
            builder.SetBroth();
            builder.SetNoodle();
            builder.AddTopping();
            builder.AddExtra();

            // TODO#2: Finally, return the built bowl of ramen
            return builder.GetRamen();
        }
    }
}
