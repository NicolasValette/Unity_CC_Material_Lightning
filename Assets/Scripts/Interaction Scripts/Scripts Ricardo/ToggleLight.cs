using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour, UsableObjectInterface
{
    public UIMenuManager menuManager;

    public void OnEnable()
    {      
        if (menuManager == null) menuManager = FindObjectOfType<UIMenuManager>();
    }

    public void UseObject(GameObject hitObj)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("test lights");

            ToogleLights();

            //   if (transform.GetComponent<rend>) ;
        }

    }

   

    public void ToogleLights()
    {
        for (int i = 0; i < menuManager.LightsList.Count; i++)
        {
            menuManager.LightsList[i].GetComponent<Light>().enabled = !menuManager.LightsList[i].GetComponent<Light>().enabled;
            menuManager.LightsList[i].EmissionRenderer.material.DisableKeyword("_EMISSION");
        }
    }

    public void ChangeLightColor(ColorData colorData)
    {
        for (int i = 0; i < menuManager.LightsList.Count; i++)
        {
            menuManager.LightsList[i].GetComponent<Light>().color = colorData.color;
            //   LightsList[i].EmissionRenderer.material.DisableKeyword("_EMISSION");
        }
    }
}
