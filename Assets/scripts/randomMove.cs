using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class randomMove : MonoBehaviour
{
    public Vector2 target;
    Transform thisTransform;
    float speed = 5f;
    public int canMove = 1;//0 means it cant move, when clicked to stop
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
            thisTransform.position += new Vector3((target.x - thisTransform.position.x), (target.y - thisTransform.position.y), 0).normalized * Time.deltaTime * speed * canMove;
        }
        else//at the target location
        {
            newTarget();
            //Debug.Log(target);
        }

        MoveCheck();

    }
    void newTarget()
    {
        float tempTargetx = Random.Range(0, Screen.width);
        float tempTargety = Random.Range(0, Screen.height);
        Vector3 tempScreenConvert = Camera.main.ScreenToWorldPoint(new Vector3(tempTargetx, tempTargety, Camera.main.nearClipPlane + 10f));
        target = new Vector2(tempScreenConvert.x, tempScreenConvert.y);
    }

    private void MoveCheck()
    {
        Vector3 clickPosition = findScreenClick.findScreenClickInstance.GetClickPosition();
        if (Vector3.Distance(clickPosition, thisTransform.position) < 0.6 && Input.touchCount > 0)//if the food gets clicked on
        {
            canMove = 0;//stop moving
        }

        if (this.GetComponent<getEaten>().canEat ==  false)//this means the food has been eaten so it can start moving again
        {
            canMove = 1;//can move again
        }
    }
}