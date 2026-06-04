using UnityEngine;

public class WaterSurfaceControl : MonoBehaviour
{
    [SerializeField] private float minHeight = 0f;
    [SerializeField] private float maxHeight = 36f;

    [SerializeField] private float densityAtGround = 0.006f;
    [SerializeField] private float densityAtTop = 0f;

    [SerializeField] private Transform player;

    void OnEnable()
    {
        UpdateFog();
    }
    //top 10 mysteries of the world, I have no idea why this only works
    //if you toggle it off and then on in the inspector???
    //I don't get it, I don't know why. If you know why you are cool
    //you should also probably fix it.
    //I'm done here.
    //I'm betting it's 99 percent because player is dsiabled somewhere at the start of update or something. 

    void LateUpdate()
    {
        UpdateFog();
    }

    void UpdateFog()
    {
        if (player == null) return;
        float playerY = player.position.y;
        float t = Mathf.InverseLerp(minHeight, maxHeight, playerY);
        float density = Mathf.Clamp(Mathf.Lerp(densityAtGround, densityAtTop, t), densityAtTop, densityAtGround);
        RenderSettings.fogDensity = density;
        //this guards agianst it going outside of density range :3
    }
}
