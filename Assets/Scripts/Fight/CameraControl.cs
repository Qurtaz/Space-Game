using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
    private float speed = 5.0f;
    public Boundary controlCamera;
    void Update()
    {
        bool keybord = AreCameraKeyboardButtonPressed();
        if(keybord == true)
        {
            keybordControl();
        }
        
    }

    public void keybordControl()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if(transform.position.x<=controlCamera.xMax)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.position.x >= controlCamera.xMin)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (transform.position.y <= controlCamera.zMax)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (transform.position.y >= controlCamera.zMin)
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }
    }
    public static bool AreCameraKeyboardButtonPressed()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            return true;
        else return false;
    }
}
