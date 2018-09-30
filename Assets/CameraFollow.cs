using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField] Transform m_target;
    public float cameraSpeed = 2;

	// Use this for initialization
	void Start () {
        if (m_target == null)
        {
            m_target = FindObjectOfType<Player>().transform;
        }
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 viewingPos = m_target.position;
        viewingPos.z = -10;
        transform.position = Vector3.Slerp(transform.position, viewingPos, Time.deltaTime * cameraSpeed);
	}
}
