using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    //Create reference to the sphere
    public GameObject sphere;

    //This variable stores the distance between the sphere and the camera
    private Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        //Calculate distance between sphere and Main Camera
        distance = transform.position - sphere.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //We reinitialise the postion of camera while we are updating the 
        transform.position = distance + sphere.transform.position;
    }
}
