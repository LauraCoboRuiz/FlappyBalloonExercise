using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform target;
    public float offset;
    public float yPos, zPos;
    public float smooth;

    private Vector3 velocity = Vector3.zero;
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 newPos = new Vector3(target.position.x + offset, yPos, zPos);
        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smooth);
	}
}
