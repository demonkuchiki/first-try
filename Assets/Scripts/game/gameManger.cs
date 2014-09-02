using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManger : MonoBehaviour {
	float enemyfirecounter;
	public List<GameObject> enemies = new List<GameObject>();
	public int score;
	public int random;
	
	void Start () {
		for(int i = 0; i < 6; i++)
		{
			for(int j = 0; j < 6; j++)
			{
				random = Random.Range(0, 3);
				
				GameObject newObject = Instantiate(Resources.Load("enemy"), new Vector3(4 * j,0,4 * i), Quaternion.identity) as GameObject;
				newObject.transform.Rotate(0, Random.Range(-360, 360), 0);
				newObject.name = "enemy";
				enemies.Add (newObject);
				
				if(random==0)
				{
					newObject.renderer.material.color = Color.blue;
				}
				else if(random==1)
				{
					newObject.renderer.material.color = Color.red;
				}
				else if(random==2)
				{
					newObject.renderer.material.color = Color.green;
				}
			}
		}
	}
	

	void Update () {
		enemyfirecounter += Time.deltaTime;
		if(enemyfirecounter > 3)
		{
			//enemyfirecounter = 0;
			//int random = Random.value.Ranges(0, enemies.Count);
			//Vector3 postes  = new Vector3(enemies[random], transform.position. x, 3, enemies[random].transform.);
			//GameObject newObject = Instantiate(Resources.Load("enemybullet"), postes  );
		}
	}
}
