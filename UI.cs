using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_Console_Adventure
{
    class UI
    {
        public string Choice1Prop { get; set; }
        public string Choice2Prop { get; set; }
        public string Choice3Prop { get; set; }
        public string Choice4Prop { get; set; }
        public string Choice5Prop { get; set; }

        public void UserInterface()
        {
            Console.WriteLine("gör ditt val");
            Console.WriteLine("Tryck1 för att gå till "+ Choice1Prop );
            Console.WriteLine("Tryck2 för att gå till " + Choice2Prop );
            Console.WriteLine("Tryck3 för att gå till " + Choice3Prop );
            Console.WriteLine("Tryck4 för att gå till " + Choice4Prop);
            Console.WriteLine("Tryck5 för att gå till " + Choice5Prop);
        }
    }
}
