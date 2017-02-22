using System;
using System.Collections.Generic;
using System.Text;

namespace danteBus.Test
{
    /// <summary>
    /// Controller to handle register
    /// </summary>
    class InitController
    {
        public static void Init()
        { 
            //--Init all the classes that want to registe to callback bus:
            new LoginHandler().Init();
        }
    }
}
