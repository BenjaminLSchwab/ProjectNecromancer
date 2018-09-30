using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour {

    Entity entity;

	// Use this for initialization
	void Start () {
        entity = GetComponent<Entity>();
	}

    private void FixedUpdate()
    {
        entity.xThrottle = Input.GetAxis("Horizontal");
        entity.yThrottle = Input.GetAxis("Vertical");
    }
}
