using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bazavelocity : MonoBehaviour
{
    [HideInInspector]
    public bool start = false;

    Rigidbody rb;

    public Material defMat;
    public Material hitMat;
    public Material selMat;

    private Renderer ren;

    public Text val;

    [Range(0.1f, 100f)]

    public float speed = 2;

    Vector3 oldPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        oldPos = transform.position;
        val.text = speed.ToString();
        ren = GetComponent<Renderer>();
    }
    public void setSpeed(float value)
    {

        Debug.Log(value.ToString());
        speed = value;
        val.text = value.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (start == true)
        {
            rb.velocity = Vector3.right * speed;
        }
    }

    public void select()
    {
        ren.material = selMat;
    }
    public void reset()
    {

        transform.position = oldPos;
        start = false;
        ren.material = defMat;
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        ren.material = hitMat;
    }
}
