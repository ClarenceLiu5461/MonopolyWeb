using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    public int DepartmentNum;
    public int Distance;
    public Transform Dice;
    public GameObject Player;
    public Sprite DiceOne;
    public Sprite DiceTwo;
    public Sprite DiceThree;
    public Sprite DiceFour;
    public Sprite DiceFive;
    public Sprite DiceSix;
    
    private int Past = 0;
    void Start()
    {
        
    }

    public void RollDice()
    {
        int Point = Random.Range(1, 7);
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
        for (int i = 0; i < Point; i++)
        {
            if (Past == DepartmentNum)
            {
                Past = 0;
            }
            Step();
        }
        Debug.Log(Point);
    }

    public void Step()
    {
        if (Past < (DepartmentNum / 4))
        {
            Player.transform.position -= new Vector3(Distance, 0, 0);
        }
        else if (Past < (DepartmentNum / 2))
        {
            Player.transform.position += new Vector3(0, Distance, 0);
        }
        else if (Past < (DepartmentNum / 4) * 3)
        {
            Player.transform.position += new Vector3(Distance, 0, 0);
        }
        else
        {
            Player.transform.position -= new Vector3(0, Distance, 0);
        }
        Past++;
    }

    void Update()
    {
        
    }
}
