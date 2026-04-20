using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        private Vector3 pos = this.transform.position;//set it to a variable so its smaller to write
        Camera.main.transform.position = new Vector3(pos.x, pos.y,-10);//lock in the z position
    }
}
