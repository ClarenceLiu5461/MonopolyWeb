using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;

public class GameData : MonoBehaviour
{
    public static int Past;
    public static int DiceNum;

    void Awake()
    {
        using (WebClient client = new WebClient())
        {
            string url = "http://localhost:8002/form/php/gameuser.php";
            string response = client.DownloadString(url);

            // �b�o�̳B�z PHP �^�Ǫ��¤�r���e
            Console.WriteLine(response);
            string[] sArray = response.Split('a');
            GameData.Past = int.Parse(sArray[0]);
            GameData.DiceNum = int.Parse(sArray[1]);
            Debug.Log("Past = "+ int.Parse(sArray[0]));
            Debug.Log("DiceNum = "+ int.Parse(sArray[1]));
        }
    }
}