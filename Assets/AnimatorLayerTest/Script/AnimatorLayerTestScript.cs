using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorLayerTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;

    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButton1Click()
    {
        animator.SetTrigger("sphere");
    }
    public void OnButton2Click()
    {
        animator.SetTrigger("capsule");
    }

    public void OnButton3Click()
    {
        animator.enabled = !animator.enabled;
    }
}
