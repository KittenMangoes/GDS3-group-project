using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 tempLerp;//holding the lerped camera position before the camera is set
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position;//set it to a variable so its smaller to write
        //try using a lerp to make the camera smoother
        tempLerp = Vector3.Lerp(Camera.main.transform.position, pos, 0.1f);
        Camera.main.transform.position = new Vector3(tempLerp.x, tempLerp.y, -10);//lock in the z position
    }
}
