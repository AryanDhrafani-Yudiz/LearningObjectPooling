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
        SpawnBuilding(Vector3.zero);
        SpawnBuilding(Vector3.zero);
        SpawnBuilding(Vector3.zero);
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
                Building.transform.position += position;
                Building.SetActive(true);
                break;
            }
        }
    }
    public Vector3 FindNextPosition()
    {
       posiToSpawnBuilding = new Vector3(Random.Range(3.5f,5f),0f,0f);
        return posiToSpawnBuilding;
    }
}
