using UnityEngine;

public class FootstepSystem : MonoBehaviour
{
    public AudioClip[] footstepSounds;
    public float minTime = 0.3f;
    public float maxTime = 0.6f;

    private AudioSource audioSource;
    public bool isWalking = false;
    private float timeSinceLastFootstep;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isWalking)
        {
            if(Time.time - timeSinceLastFootstep >=
                Random.Range(minTime, maxTime))
            {
                AudioClip footstepSound = footstepSounds[Random.Range(0, footstepSounds.Length)];
                audioSource.PlayOneShot(footstepSound);

                timeSinceLastFootstep = Time.time;
            }
        }
    }
}
