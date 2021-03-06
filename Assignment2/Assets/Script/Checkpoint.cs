﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Renderer theRend;
    public Material cpOn;
    public Material cpOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void CheckpointOn()
    {
        Checkpoint[] checkpoints = FindObjectsOfType<Checkpoint>();
        foreach (Checkpoint cp in checkpoints)
        {
            cp.CheckpointOff();
        }
        theRend.material = cpOn;
    }
    public void CheckpointOff()
    {
        theRend.material = cpOff;
    }
}
