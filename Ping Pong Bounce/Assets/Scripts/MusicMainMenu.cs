using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicMainMenu : MonoBehaviour
{
    private static MusicMainMenu instance = null;

    public static MusicMainMenu Instance
    {
        get { return instance; }
    }

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
            instance = this;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "LevelSelect" || SceneManager.GetActiveScene().name == "MainMenu")
            DontDestroyOnLoad(this.gameObject);
        else
            Destroy(this.gameObject);
    }
}
