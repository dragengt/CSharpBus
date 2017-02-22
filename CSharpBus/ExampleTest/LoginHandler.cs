using System;
using System.Collections.Generic;
using System.Text;
using CSharpBus;

namespace CSharpBusTest
{
    class LoginHandler
    {
        internal void Init()
        {
            //Registe my func as service, so the other guy can call this func:
            CallbackBus.Register("OnLogin", (BoolCallbackWithStrs) CanLogin);

            //Registe static func
            CallbackBus.Register("LoginHandler-Welcom", (StringCallback)StaticFunc);
        }

        public static string StaticFunc()
        {
            return "Hello! \n--Msg from login handler";
        }

        public bool CanLogin(string[] strs)
        {
            if (strs.Length >= 2)
            {
                //Check params:
                if (strs[0] == "user"
                    && strs[1] == "psw")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
