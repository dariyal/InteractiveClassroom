using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathSequenceTransition : MonoBehaviour
{

    public GameObject UI0;
    
    // Start is called before the first frame update
    void Start()
    {
        UI0.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetStarted() {
        UI0.SetActive(false);
    }

    public void GoTo1()
    {
        
    }
}
