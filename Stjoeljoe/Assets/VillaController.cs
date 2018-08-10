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
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (visible && (hit.collider == null || hit.collider.gameObject != this.gameObject))
                {
                    this.OnMouseDown();
                }

            }

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
