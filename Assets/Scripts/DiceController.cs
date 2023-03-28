using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    public int DepartmentNum;
    public int Distance;
    public AudioClip StepSound;
    public AudioClip Scored;
    public Transform Dice;
    public GameObject Player;
    public Sprite DiceOne;
    public Sprite DiceTwo;
    public Sprite DiceThree;
    public Sprite DiceFour;
    public Sprite DiceFive;
    public Sprite DiceSix;
    public Text PlaceName;
    public List<string> PlaceList = new List<string>();

    private AudioSource AudioSource;
    private int StepCount = 0;
    private int Point;
    private int DiceNum;
    private int Past;
    private int ExchangePoint;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        DiceNum = GameData.DiceNum;
        Past = GameData.Past;
        ExchangePoint = GameData.ExchangePoint;
    }

    public void RollDice()
    {
        DiceNum--;
        Point = Random.Range(1, 7);
        switch (Point)
        {
            case 1:
                Dice.GetComponent<Image>().sprite = DiceOne;
                break;
            case 2:
                Dice.GetComponent<Image>().sprite = DiceTwo;
                break;
            case 3:
                Dice.GetComponent<Image>().sprite = DiceThree;
                break;
            case 4:
                Dice.GetComponent<Image>().sprite = DiceFour;
                break;
            case 5:
                Dice.GetComponent<Image>().sprite = DiceFive;
                break;
            case 6:
                Dice.GetComponent<Image>().sprite = DiceSix;
                break;
        }
        InvokeRepeating("Step", 0.5f, 0.5f);
        Dice.GetComponent<Button>().interactable = false;
        Debug.Log(Point);
        DataUpdate();
    }

    public void Step()
    {
        AudioSource.PlayOneShot(StepSound);
        Past++;
        StepCount++;
        if (StepCount == Point)
        {
            CancelInvoke("Step");
            StepCount = 0;
            Dice.GetComponent<Button>().interactable = true;
        }
        if (Past == DepartmentNum)
        {
            AudioSource.PlayOneShot(Scored);
            Past = 0;
            ExchangePoint++;
            Player.transform.position -= new Vector3(0, Distance, 0);
        }
        else if (Past < (DepartmentNum / 4) + 1)
        {
            Player.transform.position -= new Vector3(Distance, 0, 0);
        }
        else if (Past < (DepartmentNum / 2) + 1)
        {
            Player.transform.position += new Vector3(0, Distance, 0);
        }
        else if (Past < ((DepartmentNum / 4) * 3)+1)
        {
            Player.transform.position += new Vector3(Distance, 0, 0);
        }
        else
        {
            Player.transform.position -= new Vector3(0, Distance, 0);
        }
    }

    public void DataUpdate()
    {
        GameData.DiceNum = DiceNum;
        GameData.Past = Past;
        GameData.ExchangePoint = ExchangePoint;
        Debug.Log("GameData.DiceNum = " + GameData.DiceNum);
        Debug.Log("GameData.Past = " + GameData.Past);
        Debug.Log("GameData.ExchangePoint = " + GameData.ExchangePoint);
    }

    void Update()
    {
        PlaceName.text = "" + PlaceList[Past];
        if (DiceNum < 0)
        {
            Dice.GetComponent<Button>().interactable = false;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("GameData Past" + GameData.Past);
        }
    }
}
