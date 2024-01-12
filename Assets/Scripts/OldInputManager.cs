using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldInputManager : MonoBehaviour
{
    [SerializeField] private GameObject getAxisRaw;
    [SerializeField] private GameObject getAxis;

    [SerializeField] private bool useGetAxisRaw = true;

    public float moveSpeed = 5.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) 
            useGetAxisRaw = !useGetAxisRaw;

        MoveSphere();
        
    }

    void MoveSphere()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if(useGetAxisRaw)
        {
            getAxis.SetActive(false);
            getAxisRaw.SetActive(true);
            horizontalInput += Input.GetAxisRaw("Horizontal");
            verticalInput += Input.GetAxisRaw("Vertical");
        }
        else
        {
            getAxisRaw.SetActive(false);
            getAxis.SetActive(true);
            horizontalInput += Input.GetAxis("Horizontal");
            verticalInput += Input.GetAxis("Vertical");
        }

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
