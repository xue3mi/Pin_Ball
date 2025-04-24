using UnityEngine;

public class ballRespawn : MonoBehaviour
{
    public GameObject objectPrefab;
    private Vector3 initialPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (transform.childCount > 0)
            initialPosition = transform.GetChild(0).position;
    }


    public void RespawnObject()
    {
        Debug.Log("Respawn Obj");
        Destroy(transform.GetChild(0).gameObject);
        Instantiate(objectPrefab, initialPosition, Quaternion.identity, transform);
    }
}
