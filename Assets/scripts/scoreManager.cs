using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public static scoreManager scoreManagerInstance;
    public int score = 0;

    void Awake()
    {
        scoreManagerInstance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}
