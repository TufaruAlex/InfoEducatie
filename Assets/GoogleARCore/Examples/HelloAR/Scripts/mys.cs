using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mys : MonoBehaviour
{
    protected Joystick joystick;
    public Animator anim;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var rb = GetComponent<Rigidbody>();
        if(joystick.Horizontal == 0 && joystick.Vertical == 0)
        {
            anim.SetBool("startswalking", false);
        }
        else
        {
            anim.SetBool("startswalking", true) ;
        }
        rb.velocity = new Vector3(joystick.Vertical * speed,0, joystick.Horizontal * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        // Change the cube color to green.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
