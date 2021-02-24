using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    //ChangeLevel metodunu parametreli yapıyoruz böylece inspectorda bir butona onClick eventi ile
    //ChangeLevel metodunu atadığımızda aşağıda bir textbox belirecek ve buraya index yerine geçmesini istediğimiz
    //sayıyı atayacağız.
    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
    }
}
