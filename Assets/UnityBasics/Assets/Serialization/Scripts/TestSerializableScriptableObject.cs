using UnityEngine;
using UnityEditor;

namespace Serializable_Test
{
    [CreateAssetMenu(fileName = "Serializable Example ScriptableObject", menuName = "Custom Objects/Serializable Scriptable Object", order = 0)]
    public class TestSerializableScriptableObject : ScriptableObject
    {
        public TestSerializableClass serialzableClass;
    }
}