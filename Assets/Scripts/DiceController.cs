using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    public int SceneNum;
    public AudioClip StepSound;
    public AudioClip Choosed;
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
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        Past = GameData.Past;
        DiceNum = GameData.DiceNum;
        Player.transform.position = MapGenerator.ObjectList[Past].transform.position;
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
    }

    public void Step()
    {
        AudioSource.PlayOneShot(StepSound); //Play move audio one time
        Past++; //Player progress +1
        StepCount++; //Player step +1
        Player.transform.position = MapGenerator.ObjectList[Past].transform.position;
        //Set Past = 0 when player reach the start point
        if (Past == SceneNum - 1)
        {
            Past = 0;
        }
        //InvokeRepeating stop condition
        if (StepCount == Point)
        {
            CancelInvoke("Step");
            StepCount = 0;
            Dice.GetComponent<Button>().interactable = true;
            AudioSource.PlayOneShot(Choosed);
        }
    }

    void Update()
    {
        //Display scene name
        PlaceName.text = "" + PlaceList[Past];
        //Disable Dice funtion when player has run out of Dice 
        if (DiceNum <= 0)
        {
            Dice.GetComponent<Button>().interactable = false;
        }
    }
    //Called this function when progress shutted down
    private void OnDestroy()
    {
        //Synchronize GameData
        GameData.DiceNum = DiceNum;
        GameData.Past = Past;
    }
}
