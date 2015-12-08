using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public float autoLoadNextLevelAfter=3;
	
	public void Start(){
		if (autoLoadNextLevelAfter != 0) {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}
	
	public void LoadLevel(string name){
		Debug.Log ("New level load: " + name);
		Application.LoadLevel (name);
	}
	
	public void Quit(){
		Debug.Log ("Quit now");
		Application.Quit ();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}