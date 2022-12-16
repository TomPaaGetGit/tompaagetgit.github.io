using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class PlayerCharacter : Character
    {
        public Wand CurrentWand { get; set; }
        public Pets Pet { get; set; }
        public string House { get; set; }
        public int Money { get; set; }

        public PlayerCharacter(Wand currentWand, Pets pet, string house, int money, string name, int health, int damage)
            : base(name, health, damage)
        {
            CurrentWand = currentWand;
            Pet = pet;
            House = house;
            Money = money;
        }

        public void CalcDamage()
        {
            Damage = 10 + CurrentWand.BaseDamage;
        }
        public void Introduce()
        {
            Console.Clear();
            Console.WriteLine($"My name is {Name} and I belong to {House}.");
            Console.WriteLine($"I currently have {Money} coins");
            if (Pet is null)
            {
                Console.WriteLine("I don't have a pet yet, I should buy one.");
            }
            else
            {
                Console.WriteLine($"I have a pet {Pet.Name}");
            }

            if (CurrentWand is null)
            {
                Console.WriteLine("I don't have a wand, I need to buy one before I can do magic.");
            }
            else
            {
                CalcDamage();
                Console.WriteLine($"I have a {CurrentWand.Name}, it deals {Damage} damage.");
            }

            Console.ReadLine();
        }

        public void SpellCast()
        {
            if (CurrentWand is null)
            {
                Console.WriteLine("I don't have a wand, I need one to do magic!");
            }
            else
            {
                Console.WriteLine("Name a spell, something might happen!");
                string spellInput = Console.ReadLine().ToLower();
                if (spellInput is "vingardium leviosa")
                {
                    Console.Clear();
                    Console.WriteLine("You levitate something infront of you and find money underneath it!");
                    Money += 100;
                    Console.ReadLine();
                }
                else if (spellInput is "hocus pocus")
                {
                    Console.Clear();
                    Console.WriteLine("POOF PANG BLAM, fireworks spark out from your wand and the room lights up in different colors.");
                    Console.WriteLine("Some parts of the room might be on fire.");
                    Money += 200;
                    Console.ReadLine();
                }
                else if (spellInput is "lightning bolt")
                {
                    Console.Clear();
                    Console.WriteLine("The sparkmage shrieked, calling on the rage of the storms of his youth.");
                    Console.WriteLine("To his surprise, the sky responded with a fierce energy he'd never thought to see again.");
                    Money += 300;
                    Console.ReadLine();
                }
                else if (spellInput is "terje")
                {
                    Console.Clear();
                    Console.WriteLine(".................................*//////////****,...............................");
                    Console.WriteLine("............................./##//////((//********,*/,..........................");
                    Console.WriteLine("..........................,#%(%*,*//(////*******,*,,,(%/........................");
                    Console.WriteLine(".........................*##%#/*/(////******,,,,,,,,,*(#/*......................");
                    Console.WriteLine(".........................(##(((/(////******,,,**,,,,,,*(#(,.....................");
                    Console.WriteLine("........................*%#(((((/(////**,,,,,,,,,,,,,,,,/(,.....................");
                    Console.WriteLine("........................(###(((///(//***,,,***,,,,,,,,,,*/......................");
                    Console.WriteLine(".......................//###(((((///****,,,*,,,,....,,,,/*......................");
                    Console.WriteLine("......................,#(#%#(((((//*//((/****,****,,,,,,//*.....................");
                    Console.WriteLine(".......................,##*(((((#((//(###/*,,,(//**/,,,**,*.....................");
                    Console.WriteLine("........................(&**/(((///((((((/,,,,*,**,,,,,*,,......................");
                    Console.WriteLine(".........................(///(/(/////(%((*,,,**,,,,,,,,,,.......................");
                    Console.WriteLine(".........................,//((((///(####(***,,,#/*,,,,**,.......................");
                    Console.WriteLine("..........................,/((((/*((((((/*/*,,,,*(*,,,,*........................");
                    Console.WriteLine("...........................//(///**//(####(%(/****,,,,*.........................");
                    Console.WriteLine("..........................,*#((////////**/**,,,,,,,,,*..........................");
                    Console.WriteLine("........................ .*((#((((((/////**,,,,,,,,,............................");
                    Console.WriteLine("...................**/.,,./(#####(((##(//**,,,**,**.............................");
                    Console.WriteLine("..............,*@&&&&&@#/*(#(########(#((/*******,,(,...........................");
                    Console.WriteLine("..........*%&&&&&&&&&&&&&#((((((####((((((///***,,./,/(/(/*,....................");
                    Console.WriteLine("....,%*/((###%&&&&&&&&&&@@&%(/(//(/(((((//*******,.#(%,%#%%%##(/*...............");
                    Console.WriteLine(",#((#%%&&&%&&&&&%&%&&&&%&&&&&&%//(////////********%(%&*%%%%%%%%%%%%(/,..........");
                    Console.WriteLine("(%%%%&&%&&%&%%%&&%&&&&&&%&&&&&&&&&%(*,******,*,/%%%%%%(%%%%%&%%%%%%%/#(*........");
                    Console.WriteLine("&&%&&&&&&&@&&&&&%%%%&&&&&&&&%%&&&&&%&&&&&&&&&&&%%%%%%&%%%%%%%%%%%%%&%%%%%*......");
                    Console.WriteLine("%&&&%&%&&&&@%%&&%%%%&&&&&%%&&&%&&&&%&%%%%%%%%%%%%%%%%%%%%%%%&%%%%%%&&%%%%%*.....");
                    Console.WriteLine("@@%&&@%%&&%@&%&&%%&&%%%&&&%%&&&%%&&&&%&%&%%%%%%%%%%%%%%%%%%%%%%%%%%%&%&%%&(*....");
                    Console.WriteLine("&&@@%&&&%&@%@%%&&%&%%&&%&&&%%&&&&%%%%%%%%%%%%%%%%%%%%&%%%%%%%%%%%%%%&&%%%&%(,...");
                    Console.WriteLine("");
                    Console.WriteLine("Dette er da ett lite hack :)");
                    Console.ReadLine();
                    Money += 99999999;
                }
            }
        }
    }
}
