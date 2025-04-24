using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 1.5f; // move speed
    public Vector3 moveAxis = Vector3.right; // move direction
    public float moveDistance = 2f;
    public float nowDistance = 0;
    private bool movingForward = true;

    void Update()
    {
        float moveStep = moveSpeed * Time.deltaTime;

        if (movingForward)
        {
            transform.Translate(moveAxis.normalized * moveStep);
            nowDistance += moveStep;
        }
        else
        {
            transform.Translate(-moveAxis.normalized * moveStep);
            nowDistance -= moveStep;
        }

        if (nowDistance >= moveDistance)
        {
            movingForward = false;
        }
        else if (nowDistance <= 0)
        {
            movingForward = true;
        }
    }
}
