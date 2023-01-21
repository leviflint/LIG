using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Wood;

public class WoodCounter : MonoBehaviour
{
    Text woodText;
    Wood wood = new Wood();

    // Start is called before the first frame update
    void Start()
    {
        woodText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        woodText.text = "Wood: " + wood.GetWood();
        Debug.Log(wood.GetWood());
    }
}
