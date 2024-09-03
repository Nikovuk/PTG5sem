using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Camera cam;
    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay( Input.mousePosition );

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            baza bs;

            if (objectHit.TryGetComponent<baza>(out bs) == true)
            {
                bs.select();

                if (Input.GetAxis("Fire1") >0 )
                {
                    bs.start = true;
                }
            }
        }
    }
}
