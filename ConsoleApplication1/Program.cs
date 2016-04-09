using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character APaladin = new Paladin (800,400,80);
            Character ENPaladin = new Paladin(800, 400, 80);
            Character APriest = new Priest(400, 500, 30);
            Character ENPriest = new Priest(400, 500, 30);
            Character AShaman = new Shaman(500, 700, 50);
            Character ENShaman = new Shaman (500,700,50);
            Character ARogue = new Rogue(360, 500, 100);
            Character ENRogue = new Rogue(360, 500, 100);
            Console.WriteLine("Приветствуем вас в игре The Older Modern black scrolls of the great magic tower");
            Console.WriteLine("Чтобы получить информацию о классах напишите info /Paladin/Priest/Rogue/Shaman, чтобы про пропустить информацию нажмите интер");
            string a = Console.ReadLine();

            switch (a)
            {
                case "info Paladin":
                    {

                        Console.WriteLine("Паладин - это воин света использующий большой двуручный мечь как основное оружие, его статистики такие хп - 800, мана - 400, И урон с руки - 80");
                        break;
                    }
                case "info Priest":
                    {
                        Console.WriteLine("Прист или Жрец это *Доктор* команды, он может как наносить урон, но он будет очень маленьким и поэтому ему назначили роль лечить команду, его статистки равны хп - 400, мана - 900, и урон с руки - 30  ");
                        break;
                    }
                case "info Rogue":
                    {
                        Console.WriteLine("Разбойник или вор или рога, как только не называли эту машину для убийств, его характеристики хп - 360, мана - 500, урон с руки - 100");
                        break;
                    }
                case "info Shaman":
                    {
                        Console.WriteLine("Шаман это великий связной с духами, его статистики равны хп - 500, мана - 700, урон с руки - 70");
                        break;

                    }

            }
            Console.WriteLine("Когда будите готовы приступить к игре нажмине интер");
            Console.ReadLine();
            Console.WriteLine("Кем вы хотите играть(Paladin;Priest;Rogue;Shaman)");
            string b = Console.ReadLine();
            switch (b)
            {
                case "Paladin":
                    {
                        Console.WriteLine("Хорошо, вы выбрали Паладина теперь выберете кого атаковать... (Paladin/Shaman/Priest/Rogue");
                        string c = Console.ReadLine();
                        switch (c)
                        {
                            case "Paladin":
                                {
                                    Console.WriteLine("Вы выбрали Паладина для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Паладина уменьшилось и стало равно =");
                                    Console.WriteLine(ENPaladin.Hp - APaladin.Dmg);
                                    break;
                                }
                            case "Shaman":
                                {
                                    Console.WriteLine("Вы выбрали Шамана для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Шамана уменьшилось и стало равно =");
                                    Console.WriteLine(ENShaman.Hp-APaladin.Dmg);
                                    break;
                                }
                            case "Rogue":
                                {
                                    Console.WriteLine("Вы выбрали Разбойника для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP разбойника уменьшилось и стало равно =");
                                    Console.WriteLine(ENRogue.Hp - APaladin.Dmg);
                                    break;
                                }
                            case "Priest":
                                {
                                    Console.WriteLine("Вы выбрали Жрец для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Жреца уменьшилось и стало равно =");
                                    Console.WriteLine(ENPriest.Hp - APaladin.Dmg);
                                    break;
                                }
                        }
                        break;
                    }
                case "Priest":
                    {
                        Console.WriteLine("Хорошо, вы выбрали Жреца теперь выберете кого атаковать... (Paladin/Shaman/Priest/Rogue");
                        string c = Console.ReadLine();
                        switch (c)
                        {
                            case "Paladin":
                                {
                                    Console.WriteLine("Вы выбрали Паладина для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Паладина уменьшилось и стало равно =");
                                    Console.WriteLine(ENPaladin.Hp - APriest.Dmg);
                                    break;
                                    
                                }
                            case "Shaman":
                                {
                                    Console.WriteLine("Вы выбрали Шамана для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Шамана уменьшилось и стало равно =");
                                    Console.WriteLine(ENShaman.Hp - APriest.Dmg);
                                    break;
                                }
                            case "Rogue":
                                {
                                    Console.WriteLine("Вы выбрали Разбойника для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP разбойника уменьшилось и стало равно =");
                                    Console.WriteLine(ENRogue.Hp - APriest.Dmg);
                                    break;
                                }
                            case "Priest":
                                {
                                    Console.WriteLine("Вы выбрали Жрец для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Жреца уменьшилось и стало равно =");
                                    Console.WriteLine(ENPriest.Hp - APriest.Dmg);
                                    break;
                                }
                        }
                        break;
                    }
                case "Rogue":
                    {
                        Console.WriteLine("Хорошо, вы выбрали Разбойника теперь выберете кого атаковать... (Paladin/Shaman/Priest/Rogue");
                        string c = Console.ReadLine();
                        switch (c)
                        {
                            case "Paladin":
                                {
                                    Console.WriteLine("Вы выбрали Паладина для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Паладина уменьшилось и стало равно =");
                                    Console.WriteLine(ENPaladin.Hp - ARogue.Dmg);
                                    break;
                                    
                                }
                            case "Shaman":
                                {
                                    Console.WriteLine("Вы выбрали Шамана для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Шамана уменьшилось и стало равно =");
                                    Console.WriteLine(ENShaman.Hp - ARogue.Dmg);
                                    break;
                                }
                            case "Rogue":
                                {
                                    Console.WriteLine("Вы выбрали Разбойника для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP разбойника уменьшилось и стало равно =");
                                    Console.WriteLine(ENRogue.Hp - ARogue.Dmg);
                                    break;
                                }
                            case "Priest":
                                {
                                    Console.WriteLine("Вы выбрали Жрец для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Жреца уменьшилось и стало равно =");
                                    Console.WriteLine(ENPriest.Hp - ARogue.Dmg);
                                    break;
                                }
                        }
                        break;
                    }
                case "Shaman":
                    {
                        Console.WriteLine("Хорошо, вы выбрали Шамана теперь выберете кого атаковать... (Paladin/Shaman/Priest/Rogue");
                        string c = Console.ReadLine();
                        switch (c)
                        {
                            case "Paladin":
                                {
                                    Console.WriteLine("Вы выбрали Паладина для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Паладина уменьшилось и стало равно =");
                                    Console.WriteLine(ENPaladin.Hp - AShaman.Dmg);
                                    break;
                                }
                            case "Shaman":
                                {
                                    Console.WriteLine("Вы выбрали Шамана для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Шамана уменьшилось и стало равно =");
                                    Console.WriteLine(ENShaman.Hp - AShaman.Dmg);
                                    break;
                                }
                            case "Rogue":
                                {
                                    Console.WriteLine("Вы выбрали Разбойника для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP разбойника уменьшилось и стало равно =");
                                    Console.WriteLine(ENRogue.Hp - AShaman.Dmg);
                                    break;
                                }
                            case "Priest":
                                {
                                    Console.WriteLine("Вы выбрали Жрец для атаки");
                                    Console.ReadLine();
                                    Console.WriteLine("После вашей атаки HP Жреца уменьшилось и стало равно =");
                                    Console.WriteLine(ENPriest.Hp - AShaman.Dmg);
                                    break;
                                }
                        }
                        break;
                    }
            }



            
        }
    }
}
