﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using NDream.AirConsole;
using UnityEngine.SceneManagement;

public class CreditScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        AirConsole.instance.onMessage += OnMessage;
    }

    void OnMessage(int fromDeviceId, JToken data)
    {
       if (SceneManager.GetActiveScene().name == "YouWin" ||
        SceneManager.GetActiveScene().name == "YouDied") {
          Application.LoadLevel(4);
        }
        
    }
}
