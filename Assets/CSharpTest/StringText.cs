using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringText : MonoBehaviour
{
    string a;
    string b;
    // Start is called before the first frame update
    void Start()
    {
        a = "asdf";
        b = "asdf";

        Debug.Log($"{a == b}");
        Debug.Log($"{Object.ReferenceEquals(a, b)}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
