using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorLayerTestScript : MonoBehaviour
{
    private enum TestEnum
    {
        a = 0,
        b = 2,
        c = 1
    }

    // Start is called before the first frame update
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;

    public Animator animator;

    void Start()
    {
        string[] ar = Enum.GetNames(typeof(TestEnum));
        foreach (var item in ar)
        {
            Debug.Log($"{item}");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButton1Click()
    {
        animator.SetTrigger("sphere");
        animator.SetTrigger("cube");
        // animator.Play("sphere");
        // animator.Play("cube");
    }
    public void OnButton2Click()
    {
        animator.SetTrigger("capsule");
    }

    public void OnButton3Click()
    {
        animator.enabled = !animator.enabled;
    }

    public void OnResetClick()
    {
        animator.ResetTrigger("cube");
        animator.ResetTrigger("sphere");
        animator.ResetTrigger("capsule");
    }
}
