using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine.UI;

public class PlanetInfo : MonoBehaviour {

    private List<string> infoList { get; set; }
    public Text contentText;
    public Text planetNameText;
    private RectTransform rectTransform;
    public float dpi = 5;
    private PlanetSwitch planetSwitchScript;

    public Text Title;
    public GameObject UI;
    public GameObject cam;
    public GameObject infoui;

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

    public static bool moonactive;

    // Use this for initialization
    void Start () {
        rectTransform = contentText.GetComponent<RectTransform>();
        planetSwitchScript = gameObject.AddComponent<PlanetSwitch>();
        planetSwitchScript.SunLight = GameObject.Find("SunLight").GetComponent<Light>();
        moonactive = false;
    }

    public void LoadTextToScrollBar(string name)
    {
        object resourceFile = Resources.Load(name);
        
        // clear content
        contentText.text = string.Empty;

        if(resourceFile != null)
        {
            // mobile, desktop and webgl
            resourceFile = resourceFile.ToString().Replace("TAB", "\t");
            contentText.text += resourceFile;
            
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, resourceFile.ToString().Length * dpi);
        }
        else
        {
            // No info for planet - please add PlanetName.txt to SolarSystem/PlanetInfo
            contentText.text = string.Format("Please add {0}.txt to Resources folder", name);
        }

        planetNameText.text = name;
        planetSwitchScript.AssignPlanetCameraCoordinates(name);
    }

    public void StartTour()
    {
        UI.SetActive(false);
        cam.SetActive(false);

        infoui.SetActive(true);

        if (Title.text == "SUN")
        {
            c1.SetActive(true);
           
        }
        if (Title.text == "MERCURY")
        {
            c2.SetActive(true);
            
        }
        if (Title.text == "VENUS")
        {
            c3.SetActive(true);
           
        }
        if (Title.text == "EARTH")
        {
            c4.SetActive(true);
           
        }
        if (Title.text == "MOON")
        {
            c5.SetActive(true);
           
            moonactive = true;
        }
        else
        {
            moonactive = false;
        }
        if (Title.text == "MARS")
        {
            c6.SetActive(true);
           
        }
        if (Title.text == "JUPITER")
        {
            c7.SetActive(true);
           
        }
        if (Title.text == "SATURN")
        {
            c8.SetActive(true);
            
        }
        if (Title.text == "URANUS")
        {
            c9.SetActive(true);
            
        }
        if (Title.text == "NEPTUNE")
        {
            c10.SetActive(true);
            
        }
      

        planetSwitchScript.AssignPlanetCameraCoordinates(Title.text);
          
    }
}
