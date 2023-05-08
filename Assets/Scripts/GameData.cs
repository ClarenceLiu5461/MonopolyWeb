using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


public class GameData : MonoBehaviour
{
    [DllImport("libc.dll")] private static extern void Frobnicate();

    public static int Past;
    public static int DiceNum;

    private async void Start()
    {
        //Debug Past and DiceNum
        Debug.Log(Past);
        Debug.Log(DiceNum);
        // �o�e HTTP �ШD�ñ����^�Ǫ����
        string response = await SendHttpRequest();

        // �ѪR JSON �榡���^�Ǹ��
        Data[] dataArray = JsonConvert.DeserializeObject<Data[]>(response);

        //�]�w���a��m�M��l�ƶq
        Data data = new Data();
        Debug.Log("Past: " + data.userlocation + ", DiceNum: " + data.dice);
        Past = int.Parse(dataArray[0].ToString());
        DiceNum = int.Parse(dataArray[1].ToString());
    }

    private async Task<string> SendHttpRequest()
    {
        using (HttpClient client = new HttpClient())
        {
            // PHP �{�������}
            string phpUrl = "http://localhost:8002/form/php/gameuser.php";

            // �o�e GET �ШD�ñ����^��
            HttpResponseMessage response = await client.GetAsync(phpUrl);

            // �T�O�ШD���\
            response.EnsureSuccessStatusCode();

            // Ū���^�����e
            string responseBody = await response.Content.ReadAsStringAsync();

            // ��^�^�����e
            return responseBody;
        }
    }

    // �w�q�@�����O�ӫʸ˦^�Ǫ���Ƶ��c
    public class Data
    {
        public int userlocation { get; set; }
        public int dice { get; set; }
    }
}