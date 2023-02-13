using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour//make the audio clip stay playing
{
    public static GameManager Instance;
    //private Scene scene;

    //public InputField inputField; this doesn't work because im using textmeshpro
    
    public TMP_InputField inputField;// and this works!!!!

    public string userName;
    public string UserName
    {
        get
        {
            if (userName == string.Empty)
                userName = PlayerPrefs.GetString ("playerName", "Player");
            return userName;
        }
        set
        {
            userName = value;
            PlayerPrefs.SetString ("playerName", userName);
        }
    }
    
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
        
        inputField.text = UserName;
    }
    public void SetUserName (string text)
    {
        UserName = text;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && SceneManager.GetActiveScene().buildIndex == 0)
        {
            UserName = inputField.text;
            SceneManager.LoadScene(1);
            Debug.Log("Return key was pressed.");
        }
        
        //audioSource.pitch = newSpeed;
        //audioSource.outputAudioMixerGroup.audioMixer.SetFloat("Pitch", 1f / newSpeed);
        //i want to make the audio's tempo go faster as time goes but failed ToT
    }
}
