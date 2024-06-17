using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class TimeStay : MonoBehaviour
{
    [Header("Object")] 
    [SerializeField] GameObject Demon;

    private void Start()
    {
        Invoke("Time", 3f);
    }

    void Time()
    {
        int random;
        random = Random.Range(0, 15);
        if (random > 8)
        {
            Demon.GetComponent<AI_Demon>().AI_Enemy = AI_Demon.AI_State.Stay;
            Invoke("Going", 5f);
        }
        else
        {
            Invoke("Time", 3f);
        }
    }

    void Going()
    {
        Demon.GetComponent<AI_Demon>().AI_Enemy = AI_Demon.AI_State.Patrol;
        Invoke("Time", 0f);
    }
}
