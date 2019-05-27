#define USE_RESOURCES
//Comment above one
//Uncomment below one to load texture from Streaming assets
//#define USE_STREAMING_ASSETS

using System;
using System.IO;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;


namespace Loading_Test
{
    public class TestLoader : MonoBehaviour
    {
        string text;
        string filepath = "Assets/UnityBasics/Assets/StreamingAssets/TestTextDoc.txt";
        string path = "E:/Dev/Home_Dev/UnityBasicsModule/Assets/UnityBasics/Assets/StreamingAssets/TestTexture.jpg";
        Texture2D texture;
        GameObject testGO;
        void Start()
        {
            testGO = GameObject.Instantiate(Resources.Load("TestResource"), Vector3.zero, Quaternion.identity) as GameObject;
#if USE_RESOURCES

            texture = Resources.Load("TestTexture") as Texture2D;
            Sprite s = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            testGO.AddComponent<SpriteRenderer>();
            testGO.GetComponent<SpriteRenderer>().sprite = s;
#endif
            string filedata = File.ReadAllText(filepath);
            Debug.Log(filedata);
#if USE_STREAMING_ASSETS
            StartCoroutine(LoadTexture());
#endif
        }
        IEnumerator LoadTexture()
        {
            UnityWebRequest unityWeb = UnityWebRequestTexture.GetTexture(path);

            yield return unityWeb.SendWebRequest();            
            texture = DownloadHandlerTexture.GetContent(unityWeb);
            Sprite s = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            testGO.AddComponent<SpriteRenderer>();
            testGO.GetComponent<SpriteRenderer>().sprite = s;            
        }
    }
}