using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTestScript : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPositionTrigger()
    {
        animator.SetTrigger("Position");
    }

    public void OnSizeTrigger()
    {
        animator.SetTrigger("Size");
    }

    public void OnComplexTrigger()
    {
        animator.SetTrigger("Position");
        animator.SetTrigger("Size");
    }
}
