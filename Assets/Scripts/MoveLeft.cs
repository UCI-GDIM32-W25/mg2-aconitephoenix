using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private Transform _coinTransform;
    [SerializeField] private GameController _gameController;

    // Update is called once per frame
    void Update()
    {
        _coinTransform.Translate(Vector3.left * 3.0f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.Equals("Player"))
        {
            _gameController.UpdatePoints();
            Destroy(gameObject);
        }
    }
}
