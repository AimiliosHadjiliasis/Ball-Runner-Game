using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    //Exit the game
    public void ExitGame()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }
}
