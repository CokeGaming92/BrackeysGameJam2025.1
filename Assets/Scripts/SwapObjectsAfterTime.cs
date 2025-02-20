using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapObjectsAfterTime : MonoBehaviour
{
    [SerializeField] float minTime;
    [SerializeField] float maxTime;
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject objectToDeactivate;

    private float timer;
    private bool timesUp;

    // Start is called before the first frame update
    void OnEnable()
    {
        timer = Random.Range(minTime, maxTime);
        timesUp = false;
    }

    private void Update()
    {
        if (timesUp)
            return;

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timesUp = true;
            SwapObjects();
        }
    }

    private void SwapObjects()
    {
        objectToActivate.SetActive(true);
        objectToDeactivate.SetActive(false);
    }
}
