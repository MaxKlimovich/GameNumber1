using Interface;
using UnityEngine;
using UnityEngine.UI;

namespace Skripts.Demon
{
    public class HealthDemonEnd : MonoBehaviour
    {
        private int HP = 200;
        public UnityEngine.Animator animator;
        public Slider healthBar;
    
        void FixedUpdate()
        {
            healthBar.value = HP;
        }

        public void TakeDamage(int damageAmount)
        {
            HP -= damageAmount;

            if (HP <= 0)
            {
                animator.SetTrigger("death");
                healthBar.gameObject.SetActive(false);
                GetComponent<CapsuleCollider>().enabled = false;
                FindObjectOfType<TheEnd>().ShowTheEnd();

            }
            else
            {
                animator.SetTrigger("damage");
            }
        }
    }
}