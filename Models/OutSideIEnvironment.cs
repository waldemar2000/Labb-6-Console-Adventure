using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_6_Console_Adventure.InterFace;
namespace Labb_6_Console_Adventure
{
    class OutSideIEnvironment:IEnvironment
    {
        public string EnvironmentProp { get; set; }
        public string WeatherProp { get; set; }
        public void EnvironmentAppearence()
        {
            Console.WriteLine("Du är utomhus, "+EnvironmentProp+". Det "+WeatherProp);
        }
    }
}
