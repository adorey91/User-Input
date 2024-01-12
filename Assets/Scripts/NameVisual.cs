using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameVisual : MonoBehaviour
{
    public void Update()
    {
        transform.forward = transform.position - Camera.main.transform.position;
    }
}
