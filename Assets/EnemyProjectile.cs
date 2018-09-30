using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : Projectile {

	// Use this for initialization
	void Start () {
        base.MakeConnections();
	}
	
	// Update is called once per frame
	void Update () {
        base.Move();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Entity other;
        if (collision.transform.GetComponent<Player>())
        {
            other = collision.transform.GetComponent<Player>();

            other.TakeDamage(m_damage);
        }

        this.gameObject.SetActive(false);
    }
}
