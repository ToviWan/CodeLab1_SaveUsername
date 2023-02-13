using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void ReplayButton()
    {
        SceneManager.LoadScene(1);
        Debug.Log("replayed");
    }
}
