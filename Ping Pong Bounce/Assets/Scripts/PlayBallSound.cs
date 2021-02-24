using UnityEngine;

public class PlayBallSound : MonoBehaviour
{
    [SerializeField] private AudioSource ballBounce;

    private void OnCollisionEnter2D(Collision2D other)
    {
        ballBounce.Play();
    }
}
