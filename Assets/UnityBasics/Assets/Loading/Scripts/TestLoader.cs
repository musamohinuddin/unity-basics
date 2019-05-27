using System;
using System.IO;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine;

namespace Loading_Test
{
    public class TestLoader : MonoBehaviour
    {
        string text;
        string path = "Assets/UnityBasics/Assets/StreamingAssets/TestTextDoc.txt";        
        void Start()
        {
            GameObject testGO= GameObject.Instantiate(Resources.Load("TestResource"),Vector3.zero,Quaternion.identity) as GameObject;          
            string filedata=File.ReadAllText(path);
            Debug.Log(filedata);
        }
        
    }
}