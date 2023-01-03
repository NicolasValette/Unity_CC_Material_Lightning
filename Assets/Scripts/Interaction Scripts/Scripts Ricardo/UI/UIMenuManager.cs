using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class UIMenuManager : MonoBehaviour
{
    public GameObject gameMenu;

    public ContextualMenu contextualMenu;

    public GameObject HighlightedObject;


    public void OpenGameMenu()
    {
        if (gameMenu != null)
        {
            gameMenu.SetActive(true); 
        }
    }

    public void CloseGameMenu()
    {
        if (gameMenu != null)
        {
            gameMenu.SetActive(false);
        }
    }

    public void OpenContextualMenu(EnvironmentElement element)
    {
        if (gameMenu != null)
        {
            contextualMenu.SelectedEnvironmentElement = element;
            contextualMenu.gameObject.SetActive(true);
            contextualMenu.CreateListContent(element);
        }
    }


    public void OpenContextualMenu(ObjectSpawner selectedSpawner)
    {
        if (gameMenu != null)
        {
            contextualMenu.SelectedObjectSpawner = selectedSpawner;
            contextualMenu.gameObject.SetActive(true);
            contextualMenu.CreateListContent(selectedSpawner);
        }
    }

    public void OpenContextualMenu(LightData selectedSpawner)
    {
        if (gameMenu != null)
        {
        /*    contextualMenu.SelectedObjectSpawner = selectedSpawner;
            contextualMenu.gameObject.SetActive(true);
            contextualMenu.CreateListContent();*/
        }
    }

    public void CloseContextualMenu()
    {
        contextualMenu.gameObject.SetActive(false);
    }
}
