using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public lookat target;
	float reloadcounter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(reloadcounter > 0)
		{
			reloadcounter += Time.deltaTime;
			
			if(reloadcounter > 0.5f)
			{
				reloadcounter = 0;
			}
		}
		
		if(reloadcounter == 0)
		{
			Instantiate(Resources.Load("Koggel"), transform.position, transform.rotation);
			reloadcounter += Time.deltaTime;
		}
	}
}
