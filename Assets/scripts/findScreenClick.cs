using UnityEngine;

public class findScreenClick : MonoBehaviour
{
    public static findScreenClick findScreenClickInstance;
    public Touch touch;//set touch to a public variable so the function can read it
    public Vector3 touchWorldCoords;

    void Awake()
    {
        findScreenClickInstance = this;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            //Debug.Log(touch.position);
            touchWorldCoords = Camera.main.ScreenToWorldPoint(new Vector2(touch.position.x,touch.position.y));//this as raw data shows (0,1,-10) despite being a vector2
            Debug.Log(new Vector2(touchWorldCoords.x, touchWorldCoords.y));
            //this is outputing (0,1) no matter where clicked, this shows that the issue just comes down to the math from the screen to world point function
        }
    }

    public Vector3 GetClickPosition()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y,0));
    }
}
