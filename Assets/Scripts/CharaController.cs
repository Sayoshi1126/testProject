using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] PlayerController player;
    [SerializeField] GameObject Player;
    [SerializeField] InputController input;
    [SerializeField] AnimationCurve lotationSpeedCurve;
    [SerializeField] private float rotationSpeedMax;
    [SerializeField] private float rotateMax;

    float rotationTime;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 curveStick = input.curveStick;
        float rotationSpeed = 0;

        transform.localPosition = new Vector3(0,0.6f,0);

        if (curveStick != Vector2.zero)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else
        {
            rotationTime = 0;
            rotationSpeed = 0;
            transform.rotation = new Quaternion(0,0,0,0);
        }

        Vector3 playerRotationVelocity = new Vector3(0, rotationSpeed, 0);
        rb.angularVelocity = transform.TransformDirection(playerRotationVelocity);
    }
}
