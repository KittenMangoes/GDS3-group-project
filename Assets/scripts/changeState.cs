using UnityEngine;

public class changeState : MonoBehaviour
{
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        int level = scoreManager.scoreManagerInstance.GetScore();
        animator.SetInteger("level", level);
    }
}
