using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Text.RegularExpressions;

public class GameData : MonoBehaviour
{
    public static int Past;
    public static int DiceNum;

    void Start()
    {
        StartCoroutine(SendRequest());
    }
    //Get Past & DiceNum Variable
    IEnumerator SendRequest()
    {
        string strUrl = "http://localhost/monopolyweb.php";

        UnityWebRequest request = UnityWebRequest.Get(strUrl);
        yield return request.SendWebRequest();
        //Connection Error
        if (request.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(request.error);
            yield break;
        }
        //Get DiceNum remain
        string html = request.downloadHandler.text;
        Debug.Log(html);

        var received_data = Regex.Split(html, "</next>");
        Debug.Log("DiceNum = " + html.ToString());
        DiceNum = int.Parse(html);
    }
    //Be called when shut down the program 
    void OnDestory()
    {
        
    }
}