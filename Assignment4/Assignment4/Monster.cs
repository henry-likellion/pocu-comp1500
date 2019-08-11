using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Monster
    {
        public string Name { get; }
        public EElementType ElementType { get; }
        public int Health { get; private set; }
        public int AttackStat { get; }
        public int DefenseStat { get; }
        public Monster(string name, EElementType elementType, int health, int attack, int defense)
        {
            Name = name;
            ElementType = elementType;
            Health = health;
            AttackStat = attack;
            DefenseStat = defense;
        }

        public void TakeDamage(int amount)
        {
            if (Health < amount)
            {
                Health = 0;
            }
            else
            {
                Health -= amount;
            }
        }

        public void Attack(Monster otherMonster)
        {   
            int damage = AttackStat - otherMonster.DefenseStat;

            switch (ElementType)
            {
                case EElementType.Fire:
                    switch (otherMonster.ElementType)
                    {
                        case (EElementType.Wind):
                            damage = (int)(damage * 1.5);
                            break;
                        case (EElementType.Water):
                            damage = (int)(damage * 0.5);
                            break;
                        case (EElementType.Earth):
                            damage = (int)(damage * 0.5);
                            break;
                    }
                    break;
                case EElementType.Wind:
                    switch (otherMonster.ElementType)
                    {
                        case (EElementType.Earth):
                            damage = (int)(damage * 1.5);
                            break;
                        case (EElementType.Water):
                            damage = (int)(damage * 1.5);
                            break;
                        case (EElementType.Fire):
                            damage = (int)(damage * 0.5);
                            break;
                    }
                    break;
                case EElementType.Water:
                    switch (otherMonster.ElementType)
                    {
                        case (EElementType.Fire):
                            damage = (int)(damage * 1.5);
                            break;
                        case (EElementType.Wind):
                            damage = (int)(damage * 0.5);
                            break;
                    }
                    break;
                case EElementType.Earth:
                    switch (otherMonster.ElementType)
                    {
                        case (EElementType.Fire):
                            damage = (int)(damage * 1.5);
                            break;
                        case (EElementType.Wind):
                            damage = (int)(damage * 0.5);
                            break;
                    }
                    break;
            }

            if (damage < 1)
            {
                damage = 1;
            }

            otherMonster.TakeDamage(damage);
        }
    }
}
