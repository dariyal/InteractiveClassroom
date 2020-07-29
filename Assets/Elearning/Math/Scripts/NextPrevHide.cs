using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPrevHide : MonoBehaviour
{
    public Transform camTransform;

    public Transform target5;
    public Transform target6;
    public Transform target7;
    public Transform target8;


    public GameObject next1; //1

    public GameObject prev2;
    public GameObject next2; //2

    public GameObject prev3;
    public GameObject next3; //3

    public GameObject prev4; //4


    // Start is called before the first frame update
    void Start()
    {
        prev2.SetActive(false);
        next1.SetActive(true);

        next2.SetActive(false);
        prev3.SetActive(false);
        next3.SetActive(false);
        prev4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (camTransform.position == target5.position)
        {
            prev2.SetActive(false);
            next1.SetActive(true);
            next2.SetActive(false);
        }
        else if (camTransform.position == target6.position)
        {
            prev2.SetActive(true);
            next1.SetActive(false);
            next2.SetActive(true);
            prev3.SetActive(false);
            next3.SetActive(false);
        }
        else if (camTransform.position == target7.position)
        {
            prev2.SetActive(false);
            next2.SetActive(false);
            prev3.SetActive(true);
            next3.SetActive(true);
            prev4.SetActive(false);
        }
        else if (camTransform.position == target8.position) {
            prev3.SetActive(false);
            next3.SetActive(false);
            prev4.SetActive(true);
        }
    }
}
