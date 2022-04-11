using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RelicPlaced : MonoBehaviour
{
    public GameObject InteractArea;
    // Start is called before the first frame update
    void Start()
    {
        InteractArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (GameManager.Relic == 3) 
        {
            InteractArea.SetActive(true);
        }
        
        if (GameManager.Placed < 3 && Input.GetButtonDown("Interact")) 
        {
            GameManager.Placed = GameManager.Placed++;
            Destroy(InteractArea);
        }
    }
}
