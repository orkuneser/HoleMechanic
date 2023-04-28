using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    [ReadOnly]
    public Vector3 InputDirection;

    private void Awake()
    {
        Instance = this;
    }
}
