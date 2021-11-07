using UnityEngine;
using UnityEngine.InputSystem;

public class GamepadExample : MonoBehaviour
{
    public Rigidbody rb;
    private void Start()
    {

    }
    void Update()
    {
        // ゲームパッドが接続されていないとnullになる。
        if (Gamepad.current == null) return;

        if (Gamepad.current.buttonNorth.wasPressedThisFrame)
        {
            Debug.Log("Button Northが押された！");
        }
        if (Gamepad.current.buttonSouth.wasReleasedThisFrame)
        {
            Debug.Log("Button Southが離された！");
        }
    }

    void OnGUI()
    {
        if (Gamepad.current == null) return;

        GUIStyle style = GUI.skin.label;
        GUIStyleState styleState = new GUIStyleState();
        styleState.textColor = Color.black;
        style.normal = styleState;

        GUI.backgroundColor = Color.black;
        GUILayout.Label($"leftStick: {Gamepad.current.leftStick.ReadValue()}");
        GUILayout.Label($"rightStick: {Gamepad.current.rightStick.ReadValue()}");
        GUILayout.Label($"buttonNorth: {Gamepad.current.buttonNorth.isPressed}");
        GUILayout.Label($"buttonSouth: {Gamepad.current.buttonSouth.isPressed}");
        GUILayout.Label($"buttonEast: {Gamepad.current.buttonEast.isPressed}");
        GUILayout.Label($"buttonWest: {Gamepad.current.buttonWest.isPressed}");
        GUILayout.Label($"leftShoulder: {Gamepad.current.leftShoulder.ReadValue()}");
        GUILayout.Label($"leftTrigger: {Gamepad.current.leftTrigger.ReadValue()}");
        GUILayout.Label($"rightShoulder: {Gamepad.current.rightShoulder.ReadValue()}");
        GUILayout.Label($"rightTrigger: {Gamepad.current.rightTrigger.ReadValue()}");
        GUILayout.Label($"PlayerVelocity: {transform.InverseTransformVector(rb.velocity)}");
        GUILayout.Label($"PlayerRotate: {transform.InverseTransformVector(rb.angularVelocity)}");
    }
}