using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillaController : MonoBehaviour {

    public GameObject makevisible;
    private bool visible = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (visible)
        {
            visible = !visible;
            makevisible.SetActive(false);
        }
        else
        {
            visible = !visible;
            makevisible.SetActive(true);
        }
    }

}
