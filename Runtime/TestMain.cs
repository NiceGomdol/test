using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Test.One;
using Test.Two;
using UnityEngine.UI;

namespace Test.Dev
{
    public class TestMain : MonoBehaviour
    {
        public static void CreateTest()
        {
            var popup = Resources.Load<TestMain>("Canvas");
            Instantiate(popup).gameObject.SetActive(true);
        }

        public static string Change(int i)
        {
            if (i == 0)
            {
                var temp = Test1.Temp();
                return temp;
            }
            else
            {
                var temp = Test2.Temp();
                return temp;
            }
        }
    }
}
