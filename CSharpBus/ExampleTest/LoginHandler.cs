using System;
using System.Collections.Generic;
using System.Text;

namespace danteBus.Test
{
    class LoginHandler
    {
        internal void Init()
        {
            CallbackBus.Register("OnLogin", new BoolCallbackFuncWithStr(
                (str)=>
                {
                   return CanLogin(str);
                }));
        }

        public bool CanLogin(string stringsWithNameAndPsw)
        {

            return true;
        }
    }
}
