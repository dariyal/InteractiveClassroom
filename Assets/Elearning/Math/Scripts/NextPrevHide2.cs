using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPrevHide2 : MonoBehaviour
{
    public Transform camTransform;


    public Transform target18;
    public Transform target19;


    public GameObject q1;
    public GameObject Option1_1;
    public GameObject Option1_2;
    public GameObject Option1_3;

    public GameObject q2;
    public GameObject Option2_1;
    public GameObject Option2_2;
    public GameObject Option2_3;

    public GameObject panel1;
    public GameObject panel2;

    // Start is called before the first frame update
    void Start()
    {

        q1.SetActive(true);
        Option1_1.SetActive(true);
        Option1_2.SetActive(true);
        Option1_3.SetActive(true);

        q2.SetActive(false);
        Option2_1.SetActive(false);
        Option2_2.SetActive(false);
        Option2_3.SetActive(false);

        panel1.SetActive(false);
        panel2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (camTransform.position == target18.position)
        {
            q1.SetActive(true);
            Option1_1.SetActive(true);
            Option1_2.SetActive(true);
            Option1_3.SetActive(true);

            q2.SetActive(false);
            Option2_1.SetActive(false);
            Option2_2.SetActive(false);
            Option2_3.SetActive(false);
        }
        else if (camTransform.position == target19.position)
        {
            q1.SetActive(false);
            Option1_1.SetActive(false);
            Option1_2.SetActive(false);
            Option1_3.SetActive(false);

            q2.SetActive(true);
            Option2_1.SetActive(true);
            Option2_2.SetActive(true);
            Option2_3.SetActive(true);
        }
    }

    public void ShowPanel1() {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void ShowPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
}
