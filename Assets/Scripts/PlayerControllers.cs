using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public void Jump(InputAction.CallbackContext context){
        Debug.log("Jump Pressed");
    }

    public void Jump(InputAction.CallbackContext context){
        Debug.log("Movement Pressed : " + context.ReadValue<Vector2>());
    }
}
