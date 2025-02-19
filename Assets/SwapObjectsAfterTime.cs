using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapObjectsAfterTime : MonoBehaviour
{
    [SerializeField] float minTime;
    [SerializeField] float maxTime;
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject objectToDeactivate;

    // Start is called before the first frame update
    void OnEnable()
    {
        float timer;

        timer = Random.Range(minTime, maxTime);
        Invoke("SwapObjects", timer);
    }

    private void SwapObjects()
    {
        objectToActivate.SetActive(true);
        objectToDeactivate.SetActive(false);
    }
}
