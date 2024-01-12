using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField] private GameObject noInputCube;
    [SerializeField] private GameObject oldInputSphere;
    [SerializeField] private GameObject newInputCube;
    
    [Header("Buttons")]
    [SerializeField] private Button noInputButton;
    [SerializeField] private Button oldInputButton;
    [SerializeField] private Button newInputButton;

    [Header("UI Text")]
    [SerializeField] private GameObject noInputText;
    [SerializeField] private GameObject oldInputText;
    [SerializeField] private GameObject newInputText;
    
    void Start()
    {
        noInputCube.SetActive(false);
        oldInputSphere.SetActive(false);
        newInputCube.SetActive(false);
    }

    public void NoInputButton()
    {
        oldInputSphere.SetActive(false);
        newInputCube.SetActive(false);
        noInputCube.SetActive(true);

        noInputButton.interactable = false;
        oldInputButton.interactable = true;
        newInputButton.interactable = true;

        oldInputText.SetActive(false);
        newInputText.SetActive(false);
        noInputText.SetActive(true);
    }

    public void OldInputButton()
    {
        noInputCube.SetActive(false);
        newInputCube.SetActive(false);
        oldInputSphere.SetActive(true);

        oldInputButton.interactable = false;
        noInputButton.interactable = true;
        newInputButton.interactable = true;

        noInputText.SetActive(false);
        newInputText.SetActive(false);
        oldInputText.SetActive(true) ;
    }


    public void NewInputButton()
    {
        oldInputSphere.SetActive(false);
        noInputCube.SetActive(false);
        newInputCube.SetActive(true);

        newInputButton.interactable = false;
        noInputButton.interactable = true;
        oldInputButton.interactable = true;

        oldInputText.SetActive(false);
        noInputText.SetActive(false); ;
        newInputText.SetActive(true);
    }
}
