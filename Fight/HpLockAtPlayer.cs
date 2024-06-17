using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpLockAtPlayer : MonoBehaviour
{
    public Transform camera;
    void LateUpdate()
    {
        transform.LookAt(camera);
    }
}
