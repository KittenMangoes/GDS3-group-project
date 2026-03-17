using System.Collections;
using UnityEngine;

public class getEaten : MonoBehaviour
{
    Transform thisTransform;
    int respawnTime = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = findScreenClick.findScreenClickInstance.GetPlayerPosition();
        if(Vector3.Distance(playerPosition, thisTransform.position) < 0.5)
        {
            Debug.Log("eat");
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<randomMove>().canMove = 1;//can move again
            StartCoroutine(RespawnWait());
        }
    }

    IEnumerator RespawnWait()
    {
        yield return new WaitForSeconds(respawnTime);
        this.GetComponent<MeshRenderer>().enabled = true;
    }
}
