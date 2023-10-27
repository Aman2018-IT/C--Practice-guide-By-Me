using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_to_the_Death
{
    class CantTeleports : Teleports
    {
        public string teleport()
        {
            return "fails to teleport";
        }
    }
}
