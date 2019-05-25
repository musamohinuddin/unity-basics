using System;
using System.Collections.Generic;
using UnityEngine;

namespace Coroutines_Test
{
    public class TestAsyncAwait
    {
        private bool canShow = false;
        public async void TestAsyncMethod()
        {
            canShow = true;
            while (canShow)
            {
                await new WaitForSeconds(3f);
                Debug.Log("<color=red>Async method called of a non mono class.</color>");
            }
        }

        public void StopAsyncMethod()
        {
            canShow = false;
        }
    }
}
