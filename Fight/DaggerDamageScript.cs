using System;
using System.Collections;
using System.Collections.Generic;
using Skripts.Demon;
using Skripts.Minotaur;
using Skripts.Minotavr;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Fight
{
    public class DaggerDamageScript : MonoBehaviour
    {
        public int damageAmount = 5;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Enemy")
            {
                other.GetComponent<EnemyHealthBar>().TakeDamage(damageAmount);
            }
            else if (other.tag == "Demon")
            {
                other.GetComponent<HealthDemon>().TakeDamage(damageAmount);
            }
            else if (other.tag == "DemonEnd")
            {
                other.GetComponent<HealthDemonEnd>().TakeDamage(damageAmount);
            }
            else if (other.tag == "DemonStart")
            {
                other.GetComponent<HealthDemonStart>().TakeDamage(damageAmount);
            }
            else if (other.tag == "Minotaur")
            {
                other.GetComponent<HealthMinotaur>().TakeDamage(damageAmount);
            }
        }
    }
}