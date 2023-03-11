using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Dice;
    public GameObject Player;
    void Start()
    {
        
    }

    public void RollDice()
    {
        int Move = Random.Range(1, 7);
        Debug.Log(Move);
    }

    void Update()
    {
        
    }
}
