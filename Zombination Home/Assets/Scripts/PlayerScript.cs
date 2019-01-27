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
    public int health = 6;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Awake()
    {
        AirConsole.instance.onMessage += OnMessage;
    }

    void OnDestroy() {
        AirConsole.instance.onMessage -= OnMessage;
    }

    void OnMessage(int fromDeviceId, JToken data)
    {
        
       if (player == null || animator == null) {
       Debug.Log("PLAYER SCRIPT  was null Message from " + fromDeviceId + ", Data: " + data);
              return;
        }
       
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
    void OnCollisionEnter2D(Collision2D col){

        if (col.gameObject.tag == "House"){
            Application.LoadLevel("YouWin");
        }
    }

    void Update()
    {
        if (health <= 0){
           Application.LoadLevel("YouDied");
        }
    }
}

