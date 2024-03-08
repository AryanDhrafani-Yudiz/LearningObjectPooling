using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPools : MonoBehaviour
{
    [SerializeField] private Transform prefab1Posi;
    [SerializeField] private Transform prefab2Posi;
    [SerializeField] private Transform prefab3Posi;
    private Vector3 posiToSpawnBuilding;

    private void Start()
    {
        SpawnBuilding(prefab1Posi.position);
        SpawnBuilding(prefab2Posi.position);
        SpawnBuilding(prefab3Posi.position);
        posiToSpawnBuilding = prefab3Posi.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBuilding(FindNextPosition());
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
            }
        }
    }
    public Vector3 FindNextPosition()
    {
       posiToSpawnBuilding = new Vector3(posiToSpawnBuilding.x + Random.Range(3.5f,7f),posiToSpawnBuilding.y,posiToSpawnBuilding.z);
        return posiToSpawnBuilding;
    }
}
