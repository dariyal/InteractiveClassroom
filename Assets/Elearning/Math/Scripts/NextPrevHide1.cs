using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPrevHide1 : MonoBehaviour
{
    public Transform camTransform;

    public GameObject shape1;
    public GameObject shape2;
    public GameObject shape3;

    public Transform target9;
   // public Transform target10;
   // public Transform target11;

    public Transform target12;
  //  public Transform target13;
  //  public Transform target14;

    public Transform target15;
  //  public Transform target16;
  //  public Transform target17;


    public GameObject next1; //1

    public GameObject prev2;
    public GameObject next2; //2

    public GameObject prev3; //3
    public GameObject next3;


    public GameObject front1;
    public GameObject side1;
    public GameObject top1;

    public GameObject front2;
    public GameObject side2;
    public GameObject top2;

    public GameObject front3;
    public GameObject side3;
    public GameObject top3;



    // Start is called before the first frame update
    void Start()
    {
        prev2.SetActive(false);
        next1.SetActive(true);

        next2.SetActive(false);
        prev3.SetActive(false);
        next3.SetActive(false);

        front1.SetActive(true);
        side1.SetActive(true);
        top1.SetActive(true);

        front2.SetActive(false);
        side2.SetActive(false);
        top2.SetActive(false);

        front3.SetActive(false);
        side3.SetActive(false);
        top3.SetActive(false);


        shape1.SetActive(true);
        shape2.SetActive(false);
        shape3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (camTransform.position == target9.position)
        {
            prev2.SetActive(false);
            next1.SetActive(true);
            next2.SetActive(false);
            next3.SetActive(false);

            front1.SetActive(true);
            side1.SetActive(true);
            top1.SetActive(true);

            front2.SetActive(false);
            side2.SetActive(false);
            top2.SetActive(false);

            front3.SetActive(false);
            side3.SetActive(false);
            top3.SetActive(false);


            shape1.SetActive(true);
            shape2.SetActive(false);
            shape3.SetActive(false);
        }
        else if (camTransform.position == target12.position)
        {
            prev2.SetActive(true);
            next1.SetActive(false);
            next2.SetActive(true);
            prev3.SetActive(false);
            next3.SetActive(false);

            front1.SetActive(false);
            side1.SetActive(false);
            top1.SetActive(false);

            front2.SetActive(true);
            side2.SetActive(true);
            top2.SetActive(true);

            front3.SetActive(false);
            side3.SetActive(false);
            top3.SetActive(false);


            shape1.SetActive(false);
            shape2.SetActive(true);
            shape3.SetActive(false);
        }
        else if (camTransform.position == target15.position)
        {
            prev2.SetActive(false);
            next2.SetActive(false);
            prev3.SetActive(true);
            next3.SetActive(true);


            front1.SetActive(false);
            side1.SetActive(false);
            top1.SetActive(false);

            front2.SetActive(false);
            side2.SetActive(false);
            top2.SetActive(false);

            front3.SetActive(true);
            side3.SetActive(true);
            top3.SetActive(true);


            shape1.SetActive(false);
            shape2.SetActive(false);
            shape3.SetActive(true);
        }
    }
}
