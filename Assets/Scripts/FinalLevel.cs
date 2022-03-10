using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalLevel : MonoBehaviour
{
    public GameObject Relic;
    public Text text;
    private bool check = false;
    public bool check2 = false;
    

    // Start is called before the first frame update
    void Start()
    {
        Relic.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        text.gameObject.SetActive(true);
        check = true;
    }

    private void OnTriggerExit(Collider other)
    {
        text.gameObject.SetActive(false);
        check = false;
    }
    // Update is called once per frame
    void Update()
    {
        


        if (check2 == false && check == true  && GameManager.Relic == 3)
        {
            if (Input.GetButtonDown("Interact"))
            {
                Relic.gameObject.SetActive(true);
                GameManager.Placed = GameManager.Placed + 1;
                check2 = true;
            }
        }
    }


 
    }

