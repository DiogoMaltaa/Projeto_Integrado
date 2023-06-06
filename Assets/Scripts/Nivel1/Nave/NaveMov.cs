using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMov : MonoBehaviour
{
    [SerializeField] float movementSpeed = 500f;
    [SerializeField] float turnSpeed = 60f;
    [SerializeField] Thruster[] thruster;

    Transform myT;

    void Awake()
    {
        myT = transform;
    }


    // Update is called once per frame
    void Update()
    {
        Thrust();
        Turn();
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
        myT.Rotate(pitch, yaw, roll);

    }

    void Thrust()
    {
        //if we start thrust, call Thruster.Activate()
        //when we stop thurst, call Thruster.Activate(false)
        if (Input.GetAxis("Vertical") > 0)
        {
            myT.position += myT.forward * Time.deltaTime * Input.GetAxis("Vertical") * movementSpeed;
        }
            
        
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
                foreach (Thruster t in thruster)
                        t.Activate(true);
        }
                    
        else if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
                foreach (Thruster t in thruster)
                        t.Activate(false);
        }
                    


    }
    


}
