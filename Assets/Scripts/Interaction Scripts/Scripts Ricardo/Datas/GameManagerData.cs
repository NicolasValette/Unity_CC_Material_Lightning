using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManagerData : ScriptableObject
{


    public List<ColorData> ColorsList = new List<ColorData>();
    public List<ObjectData> ObjectsList = new List<ObjectData>();

    [MenuItem("Window/MyEditor/Detect All Datas")]
    public void detectAllDatas()
    {
        detectAllColorsDatas();
        detectAllObjectsDatas();
    }

    public void detectAllColorsDatas()
    {
        string[] guids = AssetDatabase.FindAssets("t:ObjectData", null);
        foreach (string guid in guids)
        {
            ObjectData asset = (ObjectData)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(guid), typeof(ObjectData));

            if (ObjectsList.Contains(asset) == false){
                ObjectsList.Add(asset);
            }
        }
    }
    public void detectAllObjectsDatas()
    {
        string[] guids = AssetDatabase.FindAssets("t:ColorData", null);
        foreach (string guid in guids)
        {
            ColorData asset = (ColorData)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(guid), typeof(ColorData));

            if (ColorsList.Contains(asset) == false)
            {
                ColorsList.Add(asset);
            }
        }
    }
}
