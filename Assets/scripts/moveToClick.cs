using UnityEngine;

public class moveToClick : MonoBehaviour
{
    Transform thisTransform;
    public float speed = 6;
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
        if (Vector3.Distance(target,thisTransform.position) > 0.3)
        {
            thisTransform.position += new Vector3((target.x - thisTransform.position.x), (target.y - thisTransform.position.y), 0).normalized * Time.deltaTime * speed;
        }
    }
}
