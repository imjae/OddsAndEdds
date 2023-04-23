using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTriggerTestScript : MonoBehaviour
{
    public Animator animator;

    public void OnRedButtonClick()
    {
        animator.SetTrigger("horizontal");
    }
    public void OnBluesButtonClick()
    {
        animator.SetTrigger("vertical");
    }

    public void OnResetButtonClick()
    {
        for (int i = 0; i < animator.parameters.Length; i++)
        {
            var param = animator.parameters[i];
            if (param.type == AnimatorControllerParameterType.Trigger)
            {
                animator.ResetTrigger(param.name);
            }
        }
    }
}
