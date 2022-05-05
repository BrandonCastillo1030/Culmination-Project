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
        bool forwardPressed = Input.GetKey("w");
        //idle animation changes to swimming
        if (!isSwimming && forwardPressed)
        {
            animator.SetBool(isSwimmingHash, true);
        }
        //swimming changes back to idle animation
        if (isSwimming && !forwardPressed)
        {
            animator.SetBool(isSwimmingHash, false);
        }

        if (Input.GetKey("e"))
        {
            animator.SetBool("isGrab", true);
        }

        if (!Input.GetKey("e"))
        {
            animator.SetBool("isGrab", false);
        }
    }
}
