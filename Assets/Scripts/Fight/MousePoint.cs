using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MousePoint : MonoBehaviour {

    RaycastHit hit;
    public GameObject target;
    private float raycastLenght = 1000;
    List<GameObject> ChoseShip;
    void Start()
    {
        Debug.Log("Start MousePoint");
        ChoseShip = new List<GameObject>();
    }
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        choseUnitAndMove();
        Debug.DrawRay(ray.origin, ray.direction * raycastLenght, Color.yellow);
	}
    void choseUnitAndMove()
    {
        GameObject listobject;
        GameObject lifeobject;
        Transform life;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))//lefy przycisk myszy
        {
            Debug.Log("left buton clic");
            if (Physics.Raycast(ray, out hit, raycastLenght))
            {
                Debug.Log(hit.collider.gameObject.tag);
                Debug.Log("left buton clic1");
                if (hit.collider.gameObject.tag == "Player")
                {
                    Debug.Log("Player");
                    listobject = hit.collider.gameObject;
                    ChoseShip.Add(listobject);
                    life = listobject.transform.Find("Life");
                    lifeobject = life.gameObject;
                    lifeobject.SetActive(true);
                }
                else
                {
                    Debug.Log("other");
                    foreach (GameObject n in ChoseShip)
                    {
                        life = n.transform.Find("Life");
                        lifeobject = life.gameObject;
                        lifeobject.SetActive(false);
                    }
                }
            }
        }
        if (Input.GetMouseButtonDown(1))//prawy przycisk myszy
        {
            Debug.Log("right buton clic");
            //Poruszanie
        }
    }
}
