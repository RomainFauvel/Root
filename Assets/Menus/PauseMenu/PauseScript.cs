using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] public GameObject pauseMenu;
	public static bool isPaused;
	// Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Escape))||(Input.GetKeyDown(KeyCode.Backspace)))
		{
			if (isPaused)
			{
				ResumeGame();
			}
			else
			{
				PauseGame();
			}
			
		}
    }
	
	public void PauseGame()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		isPaused = true;
	}
	
	public void ResumeGame()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		isPaused = false;
	}
	
	public void goMainMenu()
	{
		isPaused = false;
		Time.timeScale = 1f;
		SceneManager.LoadScene("MainMenu");
		
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}
}
