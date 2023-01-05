using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class UIMenuManager : MonoBehaviour
{
    public GameObject gameMenu;

    public ContextualMenu contextualMenu;

    public GameObject HighlightedObject;

    public List<InteractableLight> LightsList = new List<InteractableLight>();

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

            UnlockMouse();
        }
    }


    public void OpenContextualMenu(ObjectSpawner selectedSpawner)
    {
        if (gameMenu != null)
        {
            contextualMenu.SelectedObjectSpawner = selectedSpawner;
            contextualMenu.gameObject.SetActive(true);
            contextualMenu.CreateListContent(selectedSpawner);

            UnlockMouse();
        }
    }

    public void OpenContextualMenu(LightData selectedSpawner)
    {
        if (gameMenu != null)
        {
            /*    contextualMenu.SelectedObjectSpawner = selectedSpawner;
                contextualMenu.gameObject.SetActive(true);
                contextualMenu.CreateListContent();*/

            UnlockMouse();
        }
    }

    public void CloseContextualMenu()
    {
        contextualMenu.gameObject.SetActive(false);

        LockMouse();
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    void LockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
