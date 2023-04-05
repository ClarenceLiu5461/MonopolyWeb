using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverlookController : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Camera2;
    public Text btnText;
    public GameObject Dice;

    public void Overlook()
    {
        if (btnText.text == "¥þ´º")
        {
            MainCamera.SetActive(false);
            Dice.SetActive(false);
            Camera2.SetActive(true);
            btnText.text = "³¡¤À";
        }
        else if (btnText.text == "³¡¤À")
        {
            Camera2.SetActive(false);
            Dice.SetActive(true);
            MainCamera.SetActive(true);
            btnText.text = "¥þ´º";
        }
    }
}
