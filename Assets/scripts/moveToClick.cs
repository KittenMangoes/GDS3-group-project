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
        Vector2 target = findScreenClick.findScreenClickInstance.GetClickPosition();
        if (thisTransform.position.x != target.x && thisTransform.position.y != target.y);
        {
            thisTransform.position += new Vector3((target.x - thisTransform.position.x), (target.y - thisTransform.position.y), 0).normalized * Time.deltaTime * speed;
            //thisTransform.LookAt(target);
            //thisTransform.position += this.thisTransform.forward * Time.deltaTime * speed;
        }
    }
}
