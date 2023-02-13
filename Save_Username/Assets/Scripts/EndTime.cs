using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndTime : MonoBehaviour
{
    private GameObject gameManager;
    public TextMeshProUGUI endtxt;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        endtxt.text = gameManager.GetComponent<GameManager>().userName + " you survived " + DataHolder.timeTxt;//display the text from the scene MiniGame
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
