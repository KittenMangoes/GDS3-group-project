using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class randomMove : MonoBehaviour
{
    public Vector2 target;
    Transform thisTransform;
    float speed = 5.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(thisTransform.position.x) != Mathf.Round(target.x) && Mathf.Round(thisTransform.position.y) != Mathf.Round(target.y))
        {
            thisTransform.position += new Vector3((target.x - thisTransform.position.x), (target.y - thisTransform.position.y), 0).normalized * Time.deltaTime * speed;
        }
        else//at the target location
        {
            newTarget();
            //Debug.Log(target);
        }
    }
    void newTarget()
    {
        float tempTargetx = Random.Range(0, Screen.width);
        float tempTargety = Random.Range(0, Screen.height);
        Vector3 tempScreenConvert = Camera.main.ScreenToWorldPoint(new Vector3(tempTargetx, tempTargety, Camera.main.nearClipPlane + 10f));
        target = new Vector2(tempScreenConvert.x, tempScreenConvert.y);
    }
}