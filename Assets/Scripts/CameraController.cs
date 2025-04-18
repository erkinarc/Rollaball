using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player; // Reference to the player GameObject
    private Vector3 offset; // Offset from the player position   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - player.transform.position; // Calculate the initial offset
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; // Update the camera position based on the player's position
    }
}
