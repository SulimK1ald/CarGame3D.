using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIHelper : MonoBehaviour {

	// Use this for initialization
	public void RestartButton() 
	{
		SceneManager.LoadScene("lesson7");
	}
	
	// Update is called once per frame
	public void ExitButton () {
		Application.Quit();
	}
}
