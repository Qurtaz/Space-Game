using UnityEngine;
using System.Collections;

public class Schoot : MonoBehaviour {
    public float speed;
    GameObject Parent;
    private Rigidbody rb;
    public int dmg;
    private Ship shipParent;
    private Ship shipCol;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity =  transform.forward * speed;
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag!=Parent.tag && collision.gameObject.tag != "Space")
        {
            shipCol = gameObject.GetComponent<Ship>();
            shipCol.setHP(dmg);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
