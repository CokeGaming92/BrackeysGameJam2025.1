using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapObjectsOnTrigger : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject objectToDeactivate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objectToActivate.SetActive(true);
        objectToDeactivate.SetActive(false);
    }
}
