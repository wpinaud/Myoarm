using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {
	
	public float autoLoadNextLevelAfter=3;
	public float fadeInStart=1;

	private GameObject[] logos;
	private Color color = new Color(255,255,255,0);
	
	public void Start(){
		logos = GameObject.FindGameObjectsWithTag ("logo");
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

	public void Update(){
		if (Time.time > fadeInStart) {
			color = new Color (color.r, color.g, color.b, color.a + 0.01f);
			if (logos.Length > 1) {
				logos [0].GetComponents<Image> ()[0].color = color;
				logos [1].GetComponents<Image> ()[0].color = color;
			}
		}
	}
}