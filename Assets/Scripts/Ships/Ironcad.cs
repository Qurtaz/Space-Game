using UnityEngine;
using System.Collections;

public class Ironcad : Ship {
    private int Shield;
	// Use this for initialization
	void Start () {
        hpMax = 250;
        hp = hpMax;
        typStatku = "Ironcald";
        pancerz = 175;
        atak = 90;
        Shield = 0;
	}
    public override float getFightStrenght()
    {
        return (base.getFightStrenght() + Shield/100);
    }
    public override void ulepsz()
    {
        creatUpgrate();
        Shield = 1000;

    }
    public override void doing(Ship ship)
    {
        ship.setHP(atak);
    }
    public override void setHP(int atak)
    {
        if(Shield>0)
        {
            Shield -= atak;
        }
        else
        {
            base.setHP(atak);
        }

    }
    public void destroyShield()
    {
        if(Shield<=0)
        {
            destroyUpgrate();
        }
    }
	// Update is called once per frame
	void Update () {
        destroyShield();
        destroy();
	}
}
