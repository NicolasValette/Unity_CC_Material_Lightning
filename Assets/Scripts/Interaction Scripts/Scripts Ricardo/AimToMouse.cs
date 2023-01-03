using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimToMouse : MonoBehaviour
{
    public RaycastHit hit;
    public UIMenuManager menuManager;
    public LayerMask layers;

    private void Update()
    {
        CastRayToMouse();
    }

    private void CastRayToMouse()
    {
        Ray rayToMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(rayToMouse.origin, rayToMouse.direction * 20f, Color.red);
       
        if (Physics.Raycast(rayToMouse, out hit/*, layers*/))
        {
            if (hit.transform.GetComponent<ObjectSpawner>() == true)
            {
            //    Debug.Log(hit.transform.name);

                // open contextual menu
                if (Input.GetMouseButtonDown(0)/*Input.GetKey(KeyCode.Mouse0)*/)
                {

                    menuManager.contextualMenu.MenuType = ContextualMenu.MenuTypeEnum.Object;
                    menuManager.contextualMenu.objectTypeText.text = menuManager.contextualMenu.MenuType.ToString();
                    
                    menuManager.OpenContextualMenu(hit.transform.GetComponent<ObjectSpawner>());
                }
            }

            else if (hit.transform.GetComponent<ToggleLight>() == true)
            {
                // open contextual menu
                if (Input.GetMouseButtonDown(0))
                {
                    menuManager.contextualMenu.GetComponent<ContextualMenu>().MenuType = ContextualMenu.MenuTypeEnum.Light;
                    menuManager.contextualMenu.GetComponent<ContextualMenu>().objectTypeText.text = menuManager.contextualMenu.GetComponent<ContextualMenu>().MenuType.ToString();

                 //   menuManager.OpenContextualMenu(hit.transform.GetComponent<ToggleLight>());
                }
            }
            else if (hit.transform.GetComponent<EnvironmentElement>() == true)
            {
                // open contextual menu
                if (Input.GetMouseButtonDown(0))
                {
                //    Debug.Log("EnvironmentElement");
                
                    menuManager.contextualMenu.GetComponent<ContextualMenu>().MenuType = ContextualMenu.MenuTypeEnum.Environment;
                    menuManager.contextualMenu.GetComponent<ContextualMenu>().objectTypeText.text = menuManager.contextualMenu.GetComponent<ContextualMenu>().MenuType.ToString();
                                        
                    menuManager.OpenContextualMenu(hit.transform.GetComponent<EnvironmentElement>());
                }
            }
            else
            {
            
            }
        }
       
    }
}
