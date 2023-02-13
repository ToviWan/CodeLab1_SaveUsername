using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour//make the audio clip stay playing
{
    public static GameManager Instance;
    //public AudioSource audioSource;
    //float newSpeed = 1.2f;
    
    void Awake()
    {

        if (Instance == null) //Instance has not been set
        {
            DontDestroyOnLoad(gameObject); //don't destroy
            Instance = this; //and set instance to this GameManager
        }
        else //Instance is set
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //audioSource.pitch = newSpeed;
        //audioSource.outputAudioMixerGroup.audioMixer.SetFloat("Pitch", 1f / newSpeed);
        //i want to make the audio's tempo go faster as time goes but failed ToT
    }
}
