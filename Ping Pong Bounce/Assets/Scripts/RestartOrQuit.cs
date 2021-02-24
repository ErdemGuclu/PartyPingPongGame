using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class RestartOrQuit : MonoBehaviour
{
    public int nextSceneLoad;
    public Image black;
    public Animator animator;

    public void Restart()
    {
        Time.timeScale = 1f;
        StartCoroutine(Fading());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator Fading()
    {
        animator.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(nextSceneLoad);
    }
}
