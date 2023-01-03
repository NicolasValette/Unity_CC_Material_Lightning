using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorController : MonoBehaviour
{
    private bool _isOpen = false;

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OpenCloseDoor()
    {
        if (_isOpen)
        {
            transform.parent.eulerAngles = new Vector3(0f, -90f, 90f);
            _isOpen = false;
        }
        else
        {
            transform.parent.eulerAngles = new Vector3(0f, 90f, 90f);
            _isOpen = true;
        }
    }
}
