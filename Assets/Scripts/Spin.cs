using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 10f; // Rotation speed in degrees per second
    public Vector3 rotationAxis = Vector3.up; // Default to rotation

    void Update()
    {

        transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime);
    }
}