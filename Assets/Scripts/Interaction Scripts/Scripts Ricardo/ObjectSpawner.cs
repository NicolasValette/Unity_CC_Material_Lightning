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

    [SerializeField] private ContextualMenu contextualMenu;

    private void Start()
    {
        contextualMenu = FindObjectOfType<ContextualMenu>();
    }

    void AssignOtherColor(ColorData colorData)
    {
        assignedColorData = colorData;
        ApplyColor();
    }

    void ApplyColor()
    {
        // TODO

    }

    public void AssignOtherObject(ObjectData objectData)
    {
        assignedObject = objectData;
        DestroyPreviousSpawnedGameObject();
        SpawnObjectPrefab(objectData.objectPrefab);
    }

    void SpawnObjectPrefab(GameObject objectToSpawn)
    {
        spawnedGameObject = (GameObject)Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    void DestroyPreviousSpawnedGameObject()
    {
        if (spawnedGameObject != null)
            Destroy(spawnedGameObject);
    }
}
