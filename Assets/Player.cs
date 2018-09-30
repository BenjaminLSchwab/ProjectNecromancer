using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {
	Animator animator;

	void Start () {
		animator = gameObject.GetComponent<Animator>();
        base.MakeConnections();
	}

    private void FixedUpdate()
    {
        base.Move();
        Animate();
    }

    void Animate()
    {
    	animator.SetFloat("X Throttle", xThrottle);
    	animator.SetFloat("Y Throttle", yThrottle);
    }

}
