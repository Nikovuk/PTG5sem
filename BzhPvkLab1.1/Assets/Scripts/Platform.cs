using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Rigidbody rb;

    private Vector3 startPos;
    public Vector3 endPos;

    private Vector3 targetPos;

    public float speed;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
        targetPos = endPos;
    }

    void FixedUpdate()
    {
        Vector3 currentPos = transform.position;

        if(Vector3.Distance(currentPos, endPos) < 0.9)
        {
            targetPos = startPos;
        }
        else if (Vector3.Distance(currentPos, startPos) < 0.9)
        {
            targetPos = endPos;
        }

        Vector3 targetDirection = (targetPos - currentPos).normalized;
        rb.MovePosition(currentPos + targetDirection * speed * Time.deltaTime);
    }
}