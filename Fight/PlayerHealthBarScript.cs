using System;
using System.Collections;
using System.Collections.Generic;
using Interface;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Fight
{
    public class PlayerHealthBarScript : MonoBehaviour
    {
        private int HP = 100;
        public UnityEngine.Animator animator;
        public Slider healthBar;
        

        void Update()
        {
            healthBar.value = HP;
        }

        public void PlayerHpUp(int healthAmount)
        {

            if (HP < 100)
            {
                HP += healthAmount;
            }
        }
        public void PlayerTakeDamage(int damageAmount)
        {
            HP -= damageAmount;
            
            if (HP <= 0)
            {
                animator.SetTrigger("death");
                healthBar.gameObject.SetActive(false);
                GetComponent<Collider>().enabled = false;
                // SceneManager.LoadScene("IceLand");
                FindObjectOfType<RestartGame>().ShowRestartPannel();
            }
            else
            {
                // animator.SetTrigger("damage");
            }
        }
    }
}