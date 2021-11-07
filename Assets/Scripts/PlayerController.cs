using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    InputController input;

    private float speedX = 0;
    private float speedY = 0;
    private float speedZ = 0;

    bool brake;
    Vector2 curve;
    
    [SerializeField] private float playerMaxSpeedNormal;
    [SerializeField] private float playerAxcel;
    [SerializeField] private float playerBrake;
    [SerializeField] private float playerSlippery;
    [SerializeField] AnimationCurve lotationSpeedCurve;
    [SerializeField] private float rotationSpeedMax;

    float rotationTime;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<InputController>();
    }

    // Update is called once per frame
    void Update()
    {
        Input();
        Move();
    }

    void Input()
    {
        
    }
    void Move()
    {
        Vector3 playerVelocity = transform.InverseTransformDirection(rb.velocity);

        if ( playerVelocity.z < playerMaxSpeedNormal && !input.brakeButton && input.AxcelButton)
        {
            speedZ += playerAxcel;
        }else if (input.brakeButton)
        {
            speedZ -= playerBrake;
            if (speedZ < 0)
            {
                speedZ = 0;
            }
        }

        if (speedZ > playerMaxSpeedNormal)
        {
            speedZ = playerMaxSpeedNormal;
        }

        Vector2 curveStick = input.curveStick;
        float rotationSpeed = 0;

        if (curveStick != Vector2.zero)
        {
            rotationTime += Time.deltaTime;
            rotationSpeed = lotationSpeedCurve.Evaluate(rotationTime)*rotationSpeedMax*curveStick.x;
        }
        else
        {
            rotationTime = 0;
            rotationSpeed = 0;
        }

        playerVelocity = new Vector3(speedX,rb.velocity.y,speedZ);
        Vector3 playerRotationVelocity = new Vector3(0,rotationSpeed,0);
        rb.velocity = transform.TransformDirection(playerVelocity);
        rb.angularVelocity = transform.TransformDirection(playerRotationVelocity);
    }

}
