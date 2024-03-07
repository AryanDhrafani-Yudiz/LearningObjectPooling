using UnityEngine;

public class BuildingDistanceFidner : MonoBehaviour
{
    private Vector2 screenBounds;

    private void FixedUpdate()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Debug.Log(screenBounds);
        if (this.gameObject.transform.position.x > screenBounds.x)
        {
            //this.gameObject.SetActive(false);
            Debug.Log(screenBounds);
        }
    }
        void Update()
    {            
        //if (Camera.main.transform.position.x + this.transform.position.x > 0)
        //{
        //    this.gameObject.SetActive(false);
        //}
    }
}
