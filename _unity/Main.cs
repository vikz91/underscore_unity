using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Utiity "Underscore" Class 
/// Author : iam@debabhishek.com
/// </summary>
/// 

namespace _unity
{
    /// <summary>
    /// A utility library containing lots of usefull and everyday code helpers
    /// </summary>
    /// 
    public static class _
    {

        private static string logtype = "Debug"; // Debug / File / 

        public delegate void Callback();

        #region Debug Helpers

        /// <summary>
        /// Outputs log with Sate tiome and stamp.
        /// </summary>
        /// <example>
        ///     _.l("Hello");
        /// </example>        
        /// <param name="msg">The data you want to dump to console.</param>
        public static void l(object msg)
        {
            string str = "";

            str = "@ " + DateTime.Now + " [" + Time.time + "] : " + msg.ToString();

            switch (_.logtype)
            {

                case "Debug":
                    Debug.Log("LOG " + str);
                    break;
                case "Error":
                    Debug.LogError("ERR " + str);
                    break;
                case "Warning":
                    Debug.LogWarning("WARN " + str);
                    break;
                case "File":

                    break;
            }
        }

        /// <summary>
        /// Debug data as an error
        /// </summary>
        /// <param name="errmsg">The error message you want to dump</param>
        /// <seealso cref="l"/>
        public static void e(string errmsg)
        {
            string ol = logtype;
            logtype = "Error";
            l(errmsg);
            logtype = ol;
        }

        /// <summary>
        /// Deug data with Warning message
        /// </summary>
        /// <param name="warmsg">The warning message you want to dump.</param>
        public static void w(string warmsg)
        {
            string ol = logtype;
            logtype = "Warning";
            l(warmsg);
            logtype = ol;
        }

        #endregion


        #region GUI Helpers
        /// <summary>
        /// Consistent GUI Scaling across all scenes
        /// </summary>
        /// <param name="customWidth">The width of the app</param>
        /// <param name="customHeight">The height of the app</param>
        /// <example>
        ///     void OnGUI(){ _.GUISetup(800f,480f); }
        ///     
        /// </example>
        public static void GUISetup(float customWidth = 1366f, float customHeight = 768f)
        {
            GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(Screen.width / customWidth, Screen.height / customHeight, 1f));
        }

        #endregion


        #region Array Helpers

        //Initializes Array Objects
        public static T[] InitializeArrayObject<T>(int length) where T : new()
        {
            T[] array = new T[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = new T();
            }
            return array;
        }
        #endregion

        #region Random Generators

        //Shuffles finites set ( )
        public static void Shuffle<T>(this IList<T> list)
        {
            System.Random rng = new System.Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        #endregion

        #region Misc Helpers
        // Execute Once Function. Takes a callback function as parameter and a bool variable 
        public static void ExecOnce(Callback callback, ref bool limiter)
        {
            if (!limiter)
            {
                _.l("ExecOnce Called .. .");

                callback();

                _.l("ExecOnce Finished!");

                limiter = true;
            }

        }

        #endregion
    }
}