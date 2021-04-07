using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMain : MonoBehaviour
{
	public void GotoGame()
	{
		SceneManager.LoadScene("Game");
	}
}
