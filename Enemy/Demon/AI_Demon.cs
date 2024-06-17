using System;
using System.Collections;
using System.Collections.Generic;
using Interface;
using UnityEngine;
using UnityEngine.AI;

public class AI_Demon : MonoBehaviour
{
    [Header("OBJ")]
    [SerializeField] GameObject Player;
    [SerializeField] GameObject GameOver;
    [Header("Variable")] 
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform[] point;
    [SerializeField] int Carrent_Patch;
    
    [SerializeField] private Transform Last_point;
    public bool Check_Lastpoint;
    [SerializeField] float i_stay;


    public enum AI_State
    {
        Patrol = 1,
        Stay = 2,
        Chase = 3
    }
    public AI_State AI_Enemy;

    
    private void Start()
    {
        AI_Enemy = AI_State.Patrol;
    }

    [System.Obsolete]
    private void FixedUpdate()
    {
        if (Check_Lastpoint == false)
        {
            if (AI_Enemy == AI_State.Patrol)
            {
                agent.Resume();
                gameObject.GetComponent<UnityEngine.Animator>().SetBool("Move", true);
                agent.SetDestination(point[Carrent_Patch].transform.position);
                float Patch_Dist = Vector3.Distance(point[Carrent_Patch].transform.position, gameObject.transform.position);
                if (Patch_Dist < 6)
                {
                    Carrent_Patch++;
                    Carrent_Patch = Carrent_Patch % point.Length;
                }
            }

            if (AI_Enemy == AI_State.Stay)
            {
                agent.Stop();
                gameObject.GetComponent<UnityEngine.Animator>().SetBool("Move", false);
            }

            if (AI_Enemy == AI_State.Chase)
            { 
                gameObject.GetComponent<UnityEngine.Animator>().SetBool("Run", true);
                agent.SetDestination(Player.transform.position);
            }
            else
            {
                gameObject.GetComponent<UnityEngine.Animator>().SetBool("Run", false);
            }

            float Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);
            if (Dist_Player < 2)
            {
                gameObject.GetComponent<UnityEngine.Animator>().SetBool("Attack", true);
            }
            else
                gameObject.GetComponent<UnityEngine.Animator>().SetBool("Attack", false);
        }
        else
        {
            
        }
    }
}
