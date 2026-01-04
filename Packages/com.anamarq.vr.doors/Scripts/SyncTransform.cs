using UnityEngine;

public class SyncTransform : MonoBehaviour
{
    [Header("Door model")]
    [SerializeField] Transform interactionModel;

    void FixedUpdate()
    {
        interactionModel.position = transform.position;
        interactionModel.rotation = transform.rotation;

    }
}
