using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPoolingScript : MonoBehaviour
{
    //[SerializeField] private BuildingPrefab BuildingPrefab;

    //private IObjectPool<BuildingPrefab> objectPool;

    //[SerializeField] private bool collectionCheck = true;

    //// extra options to control the pool capacity and maximum size
    //[SerializeField] private int defaultCapacity = 20;
    //[SerializeField] private int maxSize = 100;

    //private void Awake()
    //{
    //    objectPool = new ObjectPool<BuildingPrefab>(CreateBuilding , OnGetFromPool, OnReleaseToPool, OnDestroyPooledObject , collectionCheck , defaultCapacity , maxSize);
    //}

    //private BuildingPrefab CreateBuilding()
    //{
    //    BuildingPrefab BuildingInstance = Instantiate(BuildingPrefab);
    //    BuildingInstance.ObjectPool = objectPool;
    //    return BuildingInstance;
    //}

    //// invoked when returning an item to the object pool
    //private void OnReleaseToPool(BuildingPrefab pooledObject)
    //{
    //    pooledObject.gameObject.SetActive(false);
    //}

    //// invoked when retrieving the next item from the object pool
    //private void OnGetFromPool(BuildingPrefab pooledObject)
    //{
    //    pooledObject.gameObject.SetActive(true);
    //}

    //// invoked when we exceed the maximum number of pooled items (i.e. destroy the pooled object)
    //private void OnDestroyPooledObject(BuildingPrefab pooledObject)
    //{
    //    Destroy(pooledObject.gameObject);
    //}
}
