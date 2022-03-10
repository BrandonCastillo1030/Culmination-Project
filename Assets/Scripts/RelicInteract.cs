using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicInteract : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Relic = GameManager.Relic + 1;
        this.gameObject.SetActive(false);
        
    }
    
}
