using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPaddle : MonoBehaviour
{
    public LeftOrRight leftOrRight;
    public float Torque;
    private Rigidbody2D rb;
    public enum LeftOrRight { Left, Right }

    //sound effect
    public AudioSource audioSource;
    public AudioClip soundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        switch (leftOrRight)
        {
            case LeftOrRight.Left:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    AddPaddleTorque(Torque);
                    PlaySound();
                }
                break;
            case LeftOrRight.Right:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    AddPaddleTorque(-Torque);
                    PlaySound();
                }
                break;
        }
    }
    private void AddPaddleTorque(float torque)
    {
        rb.AddTorque(torque, ForceMode2D.Impulse);
    }

    
    //sound effect
    private void PlaySound()
    {
        if (audioSource != null && soundEffect != null)
        {
            audioSource.PlayOneShot(soundEffect);
        }
    }
}
