﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    float time = 0; // [sec]
    const float time_on = 0.5f; // [sec]
    const float time_off = 1.0f; // [sec]
    bool light_status_flag = false;

    private Helicopter_Main Helicopter_Main;

    void Awake()
    {
        Helicopter_Main = GameObject.Find("Game_Controller").GetComponent<Helicopter_Main>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Helicopter_Main.position_lights_state)
        {
            case Helicopter_Main.Position_Lights_Status_Variants.off:
                {
                    this.gameObject.GetComponent<Light>().enabled = false;
                    break;
                }
            case Helicopter_Main.Position_Lights_Status_Variants.blinking:
                {
                    if (Time.time > time)
                    {
                        light_status_flag ^= true;
                        if (light_status_flag == true)
                            time = Time.time + time_on;
                        else
                            time = Time.time + time_off;
                        this.gameObject.GetComponent<Light>().enabled = light_status_flag;
                    }
                    break;
                }
            case Helicopter_Main.Position_Lights_Status_Variants.on:
                {
                    this.gameObject.GetComponent<Light>().enabled = true;
                    break;
                }
            default: break;
        }

    }

}
