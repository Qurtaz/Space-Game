using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ShipShoot : MonoBehaviour {

    public List<GameObject> shotSpawn ;
    public GameObject shot;
    public GameObject target;
    public GameObject rangeDetectedEnemy;
    private float time;

    void Awake()
    {
    }
	// Use this for initialization
	void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            target = null;
        }
    }
    void OnTriggerStay(Collider other)
    {
        time += Time.deltaTime;
        if(time>=0.25f &&  other.gameObject.tag != "Space")
        {
            Debug.Log(other.name);
            time = 0;
            shoot();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            target = other.gameObject;
            rotation();

        }
    }
    private void shoot()
    {
        foreach(GameObject shooter in shotSpawn)
        {
           Instantiate(shot, shooter.transform.position, shooter.transform.rotation) ;
        }
    }
    private void rotation()
    {
        transform.LookAt(target.transform);
    }
}
