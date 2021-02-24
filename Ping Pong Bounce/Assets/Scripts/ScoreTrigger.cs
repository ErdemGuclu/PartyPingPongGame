using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] private Collider2D triggerInCup;
    [SerializeField] private GameObject ball;
    public GameObject winMenuUI;
    public GameObject pauseMenuUI;
    [SerializeField] private AudioSource yay;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(ball);
        winMenuUI.gameObject.SetActive(true);
        pauseMenuUI.gameObject.SetActive(false);
        yay.Play();
    }
}
