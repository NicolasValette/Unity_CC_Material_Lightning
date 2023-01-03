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

    public ObjectSpawner SelectedObjectSpawner;

    public void CreateListContent()
    {
        for (int i = 0; i < gameManager.ObjectsList.Count; i++)
        {
            GameObject content = (GameObject)Instantiate(ContentPrefab);
            content.transform.parent = ListContent.transform;
            ObjectData data = gameManager.ObjectsList[i];

            content.GetComponent<LinkToObject>().LinkedObject = data;

            content.GetComponent<Image>().sprite = data.Icon;
            content.SetActive(true);
        }
    }

    public void AssignObjctToSelectedSpawner(LinkToObject linkToObject)
    {
        SelectedObjectSpawner.AssignOtherObject(linkToObject.LinkedObject);

        
    }
}
