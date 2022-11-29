using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddEventTestScript : MonoBehaviour
{
    public Button button;

    private void Awake()
    {
        button.onClick.AddListener(ListenerTest);
    }

    public void ListenerTest()
    {
        Debug.Log($"짜잔~");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
