using UnityEngine;

namespace Skripts.Minotavr
{
    public class IdleMinotaur : StateMachineBehaviour
    {
        float timer;
        Transform player;
        float chaseRange = 10;
        public override void OnStateEnter(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            timer = 0;
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        public override void OnStateUpdate(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            timer += Time.deltaTime;
            if (timer > 5)
                animator.SetBool("patrolMinotaur", true);

            float distance = Vector3.Distance(animator.transform.position, player.position);
            if (distance < chaseRange)
                animator.SetBool("chaseMinotaur", true);

        }
        public override void OnStateExit(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }
    }
}