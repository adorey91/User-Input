using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputManager : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    private Vector2 playerInput;


    public void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        Vector3 moveVector = new Vector3(playerInput.x, 0 , playerInput.y);

        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        playerInput = context.ReadValue<Vector2>();
    }

}


