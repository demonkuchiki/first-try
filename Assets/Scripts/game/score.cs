using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "score: " + globelvars.score.ToString();
	}
}