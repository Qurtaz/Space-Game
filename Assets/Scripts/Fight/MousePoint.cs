using UnityEngine;
using System.Collections;

public class MousePoint : MonoBehaviour {

    RaycastHit hit;
    public GameObject target;
    private float raycastLenght = 1000;
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, raycastLenght))
        {
            target.transform.position = hit.point;
            Debug.Log(hit.collider.name);
        }
        Debug.DrawRay(ray.origin, ray.direction * raycastLenght, Color.yellow);
	}
}
