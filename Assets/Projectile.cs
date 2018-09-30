using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField]float m_speed;
    [SerializeField] Vector2 m_dir;
    [SerializeField] protected int m_damage;
    Rigidbody2D rb;

    private void Start()
    {
        MakeConnections();
    }

    private void FixedUpdate()
    {
        Move();
    }

    protected void MakeConnections()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected void Move()
    {
        Vector2 force = m_dir * m_speed;
        rb.AddForce(force);
    }

}
