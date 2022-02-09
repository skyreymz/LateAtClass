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
	public Vector3 posP; //Position du panier
	public Vector3 posB; //Position du ballon
	public double r = 0.5; //rayon du ballon
	public int but = 0;
	// Use this for initialization
	void Start()
	{
		this.gameObject.GetComponent<SpriteRenderer>().sprite = score0;
	}
	long second = 0;
	int nbGoals = 0;
	void Update()
    {
		long first = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
		

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
		
		posP = GameObject.FindGameObjectWithTag("panier").transform.position;
		posB = GameObject.FindGameObjectWithTag("ball").transform.position;

		if (((Math.Pow(posB.z - posP.z, 2) + Math.Pow(posB.x, 2) + Math.Pow(posB.y - posP.y, 2)) <= Math.Pow(r, 2)) && ( Math.Abs(first - second) > 700) )
		{
			Debug.Log("buuuuuuuuuuuuuut");
			
			second = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
			nbGoals = nbGoals + 1;
		}
	}
}
