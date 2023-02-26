using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	private float speed = Menu.rotatorSpeed;
	public SpriteRenderer rColor;
	static int theColor;

	public void Start()
	{
		theColor = Menu.rotatorColor;
		Debug.Log(theColor);
		if (theColor == 0)
		{
			rColor.color = Color.black;
		}
		else if (theColor == 1)
		{
			rColor.color = Color.red;
		}
		else if (theColor == 2)
		{
			rColor.color = Color.green;
		}
		else if (theColor == 3)
		{
			rColor.color = Color.blue;
        }
	}

	void Update ()
	{
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}

}
