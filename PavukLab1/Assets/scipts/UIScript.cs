using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject sphere;

    // Update is called once per frame
    public void reset()
    {
        sphere.GetComponent<baza>().reset();
    }
}
