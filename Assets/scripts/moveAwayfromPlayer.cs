using UnityEngine;

public class moveAwayfromPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float range = 2f;
    private Transform thisTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = findScreenClick.findScreenClickInstance.GetPlayerPosition();
        if(Vector3.Distance(thisTransform.position,playerPosition) < range)
        {
            Vector3 direction = (thisTransform.position - playerPosition).normalized * speed * Time.deltaTime;
            thisTransform.position += new Vector3(direction.x, direction.y, 0);
        }
    }
}
