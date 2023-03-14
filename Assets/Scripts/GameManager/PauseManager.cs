using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseManager : MonoBehaviour
{
    public static bool gameIsPaused=false;
    public GameObject PauseMenuUI;

    public static PauseManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("There is more than one instance of PauseManager in the scene!");
            return;
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Menu();
        }
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void ResumeButton()
    {
        Menu();
    }

    private void Menu()
    {
        if (PauseMenuUI.gameObject.activeSelf == true)
        {
            PauseMenuUI.gameObject.SetActive(false);
            Time.timeScale = 1;
            gameIsPaused = false;

        }
        else
        {
            PauseMenuUI.gameObject.SetActive(true);
            Time.timeScale = 0;
            gameIsPaused = true;
        }
    }
}
