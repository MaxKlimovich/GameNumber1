using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Stone"))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            
        }
        
    }
}
