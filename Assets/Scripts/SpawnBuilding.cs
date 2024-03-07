using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnBuilding : MonoBehaviour
{
    [SerializeField] SpawnUsingPool spawncs;
    private GameObject gameObjectG1;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameObjectG1 = spawncs.OnObjectCreate();
        }
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
           spawncs.OnRelease(gameObjectG1);
        }
    }
}
