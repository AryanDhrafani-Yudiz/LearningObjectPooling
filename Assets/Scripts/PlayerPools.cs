using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerPools : MonoBehaviour
{
    [SerializeField] private Transform prefab1Posi;
    [SerializeField] private Transform prefab2Posi;
    [SerializeField] private Transform prefab3Posi;
    private Vector3 posiToSpawnBuilding;
    private float xOffset;

    private void Start()
    {
        //SpawnBuilding(prefab1Posi.position, 0f);
        //SpawnBuilding(prefab2Posi.position, 0f);
        //SpawnBuilding(prefab3Posi.position, 0f);
        SpawnStartingBuilding();
        SpawnStartingBuilding();
        SpawnStartingBuilding();
        posiToSpawnBuilding = prefab3Posi.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBuilding(Vector3.zero,FindNextPosition());
        }
    }
    public void SpawnStartingBuilding()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject Building = ObjectPooling.Inst.ObjectToPoolStarting();

            if (Building != null)
            {
                //Building.transform.position = new Vector3;
                Building.SetActive(true);
                break;
            }
        }
    }
    public void SpawnBuilding(Vector3 position,float xoffset)
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject Building = ObjectPooling.Inst.ObjectToPool();

            if (Building != null)
            {
                Building.transform.position = new Vector3(position.x + xOffset,position.y,position.z);
                Building.SetActive(true);
                break;
            }
        }
    }
    public float FindNextPosition()
    {
        //posiToSpawnBuilding = new Vector3(Random.Range(3.5f,5f),0f,0f);
        // return posiToSpawnBuilding;
        xOffset = Random.Range(3.5f, 5f);
        return xOffset;
    }
}
