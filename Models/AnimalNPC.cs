using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb_6_Console_Adventure.InterFace;

namespace Labb_6_Console_Adventure
{
    class AnimalNPC : INPC
    {

        public string CharacterType { get; set; }

        public string SpeakProp { get; set; }


        public override string ToString()
        {
            return CharacterType + " "+ SpeakProp;
        }
    }
}
