using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tsst : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Animator>().speed = 1;
        }
    }

    public void animaationtest()
    {
        this.GetComponent<Animator>().speed = 0;    }

}
