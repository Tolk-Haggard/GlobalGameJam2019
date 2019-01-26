using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using NDream.AirConsole;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void LateUpdate()
    {
       transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}