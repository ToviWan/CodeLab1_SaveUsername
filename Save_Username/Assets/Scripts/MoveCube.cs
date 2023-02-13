using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCube : MonoBehaviour
{
    public float speed = 1f;
    public float x;
    public float y;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))//move left
        {
            rb.velocity= new (-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))//move right
        {
            rb.velocity= new (speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false)
        {
            rb.velocity = Vector3.zero;//stop move when no keys being pressed
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);//go to scene Minigame2  when green cube and the red blockers hit together 
    }
}
