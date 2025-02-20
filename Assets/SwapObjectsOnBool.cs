using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapObjectsOnBool : MonoBehaviour
{
    [SerializeField] BoolVariable boolVariable;
    [SerializeField] GameObject activeOnTrue;
    [SerializeField] GameObject activeOnFalse;

    private bool storedValue;

    private void OnEnable()
    {
        storedValue = boolVariable.value;

        UpdateObjects();
    }

    // Update is called once per frame
    void Update()
    {
        if ( storedValue != boolVariable.value )
        {
            storedValue = boolVariable.value;
            UpdateObjects();
        }
    }

    private void UpdateObjects()
    {
        if ( storedValue )
        {
            activeOnTrue!.SetActive(true);
            activeOnFalse!.SetActive(false);
        }
        else
        {
            activeOnTrue!.SetActive(false);
            activeOnFalse!.SetActive(true);
        }
    }
}
