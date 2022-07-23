using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoroutineTest
{
    public class CoroutineTestScript : MonoBehaviour
    {
        public Coroutine testCoroutine;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public IEnumerator CountNumber()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return new WaitForSeconds(3f);
                Debug.Log(i);
            }
        }

        public void OnClickCoroutineStart()
        {
            testCoroutine = StartCoroutine(CountNumber());
        }
        public void OnClickCoroutineStop()
        {
            StopCoroutine(testCoroutine);
        }
    }
}
