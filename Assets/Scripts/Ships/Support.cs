using UnityEngine;
using System.Collections;

public class Support : Ship {
    private int numberRepair;
    public void zeroRepair()
    {
        numberRepair = 5;
    }
    public void useRepair()
    {
        numberRepair--;
    }
    public void Start()
    {
        hpMax = 300;
        hp = hpMax;
        typStatku = "Support";
        pancerz = 150;
        atak = 0;
    }
    public override void ulepsz()
    {
        creatUpgrate();
        atak = 20;
    }
    public override void doing(Ship ship)
    {
        if(numberRepair!=0)
        {
            ship.repair();
        }
        else
        {
            ship.setHP(atak);
        }
    }
    void Update()
    {
        destroy();
    }
}
