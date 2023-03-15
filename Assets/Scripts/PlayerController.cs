using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform Dice;
    public GameObject Player;
    public Sprite DiceOne;
    public Sprite DiceTwo;
    public Sprite DiceThree;
    public Sprite DiceFour;
    public Sprite DiceFive;
    public Sprite DiceSix;
    void Start()
    {
        
    }

    public void RollDice()
    {
        int Move = Random.Range(1, 7);
        switch (Move)
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
        Debug.Log(Move);
    }

    void Update()
    {
        
    }
}
