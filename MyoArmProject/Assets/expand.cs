using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class expand : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localScale.x < 1)
			transform.localScale += new Vector3 (0.01f, 0.01f,0.01f);
	}
}
