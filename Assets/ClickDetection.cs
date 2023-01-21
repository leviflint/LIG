using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Wood;

public class ClickDetection : MonoBehaviour
{

    public Button mouseclick;
    Wood wood = new Wood();

    // Start is called before the first frame update
    void Start()
    {
        mouseclick.onClick.AddListener(TaskOnClick);
        Debug.Log("Listener Started");
    }

    void TaskOnClick()
    {
        wood.SetWood();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
