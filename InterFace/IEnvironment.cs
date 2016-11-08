using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_6_Console_Adventure.InterFace;

namespace Labb_6_Console_Adventure.InterFace
{
    interface IEnvironment
    {
        string EnvironmentProp { get; set; }
        void EnvironmentAppearence();
    }
}
