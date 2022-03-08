using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    [SerializeField]
    public GameObject Pillar1;
    public float rotationSpeed = 20;
    bool collided;
    bool isturned = false;
    public float degreesPerSecond = .1f;
    void Start()
    {
        //Set the tag of this GameObject to Player
        gameObject.tag = "Puzzle";
    }

    private void OnTriggerEnter(Collider other)
    {
        collided = true;

    }

    private void OnTriggerExit(Collider other)
    {

        collided = false;
    }

    void Update()
    {
        float T = Pillar1.transform.eulerAngles.y;

            if (collided)
            {
                Pillar1.transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));

                Debug.Log(T);
                isturned = true;
            }
        
    }

}

