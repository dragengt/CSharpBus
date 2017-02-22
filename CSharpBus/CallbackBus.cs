using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBus
{
    public delegate void Callback();
    public delegate void CallbackWithBool(bool param);
    public delegate void CallbackWithObj(Object param);
    public delegate void CallbackWithStr(string param);
    public delegate void CallbackWithStrings(string[] strs);

    public delegate bool BoolCallback();
    public delegate bool BoolCallbackWithBool(bool param);
    public delegate bool BoolCallbackWithInt(int param);
    public delegate bool BoolCallbackWithStr(string param);
    public delegate bool BoolCallbackWithObj(Object param);
    public delegate bool BoolCallbackWithStrs(string[] strs);

    public delegate int IntCallback();
    public delegate int IntCallbackWithInt(int param);
    public delegate int IntCallbackWithFloat(float param);
    public delegate int IntCallbackWithStr(string param);
    public delegate int IntCallbackWithStrs(string[] strs);

    public delegate string StringCallback();
    public delegate string StringCallbackWithStr(string param);
    public delegate string StringCallbackWithInt(int param);
    public delegate string StringCallbackWithStrs(string[] strs);
    public delegate string StringCallbackWithObj(Object param);

    public delegate Object ObjectCallbackWithObj(Object obj);



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
        public static bool Register(string callbackName, Callback cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, CallbackWithBool cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, CallbackWithObj cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, CallbackWithStr cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, CallbackWithStrings cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }

        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallback cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackWithBool cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackWithInt cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackWithStr cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackWithObj cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, BoolCallbackWithStrs cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }

        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, IntCallback cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, IntCallbackWithInt cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, IntCallbackWithFloat cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, IntCallbackWithStr cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, IntCallbackWithStrs cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }

        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, StringCallback cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, StringCallbackWithStr cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, StringCallbackWithInt cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, StringCallbackWithStrs cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }
        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, StringCallbackWithObj cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }

        /// <summary>
        /// Register your func as service
        /// </summary>
        public static bool Register(string callbackName, ObjectCallbackWithObj cbFunc)
        {
            return AddCallback(callbackName, (Delegate)cbFunc);
        }


        #endregion

        //------------------------------------------------------------
        //                  Find part
        //  Who is on the bus
        //------------------------------------------------------------
        #region find callback func:
        public static Callback GetCallback(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (Callback)delegateFunc;
        }
        public static CallbackWithBool GetCallbackWithBool(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (CallbackWithBool)delegateFunc;
        }
        public static CallbackWithObj GetCallbackWithObj(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (CallbackWithObj)delegateFunc;
        }
        public static CallbackWithStr GetCallbackWithStr(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (CallbackWithStr)delegateFunc;
        }
        public static CallbackWithStrings GetCallbackWithStrings(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (CallbackWithStrings)delegateFunc;
        }

        public static BoolCallback GetBoolCallback(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallback)delegateFunc;
        }
        public static BoolCallbackWithBool GetBoolCallbackWithBool(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackWithBool)delegateFunc;
        }
        public static BoolCallbackWithInt GetBoolCallbackWithInt(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackWithInt)delegateFunc;
        }
        public static BoolCallbackWithStr GetBoolCallbackWithStr(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackWithStr)delegateFunc;
        }
        public static BoolCallbackWithObj GetBoolCallbackWithObj(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackWithObj)delegateFunc;
        }
        public static BoolCallbackWithStrs GetBoolCallbackWithStrs(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (BoolCallbackWithStrs)delegateFunc;
        }

        public static IntCallback GetIntCallback(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (IntCallback)delegateFunc;
        }
        public static IntCallbackWithInt GetIntCallbackWithInt(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (IntCallbackWithInt)delegateFunc;
        }
        public static IntCallbackWithFloat GetIntCallbackWithFloat(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (IntCallbackWithFloat)delegateFunc;
        }
        public static IntCallbackWithStr GetIntCallbackWithStr(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (IntCallbackWithStr)delegateFunc;
        }
        public static IntCallbackWithStrs GetIntCallbackWithStrs(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (IntCallbackWithStrs)delegateFunc;
        }

        public static StringCallback GetStringCallback(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (StringCallback)delegateFunc;
        }
        public static StringCallbackWithStr GetStringCallbackWithStr(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (StringCallbackWithStr)delegateFunc;
        }
        public static StringCallbackWithInt GetStringCallbackWithInt(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (StringCallbackWithInt)delegateFunc;
        }
        public static StringCallbackWithStrs GetStringCallbackWithStrs(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (StringCallbackWithStrs)delegateFunc;
        }
        public static StringCallbackWithObj GetStringCallbackWithObj(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (StringCallbackWithObj)delegateFunc;
        }

        public static ObjectCallbackWithObj GetObjectCallbackWithObj(string callbackName)
        {
            Delegate delegateFunc = GetFunc(callbackName);

            return (ObjectCallbackWithObj)delegateFunc;
        }

        /// <summary>
        /// Get delegate registed
        /// </summary>
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
        public static bool HasCallback(string callbackName)
        {
            return g_dictCallbacks.ContainsKey(callbackName);
        }

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
