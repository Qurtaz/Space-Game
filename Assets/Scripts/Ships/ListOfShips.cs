using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class GameShip
{
    public GameObject Fighter;
    public GameObject Ironclad;
    public GameObject Support;
}

public class ListOfShips : MonoBehaviour {

    List<GameObject> listShips;
    public int fighter;
    public int ironclad;
    public int support;
    public  GameShip CShips;

	// Use this for initialization
	void Start () {
        listShips = new List<GameObject>();
        int war = Random.Range(1,10);
        fighter = war;
        ironclad = 10 - war;
        
	}
    void Update()
    {

    }
    void addFighter()
    {
         listShips.Add(CShips.Fighter);
    }
    void addIroncald()
    {
         listShips.Add(CShips.Ironclad);
    }
    void addSupport()
    {
        listShips.Add(CShips.Support);
    }
	
	
}
