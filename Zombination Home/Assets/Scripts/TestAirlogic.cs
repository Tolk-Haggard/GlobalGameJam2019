using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using NDream.AirConsole;

public class TestAirlogic : MonoBehaviour
{
    void Awake()
    {
        AirConsole.instance.onMessage += OnMessage;   
    }

    void OnMessage(int fromDeviceId, JToken data)
    {
        if (data["action"] != null && data["action"].ToString().Equals("interact"))
        {
            Camera.main.backgroundColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }

    void OnDestroy()
    {
      if (AirConsole.instance != null)
        {
            AirConsole.instance.onMessage -= OnMessage;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
