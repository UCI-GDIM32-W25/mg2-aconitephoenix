using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsNumberText;
    [SerializeField] private GameObject _coinPrefab;
    private float _randomTimer;
    // Start is called before the first frame update
    void Start()
    {
        _randomTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        _randomTimer -= Time.deltaTime;
        if (_randomTimer <= 0.0f)
        {
            SpawnCoins();
        }
    }
    public void UpdatePoints(int points)
    {
        _pointsNumberText.text = points.ToString();
    }

    private void SpawnCoins()
    {
        GameObject coin = Instantiate(_coinPrefab);
        coin.transform.position += new Vector3(1, 0.3f);
        _randomTimer = Random.Range(0.0f, 4.0f);
    }
}
