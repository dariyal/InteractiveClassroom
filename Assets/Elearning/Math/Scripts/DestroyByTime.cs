﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{

    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        lifeTime = 20f;
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
