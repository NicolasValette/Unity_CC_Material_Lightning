using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void OpenContextualMenu()
    {
        if (gameMenu != null)
        {
            contextualMenu.gameObject.SetActive(true);
            contextualMenu.CreateListContent();
        }
    }

    public void CloseContextualMenu()
    {
        contextualMenu.gameObject.SetActive(false);
    }
}
