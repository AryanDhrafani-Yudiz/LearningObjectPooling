using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
   [SerializeField] ObjectPooler objectPooler;

    [SerializeField] private Transform prefab1;
    [SerializeField] private Transform prefab2;
    [SerializeField] private Transform prefab3;

    private void Start()
    {
        //objectPooler = ObjectPooler.Instance;
        objectPooler.SwpawnFromPool("Building1", prefab1.position, Vector3.zero);
        objectPooler.SwpawnFromPool("Building2", prefab2.position, Vector3.zero);
        objectPooler.SwpawnFromPool("Building3", prefab3.position, Vector3.zero);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objectPooler.SwpawnFromPool("Building1", prefab1.position + new Vector3(10f,0f), Vector3.zero);
            objectPooler.SwpawnFromPool("Building2", prefab2.position + new Vector3(10f, 0f), Vector3.zero);
            objectPooler.SwpawnFromPool("Building3", prefab3.position + new Vector3(10f, 0f), Vector3.zero);
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            //objectPooler.OnRelease();
        }
    }
}
