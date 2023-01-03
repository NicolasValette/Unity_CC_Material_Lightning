using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorController : MonoBehaviour
{
 

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OpenCloseDoor()
    {
        transform.eulerAngles = new Vector3(0f, 90f, 90f);
    }
}
