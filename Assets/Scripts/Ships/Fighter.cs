using UnityEngine;
using System.Collections;

public class Fighter : Ship {

    private int piercingAmonition;
    public void Start()
    {
        hpMax = 100;
        hp = hpMax;
        typStatku = "Fighter";
        pancerz = 50;
        atak = 75;
        piercingAmonition = 0;
    }
    public override float getFightStrenght()
    {
        float z=0;
        if(ulepszenie==true)
        {
            z = 20;
        }
 	 return (base.getFightStrenght()+z);
    }
    public override void ulepsz()
    {
        creatUpgrate();
        piercingAmonition = 25;

    }
    public override void doing(Ship ship)
    {
        ship.setHP(atak + ship.pancerz / piercingAmonition);
    }
    void Update()
    {
        destroy();
    }
}
