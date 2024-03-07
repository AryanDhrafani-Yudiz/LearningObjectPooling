using UnityEngine;
using UnityEngine.Pool;

public class SpawnUsingPool : MonoBehaviour
{
    public GameObject objectPrefab;
    public int maxSize;
    ObjectPool<GameObject> objectPool;

    void Awake()
    {
        objectPool = new ObjectPool<GameObject>(OnObjectCreate, OnTake, OnRelease, OnObjectDestroy);
    }
    private void Start()
    {
        for (int i = 0; i < maxSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            //objectPool.Push(obj);
        }
    }

    public GameObject OnObjectCreate()
    {
        GameObject newObject = Instantiate(objectPrefab);
        newObject.AddComponent<PoolObject>().myPool = objectPool;
        return newObject;
    }

    public void OnTake(GameObject poolObject)
    {
        poolObject.SetActive(true);
    }

    public void OnRelease(GameObject poolObject)
    {
        poolObject.SetActive(false);
    }

    public void OnObjectDestroy(GameObject poolObject)
    {
        Destroy(poolObject);
    }
}