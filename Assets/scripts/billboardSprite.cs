using UnityEngine;

public class billboardSprite : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(-Camera.main.transform.position);
    }
}
