using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Skripts.Minotavr
{
    public class attackMinotavr : StateMachineBehaviour
    {
        float timer;
        List<Transform> minotavrPoints = new List<Transform>();
        NavMeshAgent agent;

        Transform player;
        float chaseRange = 10;
        public override void OnStateEnter(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            timer = 0;
            Transform pointsObject = GameObject.FindGameObjectWithTag("MinotaurPoints").transform;
            foreach (Transform t in pointsObject)
                minotavrPoints.Add(t);

            agent = animator.GetComponent<NavMeshAgent>();
            agent.SetDestination(minotavrPoints[0].position);

            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        public override void OnStateUpdate(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
                agent.SetDestination(minotavrPoints[Random.Range(0, minotavrPoints.Count)].position);

            timer += Time.deltaTime;
            if (timer > 10)
                animator.SetBool("patrolMinotaur", false);

            float distance = Vector3.Distance(animator.transform.position, player.position);
            if (distance < chaseRange)
                animator.SetBool("chaseMinotaur", true);

        }

        public override void OnStateExit(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            agent.SetDestination(agent.transform.position);
        }
    }
}