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

    Transform playerTransform;
    public void SetPlayerTransform(Transform player)
    {
        playerTransform = player;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            //Debug.Log(touch.position);
            touchWorldCoords = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y,Camera.main.nearClipPlane + 10f));
            //Debug.Log(touchWorldCoords);
        }
    }

    public Vector3 GetClickPosition()
    {
        return new Vector3(touchWorldCoords.x, touchWorldCoords.y, 0);
    }

    public Vector3 GetPlayerPosition()
    {
        return playerTransform.position;
    }
}
