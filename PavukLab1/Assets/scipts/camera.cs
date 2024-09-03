using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Camera cam;
    public GameObject[] spheres;
    // Update is called once per frame
    void FixedUpdate()
    {
       
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay( Input.mousePosition );

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            baza bs1;
            bazatrans bs2;
            bazavelocity bs3;
            bazaforce bs4;
            bazamove bs5;
            if (objectHit.TryGetComponent<baza>(out bs1) == true)
            {
                bs1.select();

                if (Input.GetAxis("Fire1") > 0)
                {
                    bs1.start = true;
                }
            }
            if (objectHit.TryGetComponent<bazatrans>(out bs2) == true)
            {
                bs2.select();
                if (Input.GetAxis("Fire1") > 0)
                {
                    bs2.start = true;
                }
            }
            if (objectHit.TryGetComponent<bazavelocity>(out bs3) == true)
            {
                bs3.select();
                if (Input.GetAxis("Fire1") > 0)
                {
                    bs3.start = true;
                }
            }
            if (objectHit.TryGetComponent<bazaforce>(out bs4) == true)
            {
                bs4.select();
                if (Input.GetAxis("Fire1") > 0)
                {
                    bs4.start = true;
                }
            }
            if (objectHit.TryGetComponent<bazamove>(out bs5) == true)
            {
                bs5.select();
                if (Input.GetAxis("Fire1") > 0)
                {
                    bs5.start = true;
                }
            }

        }

     
    }
}
