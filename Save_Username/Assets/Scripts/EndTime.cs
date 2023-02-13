using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndTime : MonoBehaviour
{
    public TextMeshProUGUI endtxt;
    // Start is called before the first frame update
    void Start()
    {
        endtxt.text = "you survived " + DataHolder.timeTxt;//display the text from the scene MiniGame
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
