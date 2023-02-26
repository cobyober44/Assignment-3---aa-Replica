using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

	public Rotator rotator;
	public Spawner spawner;
	public Text playerName;
	public Animator animator;

	private int playerLives;
	public static int playerLivesPass = 5;

	private int highScore;
	public static int highScorePass = 0;
	public Text highScoreText;

	public Text lifeText;

    public void Start()
    {
		playerName.text = "Good Luck " + Menu.myName + "!";
		playerLives = playerLivesPass;
		lifeText.text = "Lives: " + playerLives.ToString();

		highScoreText.text = "High Score: " + highScorePass.ToString();
    }

    public void EndGame()
	{
		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger("EndGame");

		gameHasEnded = true;
	}

	public void RestartLevel()
	{
		if (playerLives >= 2)
		{
			playerLives--;
			playerLivesPass = playerLives;
			highScore = Score.PinCount - 1;

			if (highScore > highScorePass)
				highScorePass = highScore;

			SceneManager.LoadScene("MainLevel");
			
		}
		else
		{
            highScore = Score.PinCount - 1;

            if (highScore > highScorePass)
                highScorePass = highScore;

            SceneManager.LoadScene("Exit");
		}

	}
}
