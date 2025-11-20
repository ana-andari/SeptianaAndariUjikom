using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Mulai()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credit");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
