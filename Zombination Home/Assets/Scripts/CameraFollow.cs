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
       
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.position = new Vector3(transform.position.x, player.transform.position.y);
    }




    /*public Rigidbody2D cameraFollow;
    public float speed;

    void Start()
    {
        cameraFollow = GetComponent<Rigidbody2D>();
    }
    void Awake()
    {
        AirConsole.instance.onMessage += OnMessage;
    }

    void OnMessage(int fromDeviceId, JToken data)
    {
        Debug.Log("Message from " + fromDeviceId + ", Data: " + data);
        if (data["action"] != null && data["action"].ToString().Equals("up"))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if (data["action"] != null && data["action"].ToString().Equals("down"))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }*/
}