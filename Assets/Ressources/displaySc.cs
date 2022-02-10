using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class displaySc : MonoBehaviour
{
	public Sprite score0; // relié score1 sprite sur unity
	public Sprite score1; // relié score1 sprite sur unity
	public Sprite score2; // relié score2 sprite sur unity
	public Sprite score3; // relié score3 sprite sur unity
	
	public double r = 0.05; //rayon du ballon

	public GameObject ballon;
	public GameObject panier1;
	//public GameObject panier2;

	private Vector3 posB; //Position du ballon
	private Vector3 posP1; //Position du panier 1
	//public Vector3 posP2; //Position du panier 2

	long second = 0;
	int nbGoals = 0;

	// Use this for initialization
	void Start()
	{
		this.gameObject.GetComponent<SpriteRenderer>().sprite = score0;

		posP1 = panier1.transform.position;
		Debug.Log("Position du panier :" + posP1);
		//posP2 = panier1.transform.position;
	}
	
	void Update()
    {
		long first = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

		//posP = GameObject.Find("/Basket/Panier1/2").transform.position;
		//posB = GameObject.Find("/Basket/basketball").transform.position;
		posB = ballon.transform.position;

			if (((Math.Pow(posB.z - posP1.z, 2) + Math.Pow(posB.x - posP1.x, 2) + Math.Pow(posB.y - posP1.y, 2)) <= Math.Pow(r, 2)) && ( Math.Abs(first - second) > 700) )
		{
			Debug.Log("buuuuuuuuuuuuuut");
			Debug.Log("Position du ballon : " + posP1.x + " " + posP1.y + " " + posP1.z);
			
			second = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
			nbGoals = nbGoals + 1;

			if (nbGoals == 1)
			{
				this.gameObject.GetComponent<SpriteRenderer>().sprite = score1;
			}
			else if (nbGoals == 2)
			{
				this.gameObject.GetComponent<SpriteRenderer>().sprite = score2;
			}
			else if (nbGoals == 3)
			{
				this.gameObject.GetComponent<SpriteRenderer>().sprite = score3;
			}
		}
	}
}
