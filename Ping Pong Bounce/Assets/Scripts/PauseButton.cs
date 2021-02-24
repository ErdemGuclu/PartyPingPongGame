using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    private bool isPaused;

    private void Awake()
    {
        isPaused = false;
    }

    private void Update()
    {
        if (isPaused)
            Activate();
        else
            Deactivate();
    }

    public void Pause()
    {
        isPaused = !isPaused;
    }

    private void Activate()
    {
        Time.timeScale = 0f;
        pauseMenuUI.gameObject.SetActive(true);
    }

    private void Deactivate()
    {
        Time.timeScale = 1f;
        pauseMenuUI.gameObject.SetActive(false);
    }
}
