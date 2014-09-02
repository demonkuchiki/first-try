using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	//int numertje = 5;
	//float komma = 1.5f * 1;
	//string name = "hello";
	//bool iswaar = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetAxis("Horizontal") > 0)
		{
			transform.Rotate(0, 20 * Time.deltaTime, 0);
		}else if(Input.GetAxis("Horizontal") < 0)
		{
			transform.Rotate(0, -20 * Time.deltaTime, 0);
		}
		
		if(Input.GetAxis("Vertical") > 0)
		{
			transform.Translate(0, 0, 5 * Time.deltaTime);
		}else if(Input.GetAxis("Vertical") < 0)
		{
			transform.Translate(0, 0, -5 * Time.deltaTime);
		}
	}
}
