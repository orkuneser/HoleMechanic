using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleCollider : MonoBehaviour
{
    [Header("Layers")]
    [SerializeField] private string _enterLayer;
    [SerializeField] private string _exitLayer;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.layer = LayerMask.NameToLayer(_enterLayer);
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = LayerMask.NameToLayer(_exitLayer);
    }
}
