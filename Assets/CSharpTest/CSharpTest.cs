using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CShapTest
{
    public class CSharpTest : MonoBehaviour
    {
        TestObject to1;
        TestObject to2;

        // Start is called before the first frame update
        void Start()
        {
            to1 = new TestObject();
            to1.SetA(10);
            to1.B = 100;

            to2 = to1;

            Debug.Log($"to1 :: {to1.GetA()} / {to1.B} \n to2 :: {to1.GetA()} / {to1.B}");

            to1.SetA(2);
            to1.B = 20;

            Debug.Log($"to1 :: {to1.GetA()} / {to1.B} \n to2 :: {to1.GetA()} / {to1.B}");

            to2.SetA(3);
            to2.B = 30;

            Debug.Log($"to1 :: {to1.GetA()} / {to1.B} \n to2 :: {to1.GetA()} / {to1.B}");

            Test(to1);
            Test(to2);

            // 주석 테스트
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Test(TestObject to)
        {
            to.SetA(4);
            to.B = 40;

            Debug.Log($"to1 :: {to1.GetA()} / {to1.B} \n to2 :: {to1.GetA()} / {to1.B}");
        }
    }
}
