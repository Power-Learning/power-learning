using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace LearningTDD.PokemonTournament.PokemonTournamentTests
{
    public class ShouldPokemonTournament
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ShouldPokemonTournamentSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator ShouldPokemonTournamentWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
