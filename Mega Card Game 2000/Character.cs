using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Card_Game_2000
{
    class Character
    {
        private int attackBaseDamage;
        public int AttackBaseDamage {
            get
            {
                return attackBaseDamage;
            }
            set
            {
                attackBaseDamage = value;
            }
        }
        private string attackName;
        public string AttackName
        {
            get
            {
                return attackName;
            }
            set
            {
                attackName = value;
            }
        }
        private string characterName;
        public string CharacterName
        {
            get
            {
                return characterName;
            }
            set
            {
                characterName = value;
            }
        }
        private int healthPoints;
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }

        public int getAttackBaseDamage()
        {
            return this.attackBaseDamage;
        }

        public string getAttackName()
        {
            return this.attackName;
        }
        
        public int getHealthPoints()
        {
            return this.healthPoints;
        }

        public string getName()
        {
            return this.characterName;
        }

        public int performAttack()
        {
            return this.attackBaseDamage;
        }

        public void takeDamage (int attackBaseDamage)
        {
            this.healthPoints -= attackBaseDamage;
            return;
        }
    }
}
