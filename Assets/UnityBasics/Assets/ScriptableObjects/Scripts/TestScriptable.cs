using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObject_Test
{
    public class TestScriptable : MonoBehaviour
    {
        public TestScriptableObject scriptableObject;
        private void Start()
        {
            Debug.Log("Value passed in scriptable object : " +scriptableObject.value);
        }
    }
}