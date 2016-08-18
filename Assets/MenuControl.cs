using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuControl : MonoBehaviour {

	public CanvasGroup _mainCanvas;
	public CanvasGroup _aboutCanvas;

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag ("mainPiano").GetComponentInChildren<Text> ().text = "Piano";
		GameObject.FindGameObjectWithTag ("mainChaos").GetComponentInChildren<Text> ().text = "Chaos";
		GameObject.FindGameObjectWithTag ("mainAbout").GetComponentInChildren<Text> ().text = "About";
		GameObject.FindGameObjectWithTag ("goback").GetComponentInChildren<Text> ().text = "Home";
		HideAboutPanel ();
	}

	// Initially hide the information panel
	void HideAboutPanel()
	{
		_mainCanvas.alpha = 1f;
		_aboutCanvas.alpha = 0f;

		_aboutCanvas.blocksRaycasts = false;
		_mainCanvas.blocksRaycasts = true;

	}

	// Show the 'About' panel
	void ShowAboutPanel()
	{
		_aboutCanvas.alpha = 1f;
		_mainCanvas.alpha = 0f;

		_aboutCanvas.blocksRaycasts = true;
		_mainCanvas.blocksRaycasts = false;
	}

	// Update is called once per frame
	void Update () {

	}

	// We want to load in the scene for the piano tones
	public void LoadPiano(){
	}

	// Load in Chaos scene
	public void LoadChaos(){
		Application.LoadLevel ("Synethesia");
	}

	// Show About Page
	public void ShowAbout()
	{
		ShowAboutPanel ();
	}

	// Show main panel
	public void ReturnHome(){
		HideAboutPanel ();
	}
}
