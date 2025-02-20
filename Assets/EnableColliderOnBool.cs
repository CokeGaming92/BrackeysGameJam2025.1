using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableColliderOnBool : MonoBehaviour
{
    [SerializeField] Collider2D theCollider;
    [SerializeField] BoolVariable boolVariable;
    [SerializeField] bool inverse;

    private bool storedValue;

    private void OnEnable()
    {
        UpdateStoredBool();
        UpdateCollider();
    }

    // Update is called once per frame
    void Update()
    {
        if (storedValue != boolVariable.value)
        {
            UpdateStoredBool();
            UpdateCollider();
        }

    }

    private void UpdateStoredBool()
    {
        if ( inverse )
            storedValue = !boolVariable.value;

        else
            storedValue = boolVariable.value;
    }

    private void UpdateCollider()
    {
        if  ( storedValue )
        {
            theCollider.enabled = true;
        }
        else
        {
            theCollider.enabled = false;
        }
    }
}
