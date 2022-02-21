using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

namespace Assets.LearningTDD.QuestSystem.QuestSystemTests
{
    public class ShouldQuestSystem
    {
        /*
         * Nuestro jugador debe poder hablar con un NPC y solicitarle una Quest. 
            Se debe validar si nuestro jugador cumple con el requisito requerido de la Quest (nivel), si el 
            jugador cumple con el requisito, la Quest se activa, de lo contrario, le notifica que no cumple con 
            los requerimientos necesarios
            Una vez que pide la Quest y es activada, no se debe poder pedir por segunda vez.
         */
        
        /*
         * Se deben modelar los Jobs de tal manera que sean adaptables a modificaciones de ordenamiento 
            para cualquier tipo de Quest
         */

        private Quest _quest;
        private Player _player;

        [SetUp]
        public void SetUp()
        {
            _quest = new Quest();
            _player = new Player();

            _quest.questName = "Kill all zombies!";
            _quest.questLevel = 20;
            _quest.questReward = "Sword";

            //_playerQuest.Quests.Add(_quest);
        }

        [Test]
        public void
            Should_Player_Request_Quest_To_Npc_And_Should_Check_IfP_layer_Have_The_Requeriments_And_Once_Requested_Should_Not_Be_Able_To_Request_Again()
        {
            // When
            _quest.GetQuest(_player);

            // Assert
            Assert.AreEqual(_quest.questLevel, _player.playerLevel);
            Assert.AreNotEqual(_quest.questName, "K");
        }
    }

    public class Player : IQuest
    {
        private List<Quest> _quests = new List<Quest>();
        public int playerLevel = 20;
        
        public void AddQuest(Quest quest)
        {
            _quests.Add(quest);
            Debug.Log($"New quest added to player {quest.questName}");
        }

        public IEnumerable<Quest> GetQuestList()
        {
            return _quests;
        }
    }

    public interface IQuest
    {
        void AddQuest(Quest quest);
        IEnumerable<Quest> GetQuestList();
    }

    public class Quest
    {
        public string questName;
        public int questLevel;
        public string questReward;
        public bool isActive;

        public void GetQuest(IQuest playerQuest)
        {
            if (!CanTakeQuest(playerQuest)) return;

            isActive = true;
            playerQuest.AddQuest(this);
        }

        private bool CanTakeQuest(IQuest iQuest)
        {
            foreach (var quest in iQuest.GetQuestList())
            {
                if (quest.questName == questName)
                {
                    Debug.Log("You have this quest in progress!");
                    return false;
                }

                if (quest.questLevel < questLevel)
                {
                    Debug.Log("You don't have enough level for this Quest!");
                    return false;
                }
            }

            return true;
        }
    }
}