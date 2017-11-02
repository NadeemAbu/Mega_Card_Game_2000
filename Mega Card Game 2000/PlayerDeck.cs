using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Card_Game_2000
{
    class PlayerDeck : PlayerCharacter
    {

        public PlayerCharacter getMage()
        {
            PlayerCharacter playerCharacter = new PlayerCharacter();

            playerCharacter.CharacterName = "MAGE";
            playerCharacter.HealthPoints = 50;
            playerCharacter.AttackBaseDamage = 10;
            playerCharacter.AttackName = "Fireball";

            return playerCharacter;
        }

        public PlayerCharacter getThief()
        {
            PlayerCharacter playerCharacter = new PlayerCharacter();

            playerCharacter.CharacterName = "THIEF";
            playerCharacter.HealthPoints = 50;
            playerCharacter.AttackBaseDamage = 10;
            playerCharacter.AttackName = "Backstab";

            return playerCharacter;
        }

        public PlayerCharacter getWarrior()
        {
            PlayerCharacter playerCharacter = new PlayerCharacter();

            playerCharacter.CharacterName = "WARRIOR";
            playerCharacter.HealthPoints = 50;
            playerCharacter.AttackBaseDamage = 10;
            playerCharacter.AttackName = "Berserk";

            return playerCharacter;
        }


        public PlayerCharacter getPlayerClass(PlayerCharacter getWarrior, PlayerCharacter getThief, PlayerCharacter getMage)
        {
            PlayerCharacter playerCharacter = new PlayerCharacter();

            

            return playerCharacter ;
        }
    }
}
