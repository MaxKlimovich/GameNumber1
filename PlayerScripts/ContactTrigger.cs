using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactTrigger : MonoBehaviour
{
    [SerializeField] private bool Mallet;
    [SerializeField] private bool Grenade;
    [SerializeField] private bool SilverKey;
    [SerializeField] private bool RustKey;
    [SerializeField] private bool Health;
    
    
    
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Bomb"))
        {
            Debug.Log("Boom");
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            other.gameObject.transform.GetChild(1).gameObject.SetActive(false);
            
        }
        
        if (other.tag.Equals("DrumDoor"))
        {
            if (Mallet)
            {
                Vector3 rotation = other.gameObject.transform.eulerAngles;
                rotation.y = 260;
                other.gameObject.transform.eulerAngles = rotation; 
            }
        }
    
        if (other.tag.Equals("DefDoor"))
        {
            if (SilverKey)
            {
                Vector3 rotation = other.gameObject.transform.eulerAngles;
                rotation.y = -250;
                other.gameObject.transform.eulerAngles = rotation; 
            }
        }
        
        if (other.tag.Equals("DwarfDoor"))
        {
            if (RustKey)
            {
                Vector3 rotation = other.gameObject.transform.eulerAngles;
                rotation.y = 70;
                other.gameObject.transform.eulerAngles = rotation; 
            }
        }
        
        if (other.tag.Equals("DestroyTurret"))
        {
            if (Grenade)
            {
                other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
                other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        
        // if (other.tag.Equals("LeftDoor"))
        // {
        //     if (rustKey)
        //     {
        //         Vector3 rotation = other.gameObject.transform.eulerAngles;
        //         rotation.y = -45;
        //         other.gameObject.transform.eulerAngles = rotation; 
        //     }
        // }
        // if (other.tag.Equals("RightDoor"))
        // {
        //     if (rustKey)
        //     {
        //         Vector3 rotation = other.gameObject.transform.eulerAngles;
        //         rotation.y = 245;
        //         other.gameObject.transform.eulerAngles = rotation; 
        //     }
        // }
        
        if (other.tag.Equals("Mallet"))
        {
            Mallet = true;
            other.gameObject.SetActive(false);
        }
        
        if (other.tag.Equals("Grenade"))
        {
            Grenade = true;
            other.gameObject.SetActive(false);
        }
    
        if (other.tag.Equals("SilverKey"))
        {
            SilverKey = true;
            other.gameObject.SetActive(false);
        }
    
        if (other.tag.Equals("RustKey"))
        {
            RustKey = true;
            other.gameObject.SetActive(false);
        }
    
        if (other.tag.Equals("Health"))
        {
            Health = true;
            other.gameObject.SetActive(false);
        }
        
        if (other.tag.Equals("Shocks"))
        { 
            //gameObject.SetActive(false);
            //other.gameObject.SetActive(false);
        }
    
    }
}
