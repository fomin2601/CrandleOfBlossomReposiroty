using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	public GameObject settings;
	public void StartGame () {
		Application.LoadLevel (1);
	}

	public void LoadGame () {

	}

	public void Options () {
		settings.SetActive (!settings.activeSelf);
	}

	public void Quit () {
		Application.Quit ();
	}

	public void SetMusic(float Value) {
		Global.Music = Value;
	}

	public void SetSound(float Value) {
		Global.Sound = Value;
	}
}