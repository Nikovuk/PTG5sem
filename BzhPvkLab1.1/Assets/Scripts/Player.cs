using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public Camera MainCamera;
    public LayerMask background;

    [Range(10, 100)]
    public float forceLimit = 100;
    [Range(10, 300)]
    public float forceRate = 10;
    float force = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lineRenderer = GetComponent<LineRenderer>();

    }
    LineRenderer lineRenderer;
    Vector3 oldPos;
    Rigidbody rb;

    public Text ClickText;
    public Text ForceText;
    int ClickCounter = 0;
    int ForceCounter = 0;
    void FixedUpdate()
    {

        RaycastHit hit;
        Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
        

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, transform.position);

        if (Physics.Raycast(ray, out hit, 100, background))
        {
            Vector3 p = hit.point;
            p.z = transform.position.z;

            Vector3 dir = (p - transform.position);
            dir.Normalize();

            lineRenderer.SetPosition(1, (transform.position + (dir * (force / 10 + 2))));



            if (Input.GetAxisRaw("Fire1") > 0)
            {

                if (force < forceLimit)
                {
                    ForceCounter++;
                    ForceText.text = ForceCounter.ToString();
                    force += forceRate * Time.deltaTime;
                }
            }
            else
                if (force > 0)
            {
                ForceCounter = 0;
                ClickCounter++;
                ClickText.text = ClickCounter.ToString();
                rb.AddForce(dir * force, ForceMode.Impulse);

                force = 0;
            }
        }
    }
}

