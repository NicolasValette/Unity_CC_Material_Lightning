using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MaterialData;

public class EnvironmentElement : MonoBehaviour
{
    public MaterialData.MaterialTypeEnum MaterialType = new MaterialData.MaterialTypeEnum();
    public MaterialData assignedMaterialData;

    public void AssignMaterialToElement(MaterialData data)
    {
        assignedMaterialData = data;

    }
}
