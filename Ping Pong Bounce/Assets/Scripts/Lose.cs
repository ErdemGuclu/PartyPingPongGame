using UnityEngine;

public class Lose : MonoBehaviour
{
    [SerializeField] private GameObject restartUI;
    [SerializeField] private GameObject pauseMenuUI;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Floor")
        {
            restartUI.gameObject.SetActive(true);
            pauseMenuUI.gameObject.SetActive(false);
        }
    }
}
