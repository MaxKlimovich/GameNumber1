using UnityEngine;
using UnityEngine.UI;

namespace Skripts.Minotaur
{
    public class HealthMinotaur : MonoBehaviour
    {
        private int HP = 100;
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
                animator.SetTrigger("deathMinotaur");
                GetComponent<Collider>().enabled = false;
                healthBar.gameObject.SetActive(false);
            }
            else
            {
                animator.SetTrigger("hitMinotaur");
            }
        }
    }
}