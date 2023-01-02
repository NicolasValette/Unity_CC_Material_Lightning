using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerData : ScriptableObject
{


    public List<ColorData> ColorsList = new List<ColorData>();
    public List<ObjectData> ObjectsList = new List<ObjectData>();

    public static void detectAllDatas()
    {
        detectAllColorsDatas();
        detectAllObjectsDatas();
    }

    public static void detectAllColorsDatas()
    {
        // TODO
    }
    public static void detectAllObjectsDatas()
    {
        // TODO

    }
}
