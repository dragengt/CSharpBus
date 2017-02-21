using System;
using System.Collections.Generic;
using System.Text;

namespace danteBus
{
    public delegate void CallbackFunc();
    public delegate void CallbackFuncWithBool(bool param);
    public delegate void CallbackFuncWithObj(Object param);
    
    public delegate bool BoolCallbackFunc();
    public delegate bool BoolCallbackFuncWithBool(bool param);
    public delegate bool BoolCallbackFuncWithInt(int param);
    public delegate bool BoolCallbackFuncWithStr(string param);

    public delegate int IntCallbackFunc();
    public delegate int IntCallbackFuncWithInt(int param);
    public delegate int IntCallbackFuncWithFloat(float param);

    public delegate string StringCallbackFunc();
    public delegate string StringCallbackFuncWithStr(string param);
    public delegate string StringCallbackFuncWithInt(int param);
    
    public delegate Object ObjectCallbackFuncWithObj(Object obj);

    /// <summary>
    /// Service for singleton classes: 
    /// when your classes need to call some funcs that you don't want to know where it is , use this.
    /// </summary>
    /// <remarks>Also acept register from instances but you got to give it a special name & use it carefully. </remarks>
    class CallbackBus
    {
        static Dictionary<string, Delegate> g_dictCallbacks = new Dictionary<string, Delegate>();

        //------------------------------------------------------------
        //                  Register part:
        //  Get on the bus!
        //------------------------------------------------------------
        #region Register part
        
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, CallbackFunc cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, CallbackFuncWithBool cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, CallbackFuncWithObj cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }

        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackFunc cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackFuncWithBool cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackFuncWithInt cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackFuncWithStr cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }

        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, IntCallbackFunc cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, IntCallbackFuncWithInt cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, IntCallbackFuncWithFloat cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }

        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, StringCallbackFunc cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, StringCallbackFuncWithStr cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, StringCallbackFuncWithInt cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }

        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, ObjectCallbackFuncWithObj cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        #endregion

        //------------------------------------------------------------
        //                  Find part
        //  Who is on the bus
        //------------------------------------------------------------
        #region find callback func:
        public static CallbackFunc GetCallbackFunc(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (CallbackFunc)delegateFunc;
        }
        public static CallbackFuncWithBool GetCallbackFuncWithBool(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (CallbackFuncWithBool)delegateFunc;
        }
        public static CallbackFuncWithObj GetCallbackFuncWithObj(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (CallbackFuncWithObj)delegateFunc;
        }

        public static BoolCallbackFunc GetBoolCallbackFunc(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackFunc)delegateFunc;
        }
        public static BoolCallbackFuncWithBool GetBoolCallbackFuncWithBool(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackFuncWithBool)delegateFunc;
        }
        public static BoolCallbackFuncWithInt GetBoolCallbackFuncWithInt(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackFuncWithInt)delegateFunc;
        }
        public static BoolCallbackFuncWithStr GetBoolCallbackFuncWithStr(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackFuncWithStr)delegateFunc;
        }

        public static IntCallbackFunc GetIntCallbackFunc(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (IntCallbackFunc)delegateFunc;
        }
        public static IntCallbackFuncWithInt GetIntCallbackFuncWithInt(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (IntCallbackFuncWithInt)delegateFunc;
        }
        public static IntCallbackFuncWithFloat GetIntCallbackFuncWithFloat(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (IntCallbackFuncWithFloat)delegateFunc;
        }

        public static StringCallbackFuncWithInt GetStringCallbackFunc(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (StringCallbackFuncWithInt)delegateFunc;
        }
        public static StringCallbackFuncWithStr GetStringCallbackFuncWithStr(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (StringCallbackFuncWithStr)delegateFunc;
        }
        public static StringCallbackFuncWithInt GetStringCallbackFuncWithInt(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (StringCallbackFuncWithInt)delegateFunc;
        }

        public static ObjectCallbackFuncWithObj GetObjectCallbackFuncWithObj(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (ObjectCallbackFuncWithObj)delegateFunc;
        }

    


        public static Delegate GetFunc(string callbackName)
        {
            if (g_dictCallbacks.ContainsKey(callbackName))
            {
                return g_dictCallbacks[callbackName];
                
            }
            else
            {
                return null;
            }
        }
        #endregion

        //------------------------------------------------------------
        //                  Remove part
        //  Somebody get out of the bus
        //------------------------------------------------------------
        
        /// <summary>
        /// Remove the callback
        /// </summary>
        public static void RemoveCallback(string callbackName)
        {
            g_dictCallbacks.Remove(callbackName);
        }

        /// <summary>
        /// Clear all callbacks
        /// </summary>
        public static void RemoveAllCallbacks()
        {
            g_dictCallbacks.Clear();
        }


        //------------------------------------------------------------
        //                  private part
        //------------------------------------------------------------
        private static bool AddCallback(string callbackName, Delegate cbFunc)
        {
            if (g_dictCallbacks.ContainsKey(callbackName))
            {
                //Canno't register with the same name.
                return false;
            }
            else
            {
                g_dictCallbacks.Add(callbackName, cbFunc);
                return true;
            }
        }


    }
}
