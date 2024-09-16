using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject[] spheres;

    // Update is called once per frame
    /*    public void reset()
        {
            for (int i = 0; i < spheres.Length; i++)
            {
                spheres[i].GetComponent<baza>().reset();
                spheres[i].GetComponent<bazaforce>().reset();
                spheres[i].GetComponent<bazamove>().reset();
                spheres[i].GetComponent<bazatrans>().reset();
                spheres[i].GetComponent<bazavelocity>().reset();
            }
        }
    }*/
    public void reset()
    {

            spheres[0].GetComponent<baza>().reset();
            spheres[1].GetComponent<bazaforce>().reset();
            spheres[2].GetComponent<bazamove>().reset();
            spheres[3].GetComponent<bazatrans>().reset();
            spheres[4].GetComponent<bazavelocity>().reset();

    }
}