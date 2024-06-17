using UnityEngine;
using UnityEngine.AI;

namespace Skripts
{
    public class AI_KeyKnight : MonoBehaviour
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
                IsPatrolling = 1,
                Idle = 2,
                IsChasing = 3
            }
            public AI_State AI_Enemy;
        
            
            private void Start()
            {
                AI_Enemy = AI_State.IsPatrolling;
            }
        
            [System.Obsolete]
            private void FixedUpdate()
            {
                if (Check_Lastpoint == false)
                {
                    if (AI_Enemy == AI_State.IsPatrolling)
                    {
                        agent.Resume();
                        gameObject.GetComponent<UnityEngine.Animator>().SetBool("IsPatrolling", true);
                        agent.SetDestination(point[Carrent_Patch].transform.position);
                        float Patch_Dist = Vector3.Distance(point[Carrent_Patch].transform.position, gameObject.transform.position);
                        if (Patch_Dist < 6)
                        {
                            Carrent_Patch++;
                            Carrent_Patch = Carrent_Patch % point.Length;
                        }
                    }
        
                    if (AI_Enemy == AI_State.Idle)
                    {
                        agent.Stop();
                        gameObject.GetComponent<UnityEngine.Animator>().SetBool("IsPatrolling", false);
                    }
        
                    if (AI_Enemy == AI_State.IsChasing)
                    { 
                        gameObject.GetComponent<UnityEngine.Animator>().SetBool("IsChasing", true);
                        agent.SetDestination(Player.transform.position);
                    }
                    else
                    {
                        gameObject.GetComponent<UnityEngine.Animator>().SetBool("IsChasing", false);
                    }
        
                    float Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);
                    if (Dist_Player < 2)
                    {
                        gameObject.GetComponent<UnityEngine.Animator>().SetBool("IsAttacking", true);
                    }
                    else
                        gameObject.GetComponent<UnityEngine.Animator>().SetBool("IsAttacking", false);
                }
                else
                {
                    
                }
            }
    }
}