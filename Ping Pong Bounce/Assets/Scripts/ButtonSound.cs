using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonClick;

    public void PlayButtonSound()
    {
        buttonClick.Play();
    }

    void Update()
    {
        DontDestroyOnLoad(buttonClick.gameObject);
    }
}
