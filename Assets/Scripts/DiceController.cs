using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    void Start()
    {
        
    }

    public void Roll()
    {
        int point = Random.Range(1, 7);
        Debug.Log(point);
    }

    void Update()
    {
        
    }
}
