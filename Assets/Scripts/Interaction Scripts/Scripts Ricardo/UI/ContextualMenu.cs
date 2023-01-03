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

    public List<GameObject> ChoicesList = new List<GameObject>();


    public void CreateListContent(ObjectSpawner selectedSpawner)
    {
        CleanChoices();
        for (int i = 0; i < gameManager.ObjectsList.Count; i++)
        {
            if (selectedSpawner.ObjectType == gameManager.ObjectsList[i].ObjectType)
            {
                GameObject content = (GameObject)Instantiate(ContentPrefab);
                content.transform.parent = ListContent.transform;
                ObjectData data = gameManager.ObjectsList[i];

                content.GetComponent<LinkToObject>().LinkedObject = data;

                ChoicesList.Add(content);

                content.GetComponent<Image>().sprite = data.Icon;
                content.SetActive(true);
            }
        }
    }

    void CleanChoices()
    {
        for (int i = 0; i < ChoicesList.Count; i++)
        {
            Destroy(ChoicesList[i]);
        }
        ChoicesList.Clear();
    }

    public void AssignObjctToSelectedSpawner(LinkToObject linkToObject)
    {
        SelectedObjectSpawner.AssignOtherObject(linkToObject.LinkedObject);

        
    }
}
