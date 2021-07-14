using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public Animator StartScreen;
    [SerializeField] Transform ResumeButton;
    public bool isPaused;

    void Start() {

    	ResumeButton.gameObject.SetActive(false); //disable resume button untill pause is clicked
    	isPaused = false;
    }

    public void StartGame() {

    	//makes start screen go away to start game or resume after a pause
    	StartScreen.SetBool("StartClicked", true);
    }

    public void PauseGame() {

    	Pause();
    }

    public void Pause() {

    	isPaused = true;
    	ResumeButton.gameObject.SetActive(true);
    	Time.timeScale = 0f; //pause game
    }

    public void ExitGame() {

        Application.Quit();
        Debug.Log("Game is exiting");
    }

    void Update() {

    	if (Input.GetKeyDown(KeyCode.R)) {

    		ResumeGame();
    	}

    }

    public void ResumeGame() {

    	isPaused = false;
		ResumeButton.gameObject.SetActive(false);
		Time.timeScale = 1f; //resume game

    }
}