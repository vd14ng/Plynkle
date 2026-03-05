using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip PeghitClip;
    private AudioSource audioSource;
    public static bool isBallInPlay;
    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        isBallInPlay = true;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Peg"))
        {
            audioSource.PlayOneShot(PeghitClip);
            audioSource.pitch = audioSource.pitch + 0.1f;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlotTrigger"))
        {
            Destroy(gameObject);
        }
    }
    public bool IsBallInPlay()
    {
        return isBallInPlay;
    }

    public void OnDestroy()
    {
        isBallInPlay = false;
    }
}
