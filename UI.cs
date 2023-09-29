using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
	static UI singleton;

	public Text scoreText;
	public GameObject panel;
	public Text panelScoreText;
	public Text defeatText;
	public Text victoryText;

	void Awake()
	{
		singleton = this;
	}


	void Update()
	{
		scoreText.text = Player.score.ToString();
	}

	public static void ShowVictoryPanel()
	{
		singleton.panel.SetActive(true);
		singleton.victoryText.gameObject.SetActive(true);
		singleton.panelScoreText.text = Player.score.ToString();
	}

	public static void ShowDefeatPanel()
	{
		singleton.panel.SetActive(true);
		singleton.defeatText.gameObject.SetActive(true);
		singleton.panelScoreText.text = Player.score.ToString();
	}

	public void OnClickRestart()
	{
		Player.Restart();
	}
}
