using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment4
{
    public class Arena
    {
        public string ArenaName { get; }
        public uint Capacity { get; }
        public uint Turns { get; private set; }
        public uint MonsterCount { get; private set; }

        public List<Monster> Monsters { get; private set; }

        public Arena(string arenaName, uint capacity)
        {
            ArenaName = arenaName;
            Capacity = capacity;
            MonsterCount = 0;
            Turns = 0;
            Monsters = new List<Monster>();
        }

        public void LoadMonsters(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    if (Capacity == MonsterCount)
                    {
                        break;
                    };

                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string name = values[0];
                    EElementType elementType;

                    if (values[1] == "Earth")
                    {
                        elementType = EElementType.Earth;
                    }
                    else if (values[1] == "Water")
                    {
                        elementType = EElementType.Water;
                    }
                    else if (values[1] == "Wind")
                    {
                        elementType = EElementType.Wind;
                    }
                    else
                    {
                        elementType = EElementType.Fire;
                    }

                    int health = int.Parse(values[2]);
                    int attack = int.Parse(values[3]);
                    int defense = int.Parse(values[4]);

                    Monster newMonster = new Monster(name, elementType, health, attack, defense);

                    Monsters.Add(newMonster);
                    ++MonsterCount;
                }
            }
        }

        public void GoToNextTurn()
        {
            int countMonsters = Monsters.Count;
            List<Monster> monsterOut = new List<Monster>(countMonsters);

            if (countMonsters <= 1)
            {
                return;
            }

            for (int i = 0; i < countMonsters; ++i)
            {
                Monster monster = Monsters[i];

                if (monster.Health > 0)
                {
                    int index;
                    if (i == countMonsters - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index = i + 1;
                    }

                    Monster nextMonster = Monsters[index];

                    monster.Attack(nextMonster);

                    if (Turns != 0 && nextMonster.Health == 0)
                    {
                        monsterOut.Add(nextMonster);
                    }
                }
            }

            if (Turns == 0)
            {
                for (int i = 0; i < countMonsters; ++i)
                {
                    if (Monsters[i].Health == 0)
                    {
                        monsterOut.Add(Monsters[i]);
                    }
                }
            }

            foreach (var monster in monsterOut)
            {
                Console.WriteLine(monster.Name);
                Monsters.Remove(monster);
                --MonsterCount;
            }

            ++Turns;

            foreach(var monster in Monsters)
            {
                Console.Write($"{monster.Name}: {monster.Health}  ");
            }
            Console.WriteLine("");

            Console.WriteLine($"{Turns}: {MonsterCount}");
        }

        public Monster GetHealthiest()
        {
            if (MonsterCount == 0)
            {
                return null;
            }
            int indexHealthiest = 0;

            for (int i = 1; i < Monsters.Count; ++i)
            {
                if (Monsters[indexHealthiest].Health < Monsters[i].Health)
                {
                    indexHealthiest = i;
                }
            }
            return Monsters[indexHealthiest];
        }
    }
}
