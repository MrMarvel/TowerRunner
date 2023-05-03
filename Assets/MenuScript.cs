using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevelNumber(int number = 1)
    {
        SceneManager.LoadScene("Level" + number);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
