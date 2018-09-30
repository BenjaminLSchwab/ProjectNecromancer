using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity {

	[SerializeField] GameObject target;
    [SerializeField] float raycastOffset;
    [SerializeField] float stoppingDistance;
    float switchDirectionSpeed = 3;

	void Start () 
	{
        if (target == null)
        {
            target = FindObjectOfType<Player>().gameObject;
        }
		base.MakeConnections();
	}
	
	void Update () 
	{
        Move();
	}


    protected override void Move()
    {
		Vector2 raycastDirection = target.transform.position - transform.position;
        if (raycastDirection.magnitude < stoppingDistance)
        {
            xThrottle = 0;
            yThrottle = 0;
            return;
        }

        raycastDirection = raycastDirection.normalized;
        Vector2 offset = raycastDirection * raycastOffset;

		Vector2 startingPosition = new Vector2(transform.position.x, transform.position.y);
        startingPosition += offset;
		//Debug.DrawRay(transform.position, raycastDirection, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(startingPosition, raycastDirection);
        Debug.DrawRay(startingPosition, raycastDirection, Color.red);
        Debug.Log(hit.transform.gameObject);

        if (hit.transform.gameObject == target)
        {
            xThrottle = raycastDirection.normalized.x;
            yThrottle = raycastDirection.normalized.y;

        }


        base.Move();
    }

}

