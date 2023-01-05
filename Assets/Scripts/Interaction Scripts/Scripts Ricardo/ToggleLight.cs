using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public List<Light> LightsList = new List<Light>();

    public void ToogleLights()
    {
        for (int i = 0; i < LightsList.Count; i++)
        {
            LightsList[i].enabled = !LightsList[i].enabled;
         //   LightsList[i].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }

    public void ChangeLightColor(ColorData colorData)
    {
        for (int i = 0; i < LightsList.Count; i++)
        {
            LightsList[i].color = colorData.color;
         //   LightsList[i].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }
}
