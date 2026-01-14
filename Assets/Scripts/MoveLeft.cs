using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private Transform _coinTransform;

    // Update is called once per frame
    void Update()
    {
        _coinTransform.Translate(Vector3.left * 3.0f * Time.deltaTime);
    }
}
