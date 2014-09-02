using UnityEngine;
using System.Collections;

public class firescript : MonoBehaviour {
	float reloadcounter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(reloadcounter > 0)
		{
			reloadcounter += Time.deltaTime;
			
			if(reloadcounter > 0.5f)
			{
				reloadcounter = 0;
			}
		}
		
		if(Input.GetAxis("Fire1") > 0 && reloadcounter == 0)
		{
			Instantiate(Resources.Load("Koggel"), transform.position, transform.rotation);
			reloadcounter += Time.deltaTime;
		}
	}
}
