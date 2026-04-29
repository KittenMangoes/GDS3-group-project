using UnityEngine;

public class flipPlayer : MonoBehaviour
{
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = findScreenClick.findScreenClickInstance.GetClickPosition();
        if(target.x < this.transform.position.x)//touch position is left of player
        {
            animator.SetBool("flip", true);
        }
        else//touch position is right of player
        {
            animator.SetBool("flip", false);
        }
    }
}
