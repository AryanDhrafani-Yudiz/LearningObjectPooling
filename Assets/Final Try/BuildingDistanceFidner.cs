using UnityEngine;

public class BuildingDistanceFidner : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            this.gameObject.SetActive(false);
        }
    }
}
