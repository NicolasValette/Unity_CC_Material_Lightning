using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContextualMenu : MonoBehaviour
{
    public enum MenuTypeEnum { Object, Light }
    public MenuTypeEnum MenuType = new MenuTypeEnum();

    public GameManagerData gameManager;
//
    public Text objectTypeText;

    public GameObject ListContent;
    public GameObject ContentPrefab;

    public void CreateListContent()
    {
        for (int i = 0; i < gameManager.ObjectsList.Count; i++)
        {
            GameObject content = (GameObject)Instantiate(ContentPrefab);

            ObjectData data = gameManager.ObjectsList[i];

            content.GetComponent<Image>().sprite = data.Icon;
            content.SetActive(true);
        }
    }
}
