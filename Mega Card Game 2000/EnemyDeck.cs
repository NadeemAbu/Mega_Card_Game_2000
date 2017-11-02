using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Card_Game_2000
{
    class EnemyDeck
    {
        private List<Character> enemies { get; set; }

        private List<Character> generateEnemyList()
        {
            List<Character> enemies = new List<Character>();

            var enemy = new Character();
            enemy.CharacterName = "Goblin";
            enemy.AttackBaseDamage = 20;
            enemy.AttackName = "Scratch";
            enemy.HealthPoints = 50;

            enemies.Add(enemy);

            enemy = new Character();
            enemy.CharacterName = "Dragon";
            enemy.AttackBaseDamage = 40;
            enemy.AttackName = "FireBreath";
            enemy.HealthPoints = 200;

            enemies.Add(enemy);

            enemy = new Character();
            enemy.CharacterName = "Skeleton";
            enemy.AttackBaseDamage = 30;
            enemy.AttackName = "Bone stab";
            enemy.HealthPoints = 50;

            enemies.Add(enemy);

            enemy = new Character();
            enemy.CharacterName = "Witch";
            enemy.AttackBaseDamage = 50;
            enemy.AttackName = "Posion";
            enemy.HealthPoints = 150;

            enemies.Add(enemy);

            enemy = new Character();
            enemy.CharacterName = "Cyborg";
            enemy.AttackBaseDamage = 25;
            enemy.AttackName = "electrocute";
            enemy.HealthPoints = 100;

            enemies.Add(enemy);

            return enemies;
        }

        public Character GetEnemy(List<Character> pEnemies)
        {
           var vRand = new Random();
           int enemy = vRand.Next(0, pEnemies.Count);
           return pEnemies[enemy];
        }
    }
}
