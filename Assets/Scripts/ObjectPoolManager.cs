using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public static List<PooledObjectInfo> objectPools = new List<PooledObjectInfo>();

    public static GameObject SpawnObject(GameObject objectToSpawn , Vector3 spawnPosition , Vector3 spawnRotation)
    {

        return null;
    }
}
public class PooledObjectInfo
{
    public string LookupString;
    public List<GameObject> InactiveObjects = new List<GameObject>();
}
