using UnityEngine;
using UnityEditor;

[CreateAssetMenu (fileName ="Example ScriptableObject",menuName ="Custom Objects/Example Scriptable Object",order = 1)]
public class TestScriptableObject : ScriptableObject
{
    public int value;
}