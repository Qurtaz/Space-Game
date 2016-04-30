using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
public class PlayerControler : MonoBehaviour {
    private Rigidbody rigidbodyd;
    public float speed;
    public float tilt;
    public Boundary boundary;
	// Use this for initialization
	void Start () {
        rigidbodyd = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidbodyd.velocity = movement * speed;

        rigidbodyd.position = new Vector3
        (
            Mathf.Clamp(rigidbodyd.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rigidbodyd.position.z, boundary.zMin, boundary.zMax)
        );
        rigidbodyd.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbodyd.velocity.x * -tilt);
    }

   
}
