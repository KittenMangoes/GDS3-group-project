using UnityEngine;

public class dontClickHere : MonoBehaviour
{
    [SerializeField] private float maxCanvasX;
    [SerializeField] private float maxCanvasY;
    [SerializeField] private float minCanvasX;
    [SerializeField] private float minCanvasY;

    // Update is called once per frame
    void Update()
    {
        Vector3 touch = findScreenClick.findScreenClickInstance.GetClickPosition();
        if (touch.x > maxCanvasX ||
            touch.x < minCanvasX ||
            touch.y > maxCanvasY ||
            touch.y < minCanvasY)
        {//if you click outside of the canvas
            Vector3 playerPos = findScreenClick.findScreenClickInstance.GetPlayerPosition();
            //findScreenClick.findScreenClickInstance.ChangeTouchPosition(playerPos);
            findScreenClick.findScreenClickInstance.ChangeTouchPosition(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, Camera.main.nearClipPlane + 10f)));
        }//set the touch position to the player so it doesnt move
    }
}
