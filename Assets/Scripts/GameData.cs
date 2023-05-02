using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

public class GameData : MonoBehaviour
{
    public static int Past;
    public static int DiceNum;

    private async void Start()
    {
        // 發送 HTTP 請求並接收回傳的資料
        string response = await SendHttpRequest();

        // 解析 JSON 格式的回傳資料
        Data[] dataArray = JsonConvert.DeserializeObject<Data[]>(response);
        
        //設定玩家位置和骰子數量
        Data data = new Data();
        Past = data.userlocation;
        DiceNum = data.dice;
    }

    private async Task<string> SendHttpRequest()
    {
        using (HttpClient client = new HttpClient())
        {
            string phpUrl = "../from/php/gameuser.php"; // PHP 程式的網址

            // 發送 GET 請求並接收回應
            HttpResponseMessage response = await client.GetAsync(phpUrl);

            // 確保請求成功
            response.EnsureSuccessStatusCode();

            // 讀取回應內容
            string responseBody = await response.Content.ReadAsStringAsync();

            // 返回回應內容
            return responseBody;
        }
    }

    // 定義一個類別來封裝回傳的資料結構
    public class Data
    {
        public int userlocation { get; set; }
        public int dice { get; set; }
    }
    //Be called when shut down the program 
    void OnDestory()
    {
        
    }
}