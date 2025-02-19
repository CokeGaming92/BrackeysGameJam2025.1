using TMPro;
using UnityEngine;
using System;
using System.Threading; // Needed for Action events

public class TimeSystem : MonoBehaviour
{
    [SerializeField] FloatVariable time;
    [SerializeField] TextMeshProUGUI timeUI;
    [SerializeField] bool isGameWon = false;

    public static event Action<int> OnTimeUp; // Event for when time reaches 0

  
    private void Start()
    {
        time.value = 60f;
        UpdateUI(); // Initialize UI
    }

    private void Update()
    {
        if (!isGameWon && time.value > 0)
        {
            time.value -= Time.deltaTime; // Decrease time every frame
            UpdateUI(); // Update the displayed time
        }
        else
        {
            time.value = 0; // Ensure it doesn't go negative
      

            // Trigger event and pass remaining time as bonus score
            OnTimeUp?.Invoke(Mathf.CeilToInt(time.value));
        }
    }

  

    public void ResetTimer()
    {
        isGameWon = false;
        time.value = 60f;
    }

    public float GetRemainingTime()
    {
        return Mathf.CeilToInt(time.value); // Returns the remaining time as an integer
    }

    private void UpdateUI()
    {
        timeUI.text = Mathf.CeilToInt(time.value).ToString(); // Convert to whole number
    }
}
