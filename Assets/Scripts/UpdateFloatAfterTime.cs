using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFloatAfterTime : MonoBehaviour
{
    [SerializeField] FloatVariable floatToUpdate;
    [SerializeField] float amount;
    [SerializeField] float time;

    private float timer;
    private bool timesUp;

    private void OnEnable()
    {
        timer = time;
        timesUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timesUp)
            return;

        timer -= Time.deltaTime;

        if ( timer <= 0 )
        {
            timesUp = true;
            floatToUpdate.value += amount;
        }
    }
}
