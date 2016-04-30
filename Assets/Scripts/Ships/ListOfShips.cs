using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class GameShip
{
    public GameObject Fighter;
    public GameObject Ironclad;
    public GameObject Support;
    public GameObject upFighter;
    public GameObject upIronclad;
    public GameObject upSupport;
}

public class ListOfShips {

    public int fighter;
    public int upfighter;
    public int ironclad;
    public int upironclad;
    public int support;
    public int upsupport;
    public  GameShip CShips;

    public void addFighter()
    {
        fighter++;
    }
    public void addIroncald()
    {
        ironclad++;
    }
    public void addSupport()
    {
        support++;
    }
    public void addUpfighter()
    {
        upfighter++;
        fighter--;

    }
    public void addUpironcald()
    {
        upironclad++;
        ironclad--;
    }
    public void addUpsupport()
    {
        upsupport++;
        support--;
    }
	public float fighhtStrenght()
    {
        Ship zf;
        float z;
        zf = CShips.Fighter.GetComponent<Ship>();
        z = fighter * zf.getFightStrenght();
        zf = CShips.upFighter.GetComponent<Ship>();
        z += fighter * zf.getFightStrenght();
        zf = CShips.Ironclad.GetComponent<Ship>();
        z += fighter * zf.getFightStrenght();
        zf = CShips.upIronclad.GetComponent<Ship>();
        z += fighter * zf.getFightStrenght();
        zf = CShips.Support.GetComponent<Ship>();
        z += fighter * zf.getFightStrenght();
        zf = CShips.upSupport.GetComponent<Ship>();
        z += fighter * zf.getFightStrenght();
        return z;
    }
}
