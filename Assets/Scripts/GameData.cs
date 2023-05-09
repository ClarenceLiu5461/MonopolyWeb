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
        using (UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost:8002/form/php/gameuser.php"))
        {
            string response = webRequest.downloadHandler.text;
            Debug.Log("response = " + response);
            string[] sArray = response.Split('a');
            GameData.Past = int.Parse(sArray[0]);
            GameData.DiceNum = int.Parse(sArray[1]);
            Debug.Log("Past = " + int.Parse(sArray[0]));
            Debug.Log("DiceNum = " + int.Parse(sArray[1]));
        }
    }
}