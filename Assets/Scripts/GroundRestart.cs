using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundRestart : MonoBehaviour
{
    //Whenever player come in contact with this cube we restart the scene
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("MainScene");
    }    
}
