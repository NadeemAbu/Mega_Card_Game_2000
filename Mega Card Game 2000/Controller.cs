using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Card_Game_2000
{
    class Controller
    {
        private EnemyDeck deck;
        private Character enemy;
        private PlayerCharacter player;
        private Character winner;
        private Battle battle;

        public Controller(Battle pBattle, string pClassName)
        {
            chooseClass(pClassName);
            battle = pBattle;
        }

        public void checkForWinner()
        {
            if (player.HealthPoints >= 0)
            {

            }
            else if (enemy.HealthPoints >= 0)
            {

            }
            else if (enemy.HealthPoints >=0 && player.HealthPoints >=0)
            {

            }
            return;
        }

        public PlayerCharacter chooseClass (string pClassName)
        {
            PlayerDeck playerDeck = new PlayerDeck();
            switch (pClassName)
            {
                case "Warrior":
                    player = playerDeck.getWarrior();
                    break;
                case "Thief":
                    player = playerDeck.getThief();
                    break;
                case "Mage":
                    player = playerDeck.getMage();
                    break;
            }
            return player;
        }

        public void enemyTurn()
        {
            performAttack("Normal Attack");
            player.takeDamage(player.AttackBaseDamage);
            checkForWinner();
            updatePlayerHealth();
            return;
        }

        public void performAttack(string pAttackType)
        {
            switch (pAttackType)
            {
                case "Special Attack":
                    player.performSpecialAttack();
                    break;
                
            }
            
            return;
        }

        public void playerTurn ()
        {
            player.performAttack();
            enemy.takeDamage(enemy.AttackBaseDamage);
            checkForWinner();
            updatePlayerHealth();

            return;
        }

        public void startBattle ()
        {
            playerTurn();
            return;
        }

        public void updateBattleOutcome()
        {

            return;
        }

        public void updateEnemyHealth()
        {
            battle.NPCHealth.Content = enemy.HealthPoints;
            return;
        }

        public void updatePlayerHealth()
        {
            battle.PlayerHealth.Content = player.HealthPoints;
            return;
        }
    }
}
