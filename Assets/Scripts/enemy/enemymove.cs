using UnityEngine;
using System.Collections;

public class enemymove : MonoBehaviour {
	//bool moveR = false;
	//bool moveL = true;
	//bool moveF1 = true;
	//bool moveF2 = true;
	//float movecounter = 0;
	float Range;
	public int color;
	gameManger GameManger;
	
	// Use this for initialization
	void Start () {
	Range = Time.deltaTime * 4;
	GameManger = GameObject.Find("GameObject").GetComponent<gameManger>();
		
		if(renderer.material.color == Color.blue)
		{
			color = 0;
		}
		else if(renderer.material.color == Color.red)
		{
			color = 1;
		}
		else if(renderer.material.color == Color.green)
		{
			color = 2;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//beweeging space invaders
		/*movecounter += Time.deltaTime;
		if(movecounter > 1)
		{
			movecounter = 0;
		}
		if(moveR == false && movecounter == 0)
		{
			moveR = true;
			transform.Translate(100 * Time.deltaTime, 0, 0);
			moveF1 = false;
		}
		else if(moveF1 == false && movecounter == 0)
		{
			transform.Translate(0,0,-50 * Time.deltaTime);
			moveF1 = true;
			moveL = false;
		}
		else if(moveL == false && movecounter == 0)
		{
			transform.Translate(-100 * Time.deltaTime,0,0);
			moveL = true;
			moveF2 = false;
		}
		 else if(moveF2 == false && movecounter == 0)
		{
			transform.Translate(0,0,-50 * Time.deltaTime);
			moveF2 = true;
			moveR = false;
		}*/

		transform.Translate(0,0,Range);
		
		if (Vector3.Distance(transform.position, GameObject.Find("GameObject").transform.position) > 20)
		{
			Range = -Range;
		}
		
		int enemyIndex = 0;
		foreach(GameObject enemy in GameManger.enemies)
		{
			int doelIndex = 0;
			foreach(GameObject doel in GameManger.enemies)
			{
				if (Vector3.Distance(enemy.transform.position, doel.transform.position) < 1)
				{
					if(doel.GetComponent<enemymove>().color == 0 && enemy.GetComponent<enemymove>().color == 2)
					{
						doel.GetComponent<enemymove>().color = 2;
						colorchange(doel);
					}
					
					else if(doel.GetComponent<enemymove>().color == 1 && enemy.GetComponent<enemymove>().color == 0)
					{
						doel.GetComponent<enemymove>().color = 0;
						colorchange(doel);
					}
					
					else if(doel.GetComponent<enemymove>().color == 2 && enemy.GetComponent<enemymove>().color == 1)
					{
						doel.GetComponent<enemymove>().color = 1;
						colorchange(doel);
					}
					Range = -Range;
				}
				doelIndex++;
			}
			enemyIndex++;
		}
	}
	
	
	void colorchange (GameObject Doel)
	{
		if(Doel.GetComponent<enemymove>().color == 0)
		{
			Doel.renderer.material.color = Color.blue;
		}
			
		else if(Doel.GetComponent<enemymove>().color == 1)
		{
			Doel.renderer.material.color = Color.red;
		}
			
		else if(Doel.GetComponent<enemymove>().color == 2)
		{
			Doel.renderer.material.color = Color.green;
		}
		
	}
}
