using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jump = 4.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private GameController _gameController;
    private bool _isGrounded;
    private int _points;

    // Start is called before the first frame update
    void Start()
    {
        _points = 0;
        _gameController.UpdatePoints(_points);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isGrounded)
            {
                _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
                _isGrounded = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.Equals("Ground"))
        {
            _isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Destroy(collision.gameObject);
            _points++;
            _gameController.UpdatePoints(_points);
        }
    }
}
