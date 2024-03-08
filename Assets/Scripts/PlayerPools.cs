using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerPools : MonoBehaviour
{
    [SerializeField] private Transform prefab1Posi;
    [SerializeField] private Transform prefab2Posi;
    [SerializeField] private Transform prefab3Posi;
    private float posiToSpawnNextBuilding;
    private float xOffset;
    private float currPosition;

    private void Start()
    {
        SpawnStartingBuilding();
        SpawnStartingBuilding();
        SpawnStartingBuilding();
        posiToSpawnNextBuilding = prefab3Posi.position.x;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBuilding(FindNextPosition());
        }
    }
    public void SpawnStartingBuilding()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject Building = ObjectPooling.Inst.ObjectToPoolStarting();

            if (Building != null)
            {
                Building.SetActive(true);
                break;
            }
        }
    }

    public void SpawnBuilding(float position1)
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject Building = ObjectPooling.Inst.ObjectToPool();

            if (Building != null)
            {
                Building.transform.position = new Vector3(position1 , Building.transform.position.y , Building.transform.position.z);
                Building.SetActive(true);
                break;
            }
        }
    }
    public float FindNextPosition()
    {
        xOffset = Random.Range(3.5f, 5f);
        //currPosition = ;
        return posiToSpawnNextBuilding + xOffset;
    }
}
