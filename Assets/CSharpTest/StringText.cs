using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringText : MonoBehaviour
{
    string a;
    string b;

    List<string> stringList;

    int listCount {
        get {
            return stringList.Count;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        stringList = new List<string>();

        int aa = -1;
        int bb = listCount - (UnityEngine.Mathf.Abs(aa) % listCount);
        Debug.Log(b);

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
