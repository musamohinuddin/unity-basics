using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutines_Test
{
    public class TestCoroutine : MonoBehaviour
    {
        private bool canShow = false;
        private Coroutine coroutine;
        void Start()
        {

            Debug.Log("Start method");
            //StartCoroutine(CoroutineExample());            
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                canShow = !canShow;

                if (canShow)
                {
                    if (coroutine == null)
                        coroutine = StartCoroutine(CoroutineExample());
                }
                else
                {
                    if (coroutine != null)
                        StopCoroutine(coroutine);
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