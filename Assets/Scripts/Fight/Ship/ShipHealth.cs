using UnityEngine;
using UnityEngine.UI;

public class ShipHealth : MonoBehaviour {

    public float maxHealth;
    public Slider slider;
    public Image fillImage;
    public Color fullHeath = Color.green;
    public Color zeroHeath = Color.red;

    private Ship ship;
    float currentHealth;

	// Use this for initialization
	void Start () {
        ship = GetComponent<Ship>();
        maxHealth = ship.hpMax;
        Debug.Log(ship.hpMax);
        Debug.Log(maxHealth);
        slider.maxValue = maxHealth;
        SetHealthUI();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void SetHealthUI()
    {
        currentHealth = ship.hp;
        slider.value = currentHealth;

        // Interpolate the color of the bar between the choosen colours based on the current percentage of the starting health.
        fillImage.color = Color.Lerp(zeroHeath, fullHeath, currentHealth / maxHealth);
    }
}
