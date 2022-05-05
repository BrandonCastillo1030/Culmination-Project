using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScriptController : MonoBehaviour
{

    MovingSphere Swimming;

    Animator animator;
    int isSwimmingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isSwimmingHash = Animator.StringToHash("isSwimming");
    }

    // Update is called once per frame
    void Update()
    {
        bool isSwimming = animator.GetBool(isSwimmingHash);
        
        //idle animation changes to swimming
        if (!isSwimming && MovingSphere.isMoving == true)
        {
            animator.SetBool(isSwimmingHash, true);
        }
        //swimming changes back to idle animation
        if (isSwimming && MovingSphere.isMoving == false)
        {
            animator.SetBool(isSwimmingHash, false);
        }

        if (Input.GetButtonDown("Interact"))
        {
            animator.SetBool("isGrab", true);
        }

        else
        {
            animator.SetBool("isGrab", false);
        }
        
    } 
}
