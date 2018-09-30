using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : Enemy {

	void Start () 
	{
		base.MakeConnections();
	}
	
	void Update () 
	{
        base.Move();
	}

	private void OnCollisionEnter2D(Collision2D collision)
    {
        Entity other;
        if (collision.transform.GetComponent<Entity>())
        {
            other = collision.transform.GetComponent<Entity>();

            other.TakeDamage(1);

        }
    }
}

