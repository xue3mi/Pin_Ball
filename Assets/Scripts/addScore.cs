using UnityEngine;

public class addScore : MonoBehaviour
{
    public AudioSource audioSource;  // AudioSource
    public AudioClip eggSound;
    public AudioClip obstacleSound;
    public AudioClip cheeseSound;
    public AudioClip vegeSound;

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Egg"))
        {
            ScoreManager.instance.AddScore(5); //touched then add score
            PlaySound(eggSound);
        }
        if (collision.gameObject.CompareTag("Bread"))
        {
            ScoreManager.instance.AddScore(10);
            PlaySound(obstacleSound);
        }
        if (collision.gameObject.CompareTag("Cheese"))
        {
            ScoreManager.instance.AddScore(1);
            PlaySound(cheeseSound);
        }
        if (collision.gameObject.CompareTag("Vege"))
        {
            ScoreManager.instance.AddScore(1);
            PlaySound(vegeSound);
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            PlaySound(obstacleSound);
        }
    }

        private void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);//play as it assigned
        }
    }

}
