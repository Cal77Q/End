using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraControl : MonoBehaviour
{
    public GameObject player;



    void Update ()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }

}   
