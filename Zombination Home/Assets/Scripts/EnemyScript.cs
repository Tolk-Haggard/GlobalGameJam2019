using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private GameObject target;
    public float speed;
    public bool hitPlayer = false;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        //rotate to look at the player
        transform.LookAt(target.transform.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation


        //move towards the player
        if (Vector3.Distance(transform.position, target.transform.position) > 1f)
        {//move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {

       if (target.GetComponent<PlayerScript>() == null) {
           target = GameObject.FindGameObjectWithTag("Player");
       }

       if (!hitPlayer) {
           hitPlayer = true;

           target.GetComponent<PlayerScript>().health -= 1;
           
       }
    }

}

