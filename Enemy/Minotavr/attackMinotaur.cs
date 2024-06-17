using UnityEngine;

public class attackMinotavr : StateMachineBehaviour
{
    Transform player;
    public override void OnStateEnter(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void OnStateUpdate(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.LookAt(player);
        float distance = Vector3.Distance(animator.transform.position, player.position);
        if (distance > 3)
            animator.SetBool("attackMinotaur", false);

        if (distance > 15)
            animator.SetBool("chaseMinotaur", false);
    }

    public override void OnStateExit(UnityEngine.Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}