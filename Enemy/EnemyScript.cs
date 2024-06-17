using System;
using System.Collections;
using System.Collections.Generic;
using Skripts;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private GameObject Shock;
    [SerializeField] private Transform Shock_hole;
    // private float timeShots = 0.15f;
    // private float countTime = 0;
    // private float powerShots = 50f;
    // private GameObject ShockBullet;
    
    // void Start()
    // {
    //     InvokeRepeating("Fire", 2f, 1f);
    // }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // countTime += Time.deltaTime; 
        if (other.tag.Equals("Player"))
        {
            // if (countTime >= timeShots )
            // {
            //     countTime = 0;
            //     Shoot();
            // }

            GameObject shock_ins = Instantiate(Shock, Shock_hole.position, Quaternion.identity);
            Shocks s = shock_ins.GetComponent<Shocks>();
            s.SetEnemy(other.gameObject);
        }
    }

    // private void Shoot()
    // {
    //     ShockBullet = Instantiate(Shock, Shock_hole);
    //     ShockBullet.transform.position = Shock.transform.position;
    //     ShockBullet.transform.rotation = Shock.transform.rotation;
    //     ShockBullet.transform.Translate(0,0,3);
    //     ShockBullet.GetComponent<Rigidbody>().AddRelativeForce(ShockBullet.transform.forward * powerShots, ForceMode.VelocityChange);
    // }

    private void OnTriggerStay(Collider other)
    {
        transform.LookAt(other.gameObject.transform.position);
    }
}
