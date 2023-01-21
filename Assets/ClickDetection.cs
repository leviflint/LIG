using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDetection : MonoBehaviour
{

    public Button mouseclick;

    // Start is called before the first frame update
    void Start()
    {
        mouseclick.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You clicked that shit homie!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
