using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public Vector2 leftStick;
    public Vector2 rightStick;
    public bool buttonNorth;
    public bool buttonSouth;
    public bool buttonEast;
    public bool buttonWest;
    public bool leftShoulder;
    public bool leftTrigger;
    public bool rightShoulder;
    public bool rightTrigger;

    public enum Axcel
    {
        buttonNorth,
        buttonSouth,
        buttonEast,
        buttonWest,
        leftShoulder,
        leftTrigger,
        rightShoulder,
        rightTrigger,
        none,
    }
    [SerializeField] Axcel axcel;
    [HideInInspector] public bool AxcelButton;
    public enum Brake
    {
        buttonNorth,
        buttonSouth,
        buttonEast,
        buttonWest,
        leftShoulder,
        leftTrigger,
        rightShoulder,
        rightTrigger,
    }
    [SerializeField] Brake brake;
    [HideInInspector] public bool brakeButton;
    public enum Drift
    {
        buttonNorth,
        buttonSouth,
        buttonEast,
        buttonWest,
        leftShoulder,
        leftTrigger,
        rightShoulder,
        rightTrigger,
    }
    [SerializeField] Drift drift;
    [HideInInspector] public bool driftButton;
    public enum Curve
    {
        rightStick,
        leftStick,
    }
    [SerializeField] Curve curve;
    [HideInInspector] public Vector2 curveStick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftStick = Gamepad.current.leftStick.ReadValue();
        rightStick = Gamepad.current.rightStick.ReadValue();
        buttonNorth = Gamepad.current.buttonNorth.isPressed;
        buttonSouth = Gamepad.current.buttonSouth.isPressed;
        buttonEast = Gamepad.current.buttonEast.isPressed;
        buttonWest = Gamepad.current.buttonWest.isPressed;
        leftShoulder = Gamepad.current.leftShoulder.isPressed;
        leftTrigger = Gamepad.current.leftTrigger.isPressed;
        rightShoulder = Gamepad.current.rightShoulder.isPressed;
        rightTrigger = Gamepad.current.rightTrigger.isPressed;

        if(axcel == Axcel.buttonNorth)
        {
            AxcelButton = buttonNorth;
        }else if (axcel == Axcel.buttonEast)
        {
            AxcelButton = buttonSouth;
        }
        else if (axcel == Axcel.buttonWest)
        {
            AxcelButton = buttonWest;
        }
        else if (axcel == Axcel.buttonSouth)
        {
            AxcelButton = buttonEast;
        }
        else if (axcel == Axcel.leftShoulder)
        {
            AxcelButton = leftShoulder;
        }
        else if (axcel == Axcel.leftTrigger)
        {
            AxcelButton = leftTrigger;
        }
        else if (axcel == Axcel.rightShoulder)
        {
            AxcelButton = rightShoulder;
        }
        else if (axcel == Axcel.rightTrigger)
        {
            AxcelButton = rightTrigger;
        }else if (axcel == Axcel.none)
        {
            AxcelButton = true;
        }

        if(brake == Brake.buttonNorth)
        {
            brakeButton = buttonNorth;
        }else if (brake == Brake.buttonEast)
        {
            brakeButton = buttonEast;
        }
        else if (brake == Brake.buttonWest)
        {
            brakeButton = buttonWest;
        }
        else if (brake == Brake.buttonSouth)
        {
            brakeButton = buttonSouth;
        }
        else if (brake == Brake.leftShoulder)
        {
            brakeButton = leftShoulder;
        }
        else if (brake == Brake.leftTrigger)
        {
            brakeButton = leftTrigger;
        }
        else if (brake == Brake.rightShoulder)
        {
            brakeButton = rightShoulder;
        }
        else if (brake == Brake.rightTrigger)
        {
            brakeButton = rightTrigger;
        }

        if(curve == Curve.leftStick)
        {
            curveStick = leftStick;
        }
        else if (curve == Curve.rightStick)
        {
            curveStick = rightStick;
        }
    }
}
