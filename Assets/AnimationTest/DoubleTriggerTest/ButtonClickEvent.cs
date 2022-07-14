using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickEvent : MonoBehaviour
{
    public Animator animator;

    public void OnClickChangeColorRed()
    {
        animator.SetTrigger("ChangeColorRed");
    }
    public void OnClickChangeSizeCube()
    {
        animator.SetTrigger("ChangeSizeCube");
    }
    public void OnClickChangeMix()
    {
        animator.SetTrigger("ChangeColorRed");
        animator.SetTrigger("ChangeSizeCube");
    }
}
