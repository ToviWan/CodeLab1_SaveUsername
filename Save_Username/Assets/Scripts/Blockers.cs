using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Blockers : MonoBehaviour
{
    Vector3 startPos;
    public Vector3 dropSpeed; //set the drop speed of the red blockers
    private float acce;//set up the acceleration to the blocker
    void Start () {
        startPos = transform.position;
    }
    // Update is called once per frame
    void Update ()
    {
        acce += Time.deltaTime;
        transform.position -= dropSpeed * acce;// make the blockers go down on y axis
    }

    private void OnBecameInvisible()//OnBecameVisible is called when the renderer became visible by any camera.
    {
        transform.position = new Vector3(UnityEngine.Random.Range(-28.5f,16f),startPos.y,startPos.z);//make the red blocker appear from a random position between -28.5 to 16
        
    }
}
