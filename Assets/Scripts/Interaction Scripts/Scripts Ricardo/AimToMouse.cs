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

                    menuManager.contextualMenu.GetComponent<ContextualMenu>().MenuType = ContextualMenu.MenuTypeEnum.Object;
                    menuManager.contextualMenu.GetComponent<ContextualMenu>().objectTypeText.text = menuManager.contextualMenu.GetComponent<ContextualMenu>().MenuType.ToString();
                    
                    menuManager.OpenContextualMenu();
                }
            }

            else if (hit.transform.GetComponent<ToggleLight>() == true)
            {
                // open contextual menu
                if (Input.GetMouseButtonDown(0))
                {
                    menuManager.contextualMenu.GetComponent<ContextualMenu>().MenuType = ContextualMenu.MenuTypeEnum.Light;
                    menuManager.contextualMenu.GetComponent<ContextualMenu>().objectTypeText.text = menuManager.contextualMenu.GetComponent<ContextualMenu>().MenuType.ToString();

                    menuManager.OpenContextualMenu();
                }
            }
            else
            {
                // close contextual menu
            /*    if (Input.GetMouseButtonDown(0)
                   && hit.transform.gameObject.layer != 5)
                    menuManager.CloseContextualMenu();*/
            }
        }
       
    }
}
