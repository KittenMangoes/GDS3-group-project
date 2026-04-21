using UnityEngine;

public class moveToClick : MonoBehaviour
{
    Transform thisTransform;
    public float speed = 8;
    private bool moving;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTransform = this.transform;
        findScreenClick.findScreenClickInstance.SetPlayerTransform(thisTransform);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = findScreenClick.findScreenClickInstance.GetClickPosition();
        if (Vector3.Distance(target,thisTransform.position) > 0.2)
        {
            moving = true;//set to a toggle for more control
        }
        else//reached the target location
        {
            moving = false;
        }
        if (moving)
        {
            thisTransform.position += new Vector3((target.x - thisTransform.position.x), (target.y - thisTransform.position.y), 0).normalized * Time.deltaTime * speed;
        }
    }
}
