using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayTime : MonoBehaviour
{
    public TextMeshProUGUI timetxt;

    private float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        float minutes = Mathf.FloorToInt(t / 60);
        float seconds = Mathf.FloorToInt(t % 60);
        timetxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        DataHolder.timeTxt = timetxt.text;// get the time text from this scene and store it into DataHolder
    }
}
