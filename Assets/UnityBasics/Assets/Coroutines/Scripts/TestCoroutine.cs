#define USE_ASYNC
//#define USE_COROUTINE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutines_Test
{
    public class TestCoroutine : MonoBehaviour
    {
        private bool canShow = false;
        private bool hasAsyncStarted = false;
        private Coroutine coroutine;
        private TestAsyncAwait testAsyncAwait;
        void Start()
        {

            Debug.Log("Start method");
            //StartCoroutine(CoroutineExample());            
#if USE_ASYNC
            testAsyncAwait = new TestAsyncAwait();
#endif
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                canShow = !canShow;

                if (canShow)
                {
#if USE_ASYNC
                    if (!hasAsyncStarted)
                    {
                        hasAsyncStarted = true;
                        testAsyncAwait.TestAsyncMethod();
                    }
#endif
#if USE_COROUTINE

                    if (coroutine == null)
                        coroutine = StartCoroutine(CoroutineExample());
#endif

                }
                else
                {
#if USE_ASYNC
                    hasAsyncStarted = false;
                    testAsyncAwait.StopAsyncMethod();

#endif

#if USE_COROUTINE
                    if (coroutine != null)
                        StopCoroutine(coroutine);
#endif
                }
            }
        }

        IEnumerator CoroutineExample()
        {
            while (true)
            {
                yield return new WaitForSeconds(3f);
                Debug.Log("Inside Coroutine, message appears after 3 seconds");
            }
        }
    }
}