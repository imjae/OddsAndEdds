using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript123 : MonoBehaviour
{
    public GameObject go;
    public Transform p;
    // Start is called before the first frame update
    void Start()
    {
        var a = Instantiate(go);
        a.name = "Cube";
        a.transform.SetParent(p);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
