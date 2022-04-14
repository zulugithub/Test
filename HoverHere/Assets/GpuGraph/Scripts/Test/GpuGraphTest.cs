﻿// © 2016 BRANISLV GRUJIC ALL RIGHTS RESERVED// Provided AS IS// For any official support, please use the contact on the unity asset storeusing System.Collections;using System.Collections.Generic;using UnityEngine;public class GpuGraphTest : MonoBehaviour{    private int Count;    private Rect GraphRect;    private Rect plot2D_graph_rect_2;    // Use this for initialization    void Start()    {        Count = 0;    }        // Update is called once per frame    void Update()    {        Count++;        float xSize = 0.3f * Screen.width;        float ySize = 0.2f * Screen.height;        float xPos = 0.01f * Screen.width;        float yPos = 0.1f * Screen.height;        GraphRect = new Rect(xPos, yPos, xSize, ySize);        yPos = 0.4f * Screen.height;        plot2D_graph_rect_2 = new Rect(xPos, yPos, xSize, ySize);        // calculate current time in ms        float currentDeltaTime =  Mathf.Sin(Time.time * 1000.0f);        float currentDeltaTime2 =  Mathf.Cos(Time.time * 1000.0f);        if (GraphManager.Graph != null && currentDeltaTime < 18.0f)        {            // GraphManager.Graph.Plot("Test_WorldSpace", currentDeltaTime, Color.green, new GraphManager.Matrix4x4Wrapper(transform.position, transform.rotation, transform.localScale));            //GraphManager.Graph.Reset("Test_ScreenSpace");            GraphManager.Graph.Plot("Test_ScreenSpace", currentDeltaTime, Color.green, GraphRect);            GraphManager.Graph.Plot("Test_ScreenSpace2", currentDeltaTime2, Color.green, plot2D_graph_rect_2);        }    }}