using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class UIMenuManager : MonoBehaviour
{
    public GameObject gameMenu;

    public ContextualMenu contextualMenu;

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

    public void OpenContextualMenu(ObjectSpawner selectedSpawner)
    {
        if (gameMenu != null)
        {
            contextualMenu.SelectedObjectSpawner = selectedSpawner;
            contextualMenu.gameObject.SetActive(true);
            contextualMenu.CreateListContent();
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
