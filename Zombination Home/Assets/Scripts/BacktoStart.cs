using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using NDream.AirConsole;

public class BacktoStart : MonoBehaviour
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
        Debug.Log("Message from " + fromDeviceId + ", Data: " + data);
        Application.LoadLevel(0);
        AirConsole.instance.onMessage -= OnMessage;
    }
}

