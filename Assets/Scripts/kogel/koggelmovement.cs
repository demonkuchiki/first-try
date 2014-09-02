using UnityEngine;
using System.Collections;

public class koggelmovement : MonoBehaviour {
	float dictence;
	gameManger GameManger;
	float counter;
	void Start () 
	{
		GameManger = GameObject.Find("GameObject").GetComponent<gameManger>();
	}
	

	void Update () 
	{
		/*dictence += Time.deltaTime;
		if (dictence > 25)
		{
			Destroy(gameObject);
		}*/
		counter += Time.deltaTime;
		if (counter > 3)
		{
			Destroy (gameObject);
		}
		
		transform.Translate(0, 0, 25 * Time.deltaTime);
		
		/*foreach(GameObject enemy in GameManger.enemies)
		{
			if(enemy != null)
			{
				if(Vector3.Distance(transform.position, enemy.transform.position) < 2)
				{
					Destroy (enemy);
					Destroy (this.gameObject);
				}
			}
	
		}*/
	}
	void OnCollisionEnter (Collision collision)
	{
		if(collision.collider.name == "enemy")
		{
			//Destroy(collision.collider.gameObject);
			//Destroy(gameObject);
			globelvars.score ++;
			collision.collider.renderer.material.color = Color.red;
		}
	}
}