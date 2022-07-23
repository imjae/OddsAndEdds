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
            while (true)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Debug.Log(i);
                    yield return WaitForSeconds(3f, true);
                }
            }
        }

        public IEnumerator WaitForSeconds(float seconds, bool ignoreSkipResult = false)
        {
            float t = 0.0f;

            while (t < seconds)
            {
                t += Time.deltaTime;
                yield return null;
            }
        }

        public IEnumerator StopCountNumber()
        {
            Debug.Log($"스탑 코루틴 명령!");
            yield return new WaitForSeconds(1f);
            Debug.Log($"스탑 코루틴 실행!");
            StopCoroutine(testCoroutine);
        }

        public void OnClickCoroutineStart()
        {
            Debug.Log($"코루틴 실행!");
            testCoroutine = StartCoroutine(CountNumber());
        }
        public void OnClickCoroutineStop()
        {
            StartCoroutine(StopCountNumber());
        }
    }
}
