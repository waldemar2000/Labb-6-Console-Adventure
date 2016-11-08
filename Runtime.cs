using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_6_Console_Adventure.InterFace;


namespace Labb_6_Console_Adventure
{
    class Runtime
    {
        public string item = "nothing";
        public string lantern = "no";
        public string key = "no";
        public string konwOfDarkness = "no";
        public string name;

        public void Start()
        {

            Console.Clear();
            Console.WriteLine("Välkommen till Waldemars Console Adventure");
            Console.WriteLine("Skriv ditt namn");
            name = Console.ReadLine();

            Console.WriteLine("Tryck valfri tangent för att börja");
            Console.ReadLine();
            ChooseWhereToGo();
        }

        public void ChooseWhereToGo()
        {
            Console.Clear();
            Console.WriteLine("Du står vid vid en vägkorsning");
            UI ui = new UI();
            ui.Choice1Prop = "Slottet";
            ui.Choice2Prop = "Skogen";
            ui.Choice3Prop = "Huset";
            ui.Choice4Prop = "Grottan";
            ui.Choice5Prop = "Marknaden";
            ui.UserInterface();

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1: Castle(); break;
                case 2: Forest(); break;
                case 3: House(); break;
                case 4: Cave(); break;
                case 5: Market(); break;

            }
        }
        public void Castle()
        {
            Console.Clear();
            OutSideIEnvironment tempOutSideIEnvironment = new OutSideIEnvironment();
            tempOutSideIEnvironment.WeatherProp = " är molnigt och åskan ekar.";

            tempOutSideIEnvironment.EnvironmentProp = "det är ett stort slott framför dig";
            tempOutSideIEnvironment.EnvironmentAppearence();
            Console.ReadLine();
            if (key.Contains("yes"))
            {
                
                Console.WriteLine("Du öppnar porten med nyckeln du hittade och går in.");
                Console.ReadLine();
                Console.WriteLine("Det står en låda på ett bord, du öppnar lådan.");
                Console.ReadLine();
                Console.WriteLine("I lådan hittar du en lapp, på lappen står det...");
                Console.ReadLine();
                Console.WriteLine("Grattis "+name+", du klarade spelet!!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
             
                Console.WriteLine("Du går fram till den stora porten och känner på handtaget, porten är låst.");
                Console.WriteLine("du går tillbaka");
                Console.ReadLine();
                ChooseWhereToGo();
            }
        }

        public void Forest()
        {
            List<AnimalNPC> animal = new List<AnimalNPC>
            {
            new AnimalNPC {CharacterType="Det är en giraff",SpeakProp="WEEOOHHWEEeehoo" },
            new AnimalNPC {CharacterType="Det är ett får",SpeakProp="bääääh" },
            new AnimalNPC {CharacterType="Det är en uggla",SpeakProp="HOOoo HOOOoo" },
            new AnimalNPC {CharacterType="Det är en hund...",SpeakProp="Voff Voff...jag är en hund." },
            new AnimalNPC {CharacterType="Det är en charmig groda,",SpeakProp="Hello my baby" },
            new AnimalNPC {CharacterType="Det är en enhörning",SpeakProp="NYYEEEEHHH" },
            new AnimalNPC {CharacterType="det är en fyrhörning",SpeakProp="....." }
            };


            Console.Clear();
            OutSideIEnvironment tempOutSideIEnvironment = new OutSideIEnvironment();
            tempOutSideIEnvironment.WeatherProp = " är fint väder";

            tempOutSideIEnvironment.EnvironmentProp = "Det är en skog";
            tempOutSideIEnvironment.EnvironmentAppearence();

            Console.WriteLine("Du ser något i skogen.");
            Random random = new Random();
            int i = random.Next(0,7);
            Console.WriteLine(animal[i]);
            Console.ReadLine();
            ChooseWhereToGo();
        }

        public void House()
        {
            Console.Clear();
            Room_IEnvironment tempRoom_IEnvironment = new Room_IEnvironment();
            tempRoom_IEnvironment.EnvironmentProp = "ett hus,";
            tempRoom_IEnvironment.RoomProp = "Det finns massa spännande saker i rummet.";
            tempRoom_IEnvironment.EnvironmentAppearence();
            Console.WriteLine("Leta runt1 eller gå tillbaka2");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:


                    if (item.Contains("item")||item.Contains("sold"))
                    {
                        Console.Clear();
                        Console.WriteLine("Du hittar inget andvändbart");
                        Console.ReadLine();
                        ChooseWhereToGo();
                    }

                    else

                    {
                        Console.Clear();
                        Console.WriteLine("Du letar runt och hittar en viktig grej");
                        item = "item";
                        Console.ReadLine();

                        ChooseWhereToGo();
                    }


                    break;
                case 2: ChooseWhereToGo(); break;
            }

        }

        public void Cave()
        {
            Console.Clear();
            Room_IEnvironment tempRoom_IEnvironment = new Room_IEnvironment();
            tempRoom_IEnvironment.EnvironmentProp = "en grotta,";
            tempRoom_IEnvironment.RoomProp = "det är unken luft och du hör något som droppar.";
            tempRoom_IEnvironment.EnvironmentAppearence();
            if (lantern.Contains("no"))
            {
                Console.Clear();
                Console.WriteLine("Det är för mörkt, du ser ingenting");
                Console.ReadLine();

                Console.WriteLine("Du går tillbaka");
                Console.ReadLine();
                konwOfDarkness = "yes";
                ChooseWhereToGo();
            }

            if(lantern.Contains("yes"))

            {
                Console.Clear();
                Console.WriteLine("Du Tänder lyktan.");
                Console.ReadLine();
                Console.WriteLine("Du letar runt i grottan.");
                Console.ReadLine();
                Console.WriteLine("Du hittar en nyckel.");
                key = "yes";
                Console.ReadLine();
                Console.WriteLine("Du går tillbaka");
            
                ChooseWhereToGo();
            }
        }
        public void Market()
        {
            Console.Clear();
            OutSideIEnvironment tempOutSideIEnvironment = new OutSideIEnvironment();
            tempOutSideIEnvironment.WeatherProp = " fint väder, solen skiner.";

            tempOutSideIEnvironment.EnvironmentProp = "Det är en marknad";
            tempOutSideIEnvironment.EnvironmentAppearence();
            
            if (konwOfDarkness.Contains("no"))
            {
                Console.Clear();
                Console.WriteLine("Du ser inget du behöver");
                Console.ReadLine();

                Console.WriteLine("Du går tillbaka");
                Console.ReadLine();

                ChooseWhereToGo();
            }

            if (konwOfDarkness.Contains("yes"))

            {
                if (item.Contains("item"))
                {
                    Console.Clear();
                    Console.WriteLine("Du hittar en lykta på marknaden, du byter den viktiga grejen mot lyktan.");
                lantern = "yes";
                    item = "sold";
                    Console.WriteLine("Du går tillbaka");
                    Console.ReadLine();
                    ChooseWhereToGo();
                }
                 else
                {
                    Console.Clear();
                    Console.WriteLine("Du har inga pengar eller något att byta med.");
                    Console.WriteLine("Du går tillbaka");
                    Console.ReadLine();
                    ChooseWhereToGo();
                }
            }
        }
    }
}
