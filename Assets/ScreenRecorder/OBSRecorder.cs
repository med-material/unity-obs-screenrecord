using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class OBSRecorder : MonoBehaviour {

	private bool isRecording = false;
	private Process obs;
	public static OBSRecorder Instance { get; private set; }

	// Use this for initialization
	void Awake () {
		if (Instance == null) {
			Instance = this;
		}  else if (Instance != this) {
			return;
		}

		DontDestroyOnLoad(gameObject);

		if (FindObjectsOfType (GetType ()).Length > 1) {
			Destroy (gameObject);
		}

		if (!isRecording) {
			StartRecording ();
		}

	}

	public void OnApplicationQuit() {
		if (Instance != this) {
			return;
		}
		if (isRecording) {
			KillRecording ();
		}
	}

	public void StartRecording() {
		if (isRecording) {
			return;
		}
		isRecording = true;

		foreach (var process in Process.GetProcessesByName("obs64"))
		{
			process.Kill();
		}

		obs = new Process();
		obs.StartInfo.FileName = "C:\\Program Files\\obs-studio\\bin\\64bit\\obs64.exe";
		obs.StartInfo.Arguments = "--startrecording --minimize-to-tray";
		obs.StartInfo.WorkingDirectory = "C:\\Program Files\\obs-studio\\bin\\64bit";
		obs.StartInfo.CreateNoWindow = true;
		obs.StartInfo.UseShellExecute = false;
		obs.Start();
	}

	public void KillRecording() {
		if (!isRecording) {
			return;
		}
		isRecording = false;

		obs.Kill ();
	}


	// Example of using OBS Screen Recording based on whether a specific scene is loaded.
	/*
	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if (Instance != this) {
			return;
		}
		if (scene.name == "Scene 1") {
			StartRecording ();
		}  else if (scene.name == "Menu") {
			KillRecording ();
		}
	}
	*/

}
	