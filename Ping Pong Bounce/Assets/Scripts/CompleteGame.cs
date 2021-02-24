using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CompleteGame : MonoBehaviour
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

    IEnumerator Fading()
    {
        animator.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(nextSceneLoad);
    }
}
