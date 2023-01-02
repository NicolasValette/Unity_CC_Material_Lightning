using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObjectData;

public class ObjectSpawner : MonoBehaviour
{
    public ObjectData.ObjectTypeEnum ObjectType = new ObjectData.ObjectTypeEnum();

    [SerializeField] private ObjectData assignedObject;
    [SerializeField] private GameObject spawnedGameObject;
    [SerializeField] private ColorData assignedColorData;



    void AssignOtherColor(ColorData colorData)
    {
        assignedColorData = colorData;
        ApplyColor();
    }

    void ApplyColor()
    {
        // TODO

    }

    void AssignOtherObject(ObjectData objectData)
    {
        assignedObject = objectData;
        DestroyPreviousSpawnedGameObject();
        SpawnObjectPrefab(objectData.objectPrefab);
    }

    void SpawnObjectPrefab(GameObject objectToSpawn)
    {

    }

    void DestroyPreviousSpawnedGameObject()
    {
        if (spawnedGameObject != null)
            Destroy(spawnedGameObject);
    }
}
