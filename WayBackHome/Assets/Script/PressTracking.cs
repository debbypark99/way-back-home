using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressTracking : MonoBehaviour {

    public GameObject Lights;
    public static bool tracking_donation = false;
    // Use this for initialization
    void Start () {
        Lights.SetActive(true);
	}

}
