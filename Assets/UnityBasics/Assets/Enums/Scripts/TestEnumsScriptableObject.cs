using UnityEngine;
using UnityEditor;

namespace Enum_Test
{
    [CreateAssetMenu(fileName = "Enum ScriptableObject", menuName = "Custom Objects/Enum Example Scriptable Object", order = 1)]
    public class TestEnumsScriptableObject : ScriptableObject
    {
        public TestEnum testEnum;
    }
}