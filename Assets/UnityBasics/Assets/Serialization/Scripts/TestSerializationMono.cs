using System;
using UnityEngine;

namespace Serializable_Test
{
    public class TestSerializationMono : MonoBehaviour
    {
        [SerializeField]
        private int exampleSerialzedInt;
        
        private int exampleUnserialzedInt=5;

        public TestSerializableScriptableObject testSerializable;

        void Start()
        {
            Debug.Log("<color=blue>Serialzed int</color>"+exampleSerialzedInt);
            Debug.Log("<color=red>Un-Serialzed int</color>"+exampleUnserialzedInt);
            Debug.Log("<color=green>Serialzed class SO  int</color>"+testSerializable.serialzableClass.exampleSerializedInt);
        }
    }
}