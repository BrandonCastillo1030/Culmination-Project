using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1Col : MonoBehaviour
{
    public static bool Collided = false;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        Collided = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Collided = false;
    }
}
