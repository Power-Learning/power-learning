using LearningTDD.PokemonTournament.Core;
using NUnit.Framework;

namespace LearningTDD.PokemonTournament.PokemonTournamentTests
{
    public class ShouldPokemonTournament
    {
        /*
         * Las combinaciones que debes tener en cuenta son:
            Pokemón Fuego gana sobre Pokemón Acero
            Pokemón Acero gana sobre Pokemón Hielo
            Pokemón Hielo gana sobre Pokemón Tierra
            Pokemón Tierra gana sobre Pokemón Acero
            Pokemón Agua gana sobre Pokemón Fuego
     */
        /*
            Iteración I:
            * Hacer una función que devuelva un tipo de Pokemón de nuestro rival, y, por consiguiente, nuestro 
            jugador debe invocar el Pokemón adecuado para ganar la batalla según indica la tabla.
         */
        /*
            Una vez invocado el Pokemón de nuestro jugador, debemos mandar la lista de comandos al 
            Pokemón para que ataque. 
            Por cada ataque realizado, se debe imprimir en consola el ataque realizado de nuestro Pokemón.
            Nuestro Pokemon cuenta con una barra imaginaria de MP, que tiene un total de 100 puntos. Por 
            cada ataque que realicemos, el MP es consumido de la siguiente manera: 
            Ataque mágico – 30
            Ataque físico – 10
            Si el MP está en cero, y aún quedan ataques por ejecutar, se debe cortar nuestra ejecución de 
            comandos y debe devolver un print con el siguiente mensaje: “MP insuficiente”
            El MP no puede tener un valor negativo (ej: -1
         */

        /*
         * Bonus track:
            Nuestro Pokemón cuenta con una barra de MP (UI), que se consume según los ataques que 
            elijamos, teniendo en cuenta los valores mencionados en el punto anterior.
            La barra no puede tener un valor negativo.
        */

        private Pokemon _pokemon;

        [SetUp]
        public void SetUp()
        {
            _pokemon = new Pokemon();
        }

        [Test]
        public void ShouldEnemyCreateAPokemonAndShouldPlayerCreateTheCorrectOneToWinTheBattle()
        {
            // Given
            var enemyPokemon = _pokemon.Create(Pokemon.PokemonClasses.PokemonFuego);
        
            // When
            var playerPokemon = _pokemon.Create(Pokemon.PokemonClasses.PokemonAgua);

            // Assert
            Assert.AreEqual(enemyPokemon.weaknessPokemon, playerPokemon.selectedPokemon);
        }

        [TestCase( new[]{'M', 'M', 'F','M', 'M', 'F'})]
        [Test]
        public void ShouldSendAttacksCommandsListWhenPokemonPlayerIsCreatedAndShouldConsumeMpButMpShouldNotNegativeNumber(char[] commands)
        {
            // When
            _pokemon.Attack(commands);
        
            // Assert
            Assert.AreEqual(0, _pokemon.CurrentMP);
            Assert.IsFalse(_pokemon.isAttacking);
        }
    }
}