using UnityEngine;
using UnityEngine.AI;

namespace Skripts.Minotavr
{
    public class chaseMinotavr : StateMachineBehaviour
    {
        NavMeshAgent agent;
        Transform player;
        float attackRange = 2;
        float chaseRange = 10;

        public override void OnStateEnter(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            agent = animator.GetComponent<NavMeshAgent>();
            agent.speed = 2;

            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        public override void OnStateUpdate(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            agent.SetDestination(player.position);
            float distance = Vector3.Distance(animator.transform.position, player.position);
            if (distance < attackRange)
                animator.SetBool("attackMinotaur", true);

        
            if (distance > 10)
                animator.SetBool("chaseMinotaur", false);
        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        public override void OnStateExit(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            agent.SetDestination(agent.transform.position);
            agent.speed = 4;
        }
    }
}