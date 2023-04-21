using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveHorizontal = 30.0f;
    [SerializeField]
    private Rigidbody rb;

    public ButtonScript left;
    public ButtonScript right;




    public void FixedUpdate()
    {
        /*rb.AddForce(0, 0, moveSpeed * Time.deltaTime);*/

        /*if (Input.GetKey("a"))
        {
            rb.AddForce(-moveHorizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(moveHorizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }*/

        if (right.held)
        {
            rb.AddForce(moveHorizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (left.held)
        {
            rb.AddForce(-moveHorizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1.0f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

/*    public void LeftClick()
    {
        leftPress = true;
        rightPress= false;
        rb.AddForce(-moveHorizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void RightClick()
    {
        rightPress = true;
        leftPress = false;
        rb.AddForce(moveHorizontal * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }*/

}