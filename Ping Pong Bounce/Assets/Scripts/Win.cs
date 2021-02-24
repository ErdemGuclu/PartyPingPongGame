using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Win : MonoBehaviour
{
    public int nextSceneLoad;
    public Image black;
    public Animator animator;


    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        StartCoroutine(Fading());
        SceneManager.LoadScene(nextSceneLoad - 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {
        StartCoroutine(Fading());
        SceneManager.LoadScene(nextSceneLoad);

        if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
    }

    IEnumerator Fading()
    {
        animator.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(nextSceneLoad);
    }
}
