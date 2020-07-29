using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class UICamMovement : MonoBehaviour
{
    public float speed;
    public float speedForRotAround;

    public float transitionDuration1 = 2f;
    public float transitionDuration2 = 2f;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    public Transform target7;
    public Transform target8;
    public Transform target9;
    public Transform target10;
    public Transform target11;
    public Transform target12;
    public Transform target13;
    public Transform target14;
    public Transform target15;
    public Transform target16;
    public Transform target17;
    public Transform target18;
    public Transform target19;


    public GameObject spawnerObject;
    public GameObject spawnedObjects;

    bool bool1;
    bool bool2;

    int switchInt;

    public GameObject playAnim1;
    public GameObject playAnim2;
    public GameObject SSUI5_1;
    public GameObject WSUI5_2;
    public GameObject WSObjs5;

    public GameObject SSUI6;
    public GameObject SSUI7; 

    // Start is called before the first frame update
    void Start()
    {
        bool1 = false;
        bool2 = false;
        switchInt = 0;
        SSUI5_1.SetActive(false);
        WSUI5_2.SetActive(false);
        WSObjs5.SetActive(false);

        SSUI6.SetActive(false);
        SSUI7.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!bool1)
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        else
        {
            speed = 0f;
            Destroy(spawnerObject);
            Destroy(spawnedObjects, 5f);
            if (this.transform.position == target1.position)
            {
                playAnim1.GetComponent<Animator>().SetBool("Play1", true);
            }
            else if (this.transform.position == target3.position)
            {
                playAnim2.GetComponent<Animator>().SetBool("Play2", true);
            }
            else if (this.transform.position == target5.position) {
                SSUI5_1.SetActive(true);
                WSUI5_2.SetActive(true);
                WSObjs5.SetActive(true);
            }
            else if (this.transform.position == target9.position)
            {
              
                SSUI6.SetActive(true);
            }
            else if (this.transform.position == target18.position)
            {

                SSUI7.SetActive(true);
            }

        } 
        if (bool2) {
            StartCoroutine(Transition0());
            bool2 = false;
        }
    }



    IEnumerator Transition0()
    {
        if (switchInt == 1)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration1);

                transform.position = Vector3.Lerp(startingPos, target1.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target1.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 2) {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target2.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target2.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 3)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target3.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target3.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 4)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target4.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target4.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 5)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target5.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target5.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 6)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target6.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target6.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 7)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target7.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target7.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 8)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target8.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target8.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 9)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target9.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target9.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 10)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target10.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target10.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 11)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target11.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target11.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 12)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target12.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target12.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 13)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target13.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target13.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 14)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target14.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target14.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 15)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target15.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target15.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 16)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target16.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target16.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 17)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target17.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target17.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 18)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target18.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target18.rotation, t);

                yield return 0;
            }
        }
        else if (switchInt == 19)
        {
            float t = 0.0f;
            Vector3 startingPos = transform.position;
            Quaternion startingRot = transform.rotation;
            while (t < 1.0f)
            {
                t += Time.deltaTime * (Time.timeScale / transitionDuration2);

                transform.position = Vector3.Lerp(startingPos, target19.position, t);
                transform.rotation = Quaternion.Lerp(startingRot, target19.rotation, t);

                yield return 0;
            }
        }
    }


    public void GoTo1() {
        bool1 = true;
        switchInt = 1;
        bool2 = true;
    }

    public void GoTo2() {
        switchInt = 2;
        bool2 = true;
    }
    public void GoTo3() {
        switchInt = 3;
        bool2 = true;
    }
    public void GoTo4()
    {
        switchInt = 4;
        bool2 = true;
    }
    public void GoTo5() {
        switchInt = 5;
        bool2 = true;
    }
    public void GoTo6()
    {
        switchInt = 6;
        bool2 = true;
    }
    public void GoTo7()
    {
        switchInt = 7;
        bool2 = true;
    }
    public void GoTo8()
    {
        switchInt = 8;
        bool2 = true;
    }
    public void GoTo9()
    {
        SSUI5_1.SetActive(false);
        WSUI5_2.SetActive(false);
        WSObjs5.SetActive(false);
        switchInt = 9;
        bool2 = true;
    }
    public void GoTo10()
    {
        switchInt = 10;
        bool2 = true;
    }
    public void GoTo11()
    {
        switchInt = 11;
        bool2 = true;
    }
    public void GoTo12()
    {
        switchInt = 12;
        bool2 = true;
    }
    public void GoTo13()
    {
        switchInt = 13;
        bool2 = true;
    }
    public void GoTo14()
    {
        switchInt = 14;
        bool2 = true;
    }
    public void GoTo15()
    {
        switchInt = 15;
        bool2 = true;
    }
    public void GoTo16()
    {
        switchInt = 16;
        bool2 = true;
    }
    public void GoTo17()
    {
        switchInt = 17;
        bool2 = true;
    }
    public void GoTo18()
    {
        SSUI6.SetActive(false);
        switchInt = 18;
        bool2 = true;
    }
    public void GoTo19()
    {
        switchInt = 19;
        bool2 = true;
    }
}
