using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HelloWorld2 : MonoBehaviour
{
    [SerializeField]
    private string myName;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    private void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(10, 10, Screen.width, Screen.height),
        "Hello, my name is " + myName);
    }
}