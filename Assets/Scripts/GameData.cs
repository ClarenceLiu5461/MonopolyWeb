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
        // �o�e HTTP �ШD�ñ����^�Ǫ����
        string response = await SendHttpRequest();

        // �ѪR JSON �榡���^�Ǹ��
        Data[] dataArray = JsonConvert.DeserializeObject<Data[]>(response);
        
        //�]�w���a��m�M��l�ƶq
        Past = dataArray[0].userlocation;
        DiceNum = dataArray[0].dice;
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