using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
    [SerializeField] private Collider2D triggerInCup;
    [SerializeField] private GameObject ball;
    public GameObject endGameMenuUI;
    public GameObject pauseMenuUI;
    [SerializeField] private AudioSource yay;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(ball);
        endGameMenuUI.gameObject.SetActive(true);
        pauseMenuUI.gameObject.SetActive(false);
        yay.Play();
    }
}
