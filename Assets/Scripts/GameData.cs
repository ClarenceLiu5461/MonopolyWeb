using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Networking;
using System.Net;

public class GameData : MonoBehaviour
{
    public static int Past;
    public static int DiceNum;
    void Awake()
    {
        SendRequest();
    }
    IEnumerator SendRequest()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost:8002/form/php/gameuser.php"))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.ConnectionError ||
                webRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError(webRequest.error);
            }
            else
            {
                string response = webRequest.downloadHandler.text;
                response = response.Trim();
                Debug.Log("response = " + response);
                string[] sArray = response.Split('a');
                GameData.Past = int.Parse(sArray[0]);
                GameData.DiceNum = int.Parse(sArray[1]);
                Debug.Log("Past = " + GameData.Past);
                Debug.Log("DiceNum = " + GameData.DiceNum);
            }
        }
    }
}