using Builder.Models;

namespace Builder
{
    /// <summary>
    /// Interface representing the steps to build a ramen bowl.
    /// </summary>
    public interface IRamenBuilder
    {
        // TODO#1: Add methods for the following steps

        /// <summary>
        /// Sets the broth for the ramen.
        /// </summary>
        void SetBroth();

        /// <summary>
        /// Sets the type of noodles for the ramen.
        /// </summary>
        void SetNoodle();

        /// <summary>
        /// Adds toppings to the ramen.
        /// </summary>
        void AddTopping();

        /// <summary>
        /// Adds extra to the ramen.
        /// </summary>
        void AddExtra();

        /// <summary>
        /// Returns the built RamenBowl.
        /// </summary>
        /// <returns>The completed RamenBowl.</returns>
        RamenBowl GetRamen();
    }
}
