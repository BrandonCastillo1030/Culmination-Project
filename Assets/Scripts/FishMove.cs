using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{public Transform[] swimPoints;

    
    // Start is called before the first frame update
    void Start()
    {
        //swimPoints instantiate = startPoint
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(startPoint, endPoint, Time.deltaTime * 10);
        //transform.LookAt(endPoint);
    }
    

    void SetFishDesrination()
    {
        int index = Random.Range(0, swimPoints.Length);
        Vector3 startPoint = transform.position;
        Vector3 endPoint = swimPoints[index].position;


        
    }
}
