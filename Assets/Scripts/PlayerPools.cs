using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPools : MonoBehaviour
{
    [SerializeField] private Transform prefab1Posi;
    [SerializeField] private Transform prefab2Posi;
    [SerializeField] private Transform prefab3Posi;

    private void Start()
    {
        SpawnBuilding(prefab1Posi.position);
        SpawnBuilding(prefab2Posi.position);
        SpawnBuilding(prefab3Posi.position);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBuilding(Vector3.zero);
        }

    }
    public void SpawnBuilding(Vector3 position)
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject Building = ObjectPooling.Inst.ObjectToPool();

            if (Building != null)
            {
                Building.SetActive(true);
                Building.transform.position = position;
                break;
                //SpawnedList.Add(Building);
            }
        }
    }
}
