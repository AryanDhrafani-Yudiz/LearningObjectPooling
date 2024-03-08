using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling Inst;

    [SerializeField] private int _numberOfEachObject;
    [SerializeField] private GameObject _prefab1;
    [SerializeField] private GameObject _prefab2;
    [SerializeField] private GameObject _prefab3;
    private int getRandomItem;
    private bool initialBuildings;

    public List<GameObject> ListOfObjects;

    private void Awake()
    {
        Inst = this;
        CreateObjects();
    }

    public void CreateObjects()
    {
        ListOfObjects = new();
        GameObject tmp;

        for (int i = 0; i < _numberOfEachObject; i++)
        {
            tmp = Instantiate(_prefab1);
            tmp.SetActive(false);
            ListOfObjects.Add(tmp);

            tmp = Instantiate(_prefab2);
            tmp.SetActive(false);
            ListOfObjects.Add(tmp);

            tmp = Instantiate(_prefab3);
            tmp.SetActive(false);
            ListOfObjects.Add(tmp);
        }
    }

    public GameObject ObjectToPool()
    {
        for (int i = 0; i < ListOfObjects.Count; i++)
        {
            if (initialBuildings)
            {
                getRandomItem = 0;
                getRandomItem++;
                if (getRandomItem > 2) initialBuildings = false;

            }
            else getRandomItem = Random.Range(0, ListOfObjects.Count);
            if (!ListOfObjects[getRandomItem].activeInHierarchy)
            {
                return ListOfObjects[getRandomItem];
            }
        }
        return null;
    }
}