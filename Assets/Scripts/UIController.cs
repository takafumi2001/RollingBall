using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour 
{
	public Text GameClearLabel;
	public Text GameOverLabel;
	public Button GameOverButton;

	private void Start () 
	{
		// 開始時に表示を消す
		GameClearLabel.gameObject.SetActive(false);	
		GameOverLabel.gameObject.SetActive (false);
		GameOverButton.gameObject.SetActive (false);
	}

	public void ShowGameClearLabel()
	{
		// 開始時に表示する
		GameClearLabel.gameObject.SetActive(true);
		GameOverButton.gameObject.SetActive (true);
	}

	public void ShowGameOverLabel()
	{
		GameOverLabel.gameObject.SetActive (true);
		GameOverButton.gameObject.SetActive (true);
	}
}