using System.Collections;
using UnityEngine;

namespace Skripts.Knight
{
    public class KnightOfView : MonoBehaviour
    {
        public float knightRadius;
                [Range(0, 360)]
                public float knightAngle;
        
                public GameObject playerRef;
        
                public LayerMask knightTargetMask;
                public LayerMask knightObstacleMask;
                public bool knightCanSeePlayer;
        
                private void Start()
                {
                    playerRef = GameObject.FindGameObjectWithTag("Player");
                    StartCoroutine(FOVRoutine());
                }
        
                private IEnumerator FOVRoutine()
                {
                    WaitForSeconds wait = new WaitForSeconds(0.2f);
        
                    while (true)
                    {
                        yield return wait;
                        FieldOfViewCheck();
                    }
                }
                private void FixedUpdate()
                {
                    if (knightCanSeePlayer == true) gameObject.GetComponent<AI_KeyKnight>().AI_Enemy = AI_KeyKnight.AI_State.IsChasing;
                    else gameObject.GetComponent<AI_KeyKnight>().AI_Enemy = AI_KeyKnight.AI_State.IsPatrolling;
                }
        
                private void FieldOfViewCheck()
                {
                    Collider[] rangeChecks = Physics.OverlapSphere(transform.position, knightRadius, knightObstacleMask);
        
                    if (rangeChecks.Length != 0)
                    {
                        Transform target = rangeChecks[0].transform;
                        Vector3 directionToTarget = (target.position - transform.position).normalized;
        
                        if (Vector3.Angle(transform.forward, directionToTarget) < knightAngle / 2)
                        {
                            float distanceToTarget = Vector3.Distance(transform.position, target.position);
        
                            if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, knightObstacleMask))
                                knightCanSeePlayer = true;
                            
                            else
                                knightCanSeePlayer = false;
                        }
                        else
                            knightCanSeePlayer = false;
                    }
                    else if (knightCanSeePlayer)
                        knightCanSeePlayer = false;
                }
    }
}