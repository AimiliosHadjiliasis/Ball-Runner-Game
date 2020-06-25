using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoins : MonoBehaviour
{

    Vector3 turnCoins;
    float speed = 5.0f;
    float height = 0.5f;

    // Update is called once per frame
    void Update()
    {
        turnCoins = new Vector3(45,0,0);
        //Rotate the coins:
        transform.Rotate(turnCoins * Time.deltaTime);

    }
}
