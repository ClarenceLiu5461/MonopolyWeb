using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationDisplay : MonoBehaviour
{
    public List<string> urlList = new List<string>();
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OpenURL()
    {
        Application.OpenURL(urlList[GameData.Past]);
    }
}
