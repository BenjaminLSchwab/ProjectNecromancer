using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    [SerializeField] protected float movementSpeed = 1f; //Added protected so I could access this variable in derived classes
    [SerializeField] int m_maxHealth = 10;
    int m_health;

    public float xThrottle = 0f;
    public float yThrottle = 0f;
    public Rigidbody2D rb;

    public Entity()
    {
        m_health = m_maxHealth;
    }


	// Use this for initialization
	void Start () {
        MakeConnections();
	}
	
    private void FixedUpdate()
    {
      
    }

    protected virtual void Move()
    {

        Vector2 force;
        force.x = xThrottle;
        force.y = yThrottle;

        force = force * movementSpeed;

        rb.AddForce(force);
    }

    protected virtual void MakeConnections()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public int GetHealth()
    {
        return m_health;
    }

    public virtual void SetHealth(int health)
    {
        if (health > m_maxHealth)
        {
            health = m_maxHealth;
            return;
        }

        m_health = health;

    }

    public virtual void TakeDamage(int damage)
    {
        if (m_health - damage <= 0)
        {
            m_health = 0;
            Die();
            return;
        }

        m_health -= damage;
        Debug.Log(m_health);

    }

    public void Die()
    {
        this.gameObject.SetActive(false);
    }
}
