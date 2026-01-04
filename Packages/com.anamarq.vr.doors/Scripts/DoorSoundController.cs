using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
[RequireComponent(typeof(AudioSource))]
public class DoorSoundController : MonoBehaviour
{
    [Header("Activation Angle")]
    [SerializeField]
    private float triggerAngle = 10f;

    [Header("Sounds")]
    [SerializeField]
    private AudioClip openSound;

    [SerializeField]
    private AudioClip closeSound;

    private HingeJoint hinge;
    private AudioSource audioSource;

    private bool isOpen = false;

    void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        audioSource = GetComponent<AudioSource>();

        audioSource.playOnAwake = false;
    }

    void Update()
    {
        float currentAngle = Mathf.Abs(hinge.angle);
        if (!isOpen && currentAngle >= triggerAngle)
        {
            PlayOpenSound();
            isOpen = true;
        }
        else if (isOpen && currentAngle < triggerAngle)
        {
            PlayCloseSound();
            isOpen = false;
        }
    }

    void PlayOpenSound()
    {
        if (openSound != null)
            audioSource.PlayOneShot(openSound);
    }

    void PlayCloseSound()
    {
        if (closeSound != null)
            audioSource.PlayOneShot(closeSound);
    }
}
