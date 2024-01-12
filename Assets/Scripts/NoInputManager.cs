using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoInputManager : MonoBehaviour
{
    [SerializeField] private GameObject getKeyDown;
    [SerializeField] private GameObject getKey;

    [SerializeField] private bool useGetKeyDown = true;

    public float moveSpeed = 5.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
            useGetKeyDown = !useGetKeyDown;

        MoveCube();
    }

    void SwitchInput()
    {
        useGetKeyDown = !useGetKeyDown;
    }

    void MoveCube()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if(useGetKeyDown)
        {
            getKey.SetActive(false);
            getKeyDown.SetActive(true);

            if (Input.GetKeyDown(KeyCode.W))
                verticalInput = 1f;
            else if (Input.GetKeyDown(KeyCode.S))
                verticalInput = -1f;
            else if (Input.GetKeyDown(KeyCode.A))
                horizontalInput = -1f;
            else if (Input.GetKeyDown(KeyCode.D))
                horizontalInput = 1f;
        }
        else
        {
            getKeyDown.SetActive(false);
            getKey.SetActive(true);

            if (Input.GetKey(KeyCode.W))
                verticalInput = 1f;
            if (Input.GetKey(KeyCode.S))
                verticalInput = -1f;
            if (Input.GetKey(KeyCode.A))
                horizontalInput = -1f;
            if (Input.GetKey(KeyCode.D))
                horizontalInput = 1f;
        }

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
