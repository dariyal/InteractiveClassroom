using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GlobalValues : MonoBehaviour {

    public float globalPlanetRotationAroundSun = 1.0f;
    public Slider solarSystemSpeedSlider;
    public Slider moonSlider;

    // Use this for initialization
  

    void Update()
    {
        if (moonSlider.isActiveAndEnabled)
        {
            globalPlanetRotationAroundSun = moonSlider.value;
        }
        else
        {
            globalPlanetRotationAroundSun = solarSystemSpeedSlider.value;
        }
    }
	
}
