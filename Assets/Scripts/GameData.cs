using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Net;

public class GameData : MonoBehaviour
{
    public static int Past;
    public static int DiceNum;

   static void Main()
    {
        //Debug Past and DiceNum
        Debug.Log(Past);
        Debug.Log(DiceNum);
        using (WebClient client = new WebClient())
        {
            string url = "http://localhost:8002/form/php/gameuser.php";
            string response = client.DownloadString(url);

            // 在這裡處理 PHP 回傳的純文字內容
            Console.WriteLine(response);
        }
    }
}