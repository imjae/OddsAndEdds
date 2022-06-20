using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator.SetInteger("intTrigger", -1);
    }

    public void OnClickAnim1Button()
    {
        // animator.ResetTrigger("anim1");
        animator.SetTrigger("anim1");
        // animator.SetInteger("intTrigger", 1);
        // animator.SetInteger("intTrigger", -1);

    }

    public void OnClickAnim2Button()
    {
        animator.SetTrigger("anim2");
        // animator.SetInteger("intTrigger", 2);
        // animator.SetInteger("intTrigger", -1);
    }
    public void OnClickIdleButton()
    {
        animator.SetTrigger("Idle");
        // animator.SetInteger("intTrigger", 0);
        // animator.SetInteger("intTrigger", -1);
    }
}
