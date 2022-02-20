using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LearningTDD.PokemonTournament.Core
{
    public class Pokemon
    {
        private const int MAX_MP_VALUE = 100;
        private const int MIN_MP_VALUE = 0;
        public int CurrentMP = MAX_MP_VALUE;

        public bool isAttacking;
        
        public enum PokemonClasses
        {
            PokemonFuego,
            PokemonAcero,
            PokemonHielo,
            PokemonTierra,
            PokemonAgua
        }

        private readonly Dictionary<PokemonClasses, PokemonClasses> _pokemonStatsCombinations;

        public Pokemon()
        {
            _pokemonStatsCombinations = new Dictionary<PokemonClasses, PokemonClasses>()
            {
                {PokemonClasses.PokemonFuego, PokemonClasses.PokemonAcero},
                {PokemonClasses.PokemonAcero, PokemonClasses.PokemonHielo},
                {PokemonClasses.PokemonHielo, PokemonClasses.PokemonTierra},
                {PokemonClasses.PokemonTierra, PokemonClasses.PokemonAcero},
                {PokemonClasses.PokemonAgua, PokemonClasses.PokemonFuego}
            };
        }


        public PokemonModel Create(PokemonClasses pokemon)
        {
            var pokemonModel = new PokemonModel
            {
                selectedPokemon = pokemon.ToString(), 
                weaknessPokemon = GetPokemonWeakness(pokemon)
            };
        
            return pokemonModel;
        }

        private string GetPokemonWeakness(PokemonClasses pokemon)
        {
            var weakness = _pokemonStatsCombinations.FirstOrDefault(p => p.Value == pokemon).Key.ToString();
            return weakness;
        }

        public void Attack(char[] commands)
        {
            int amount = 0;
            foreach (var c in commands)
            {
                if (!CanAttack()) return;
                isAttacking = true;
                    
                if (c == 'M')
                {
                    amount = 30;
                }
                else if (c == 'F')
                {
                    amount = 10;
                }
                
                ConsumeMp(amount);
            }
        }

        private bool CanAttack()
        {
            if (CurrentMP > 0) return true;
            isAttacking = false;
            Debug.Log("MP Insuficiente");
            return false;
        }

        private void ConsumeMp(int amount)
        {
            CurrentMP = Mathf.Max(MIN_MP_VALUE, CurrentMP - amount);
            Debug.Log($"MP {CurrentMP}");
        }
    }
}