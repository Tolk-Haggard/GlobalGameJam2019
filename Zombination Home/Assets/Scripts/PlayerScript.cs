using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using NDream.AirConsole;

public class PlayerScript : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D player;
    public float speed;
    public float jump;
    public bool WalkLeft = false;
    public int timer;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
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
            animator.Play("Walkup");
            timer = 5;
        }
        else if (data["action"] != null && data["action"].ToString().Equals("left"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            animator.Play("WalkLeft");
            timer = 5;
            //WalkLeft = true;
        }
        else if (data["action"] != null && data["action"].ToString().Equals("right"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            animator.Play("WalkRight");
            timer = 5;
        }
        else if (data["action"] != null && data["action"].ToString().Equals("down"))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            animator.Play("WalkDown");
            timer = 5;
        }
        
    }

    void Update()
    {
        timer -= 1;
        if(timer <= 0)
        {
            //animator.Play("Idle");
        }
        
    }
}
