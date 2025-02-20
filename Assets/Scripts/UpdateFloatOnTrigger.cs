using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFloatOnTrigger : MonoBehaviour
{
    [SerializeField] FloatVariable floatToUpdate;
    [SerializeField] float amount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        floatToUpdate.value += amount;
    }
}
