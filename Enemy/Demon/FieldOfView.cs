using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Skripts.Demon
{
    
    public class FieldOfView : MonoBehaviour
    {
        public float radius;
        [Range(0, 360)]
        public float angle;

        public GameObject playerRef;

        public LayerMask targetMask;
        public LayerMask ObstacleMask;
        public bool canSeePlayer;

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
            if (canSeePlayer == true) gameObject.GetComponent<AI_Demon>().AI_Enemy = AI_Demon.AI_State.Chase;
            else gameObject.GetComponent<AI_Demon>().AI_Enemy = AI_Demon.AI_State.Patrol;
        }

        private void FieldOfViewCheck()
        {
            Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);

            if (rangeChecks.Length != 0)
            {
                Transform target = rangeChecks[0].transform;
                Vector3 directionToTarget = (target.position - transform.position).normalized;

                if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
                {
                    float distanceToTarget = Vector3.Distance(transform.position, target.position);

                    if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, ObstacleMask))
                        canSeePlayer = true;
                    
                    else
                        canSeePlayer = false;
                }
                else
                    canSeePlayer = false;
            }
            else if (canSeePlayer)
                canSeePlayer = false;
        }
    }
}