using UnityEngine;

public class moveToClick : MonoBehaviour
{
    Transform thisTransform;
    public float speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(findScreenClick.findScreenClickInstance.GetClickPosition());
        Vector3 target = findScreenClick.findScreenClickInstance.GetClickPosition();
        if (thisTransform.position.x != target.x && thisTransform.position.y != target.y);
        {
            thisTransform.position += new Vector3(target.x, target.y, 0) * Time.deltaTime * speed;
        }
    }
}
