using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapBoolOnTrigger : MonoBehaviour
{
    [SerializeField] BoolVariable boolVariable;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        boolVariable.value = !boolVariable.value;
    }
}
