using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    public Animator animator;

    public void OnClickAnim1Button()
    {
        animator.ResetTrigger("anim1");
        animator.SetTrigger("anim1");
    }

    public void OnClickAnim2Button()
    {
        animator.SetTrigger("anim2");
    }
    public void OnClickIdleButton()
    {
        animator.SetTrigger("Idle");
    }
}
