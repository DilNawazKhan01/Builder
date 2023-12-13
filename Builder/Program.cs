using Builder.Builders;
using Builder.Models;


namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO#1: Wake up your RamenChef by initializing it
            RamenChef chef = new RamenChef();

            // TODO#2: Create new RamenBuilder's for each ramen recipe (MisoRamenBuilder, SpicyRamenBuilder, VeganRamenBuilder)
            IRamenBuilder misoRamenBuilder = new MisoRamenBuilder();
            IRamenBuilder spicyRamenBuilder = new SpicyRamenBuilder();
            IRamenBuilder veganRamenBuilder = new VeganRamenBuilder();

            // TODO#3: Use your RamenChef to prepare (build) each type of ramen (Miso, Spicy, Vegan)
            RamenBowl misoRamen = chef.PrepareRamen(misoRamenBuilder);
            RamenBowl veganRamen = chef.PrepareRamen(veganRamenBuilder);
            RamenBowl spicyRamen = chef.PrepareRamen(spicyRamenBuilder);

            // TODO#4: After the RamenChef has prepared the bowl of ramen, use FinishedBowlOfRamen to get the content of
            // the RamenBowl and print it out using WriteLine method
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(misoRamen));
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(veganRamen));
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(spicyRamen));
        }
    }
}
