using UnityEngine;

public class dontClickHere : MonoBehaviour
{
    [SerializeField] private float maxCanvasX;//the canvas is an editable size in the editor
    [SerializeField] private float maxCanvasY;
    [SerializeField] private float minCanvasX;
    [SerializeField] private float minCanvasY;

    // Update is called once per frame
    void Update()
    {
        Vector3 touch = findScreenClick.findScreenClickInstance.GetClickPosition();//if you click outside of the canvas
        if (touch.x > maxCanvasX ||
            touch.x < minCanvasX ||
            touch.y > maxCanvasY ||
            touch.y < minCanvasY)
        {//set the touch position to the player so it doesnt move
            Vector3 playerPos = findScreenClick.findScreenClickInstance.GetPlayerPosition();
            //findScreenClick.findScreenClickInstance.ChangeTouchPosition(playerPos); this doesn't work because it takes the players world coords and treats them like screen coords
            findScreenClick.findScreenClickInstance.ChangeTouchPosition(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, Camera.main.nearClipPlane + 10f)));
        }
    }
}
