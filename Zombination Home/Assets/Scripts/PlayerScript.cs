using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using NDream.AirConsole;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody2D player;
    public float speed;
    public float jump;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
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
        else if (data["action"] != null && data["action"].ToString().Equals("left"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (data["action"] != null && data["action"].ToString().Equals("right"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (data["action"] != null && data["action"].ToString().Equals("down"))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    void Update()
    {
        
    }
}
