using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenColorPicker : MonoBehaviour, UsableObjectInterface
{
    public UIMenuManager menuManager;

    public void UseObject(GameObject hitObject)
    {
        OpenPickColor();
    }

    void OpenPickColor()
    {
        menuManager.OpenPickColor();
    }
}
