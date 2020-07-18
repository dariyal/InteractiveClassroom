using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideMenuManager : MonoBehaviour
{
    public List<GameObject> objects;
    public Text title;
    public int selecteditem = 0;
    public GameObject next;
    public GameObject previous;
    public GameObject cam;

    bool lerpstartforword = false;
    bool lerpstartBackword = false;
    [SerializeField] private Vector3 target;
    private float targetValue = 0;
    [SerializeField] private float speed = 1;

    public GameObject slider;


    private void Start()
    {
        objects[selecteditem].SetActive(true);
        title.text = objects[selecteditem].gameObject.name;
      target  = new Vector3(targetValue, 0, 0);

    }
    private void Update()
    {
        if (selecteditem == 0)
        {
            previous.SetActive(false);
        }
        else
        {
             previous.SetActive(true);
        }
        if (selecteditem >= objects.Count - 1)
        {
            next.SetActive(false);
        }
        else
        {
             next.SetActive(true);
            // Debug.Log(selecteditem);
            //Debug.Log(objects.Count);
        }

        //if (lerpstartforword)
        //{
        //    //StartCoroutine(MoveForword(1));
        //    cam.transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

        //}
        //if (lerpstartBackword)
        //{
        //    //StartCoroutine(MoveBackword(1));
        //    cam.transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        //}
    }
    public void Next()
    {
        //if (!lerpstartforword)
       // {
            StartCoroutine(MoveForword(1));
           // targetValue = targetValue + 5;
            next.GetComponent<Button>().enabled = false;
           // lerpstartforword = true;

            //cam.transform.position = new Vector3((cam.transform.position.x + 5), cam.transform.position.y, cam.transform.position.z);
            //objects[selecteditem].SetActive(false);
            //objects[selecteditem + 1].SetActive(true);
            title.text = objects[selecteditem + 1].gameObject.name;

            selecteditem = selecteditem + 1;
      //  }

    }
    public void Previous()
    {
        // if (!lerpstartBackword)
        // {
        previous.GetComponent<Button>().enabled = false;
        // lerpstartBackword = true;
        StartCoroutine(MoveBackword(1));
        //cam.transform.position = new Vector3((cam.transform.position.x -5),cam.transform.position.y,cam.transform.position.z);
        //objects[selecteditem].SetActive(false);
        //objects[selecteditem - 1].SetActive(true);
        title.text = objects[selecteditem - 1].gameObject.name;

            selecteditem = selecteditem - 1;
       // }
    }
    IEnumerator MoveForword(float delayTime)
    {

        //yield return new WaitForSeconds(delayTime); // start at time X
        Vector3 oldposition = cam.transform.position;
        Vector3 newPosition = new Vector3(oldposition.x + 5f, oldposition.y, oldposition.z);
        Debug.Log("working");

        float startTime = Time.time; // Time.time contains current frame time, so remember starting point
        while (Time.time - startTime <= 1.05f)
        { // until one second passed
            

            cam.transform.position = Vector3.Lerp(oldposition, newPosition, Time.time - startTime); // lerp from A to B in one second
           
            yield return 3; // wait for next frame
            lerpstartforword = false;
        }
       
        next.GetComponent<Button>().enabled = true;

    }
    IEnumerator MoveBackword(float delayTime)
    {
        //yield return new WaitForSeconds(delayTime); // start at time X
        Vector3 oldposition = cam.transform.position;
        Vector3 newPosition = new Vector3(oldposition.x - 5f, oldposition.y, oldposition.z);
        float startTime = Time.time; // Time.time contains current frame time, so remember starting point
        while (Time.time - startTime <= 1.05f)
        { // until one second passed
          

            cam.transform.position = Vector3.Lerp(oldposition, newPosition, Time.time - startTime); // lerp from A to B in one second
           // Debug.Log(Time.time - startTime);
            yield return 3;// // wait for next frame
            lerpstartBackword = false;
        }
       
        previous.GetComponent<Button>().enabled = true;



    }

   
}
