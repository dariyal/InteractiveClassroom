using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitch : MonoBehaviour
{
    public GameObject ui;
    public GameObject uicontent;
    public GameObject hidedui;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public GameObject c7;
    public GameObject c8;
    public GameObject c9;
    public GameObject c10;
    public GameObject orbitspped;
    public GameObject content;
    public GameObject closeFUllScreen;
    public GameObject menuBTn;
    public GameObject moonCam;
    public GameObject closePhasesofmoon;
    public GameObject moonSlider;
    public GameObject phasesofmoon;

    // Start is called before the first frame update
    void Start()
    {
        orbitspped.SetActive(false);
        closeFUllScreen.SetActive(false);
        moonCam.SetActive(false);
        closePhasesofmoon.SetActive(false);
        moonSlider.SetActive(false);
        phasesofmoon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void MainmenuSwitch()
    {
        ui.SetActive(true);
        uicontent.SetActive(true);
        hidedui.SetActive(false);
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        c5.SetActive(false);
        c6.SetActive(false);
        c7.SetActive(false);
        c8.SetActive(false);
        c9.SetActive(false);
        c10.SetActive(false);
    }
    public void FullScreenView()
    {
        content.SetActive(false);
        menuBTn.SetActive(false);

        closeFUllScreen.SetActive(true);
        orbitspped.SetActive(true);

        if (PlanetInfo.moonactive)
        {
            phasesofmoon.SetActive(true);
        }

    }
    public void CloseFullScreenView()
    {
        content.SetActive(true);
        menuBTn.SetActive(true);
    
        closeFUllScreen.SetActive(false);
        orbitspped.SetActive(false);
    }
    public void EnablePhasesofMoon()
    {
        moonCam.SetActive(true);
        content.SetActive(false);
        menuBTn.SetActive(false);
        closePhasesofmoon.SetActive(true);
        moonSlider.SetActive(true);
    }

    public void DisablePhasesofMoon()
    {
        moonCam.SetActive(false);
       // content.SetActive(true);
      //  menuBTn.SetActive(true);
        closePhasesofmoon.SetActive(false);
        moonSlider.SetActive(false);
    }
}
