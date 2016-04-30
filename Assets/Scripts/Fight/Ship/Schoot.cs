using UnityEngine;
using System.Collections;

public class Schoot : MonoBehaviour {
    public float speed;
    public GameObject Ship;
    private Rigidbody rb;
    public int dmg;
    private Ship shipParent;
    private Ship shipCol;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity =  transform.up * speed;
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag!=Ship.tag && collision.gameObject.tag != "Space")
        {
            shipCol = gameObject.GetComponent<Ship>();
            shipParent.doing(collision.gameObject);
            shipCol.setHP(dmg);
        }
        if(collision.gameObject.tag==Ship.tag)
        {
            shipParent.doing(collision.gameObject);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
