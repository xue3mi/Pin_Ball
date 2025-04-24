using UnityEngine;

public class Ball : MonoBehaviour
{
    ballRespawn br;
    private void Awake()
    {
        br = transform.parent.GetComponent<ballRespawn>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hurt"))
        {
            LifeManager.instance.MinusLife(1); //touched then minus life
        }

        if (collision.gameObject.CompareTag("Hurt"))
        {
            if (GameManager.Instance.CanRespawnBall())
            {
                br.RespawnObject();
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }

}
