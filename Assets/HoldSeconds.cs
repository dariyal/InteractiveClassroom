using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldSeconds : MonoBehaviour
{
    public GameObject physics;
    public GameObject loading;
    public GameObject earth;
    // Start is called before the first frame update
    void Start()
    {
        physics.SetActive(false);
        loading.SetActive(false);
        earth.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextScreen()
    {
        loading.SetActive(true);
        StartCoroutine(delay());
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);
        loading.SetActive(false);
        physics.SetActive(true);
        earth.SetActive(true);
    }
}
