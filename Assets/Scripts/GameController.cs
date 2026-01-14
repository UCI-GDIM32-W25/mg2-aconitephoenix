using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsNumberText;
    [SerializeField] private GameObject _coinPrefab;
    private int _points;
    // Start is called before the first frame update
    void Start()
    {
        _points = 0;
        _pointsNumberText.text = _points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdatePoints()
    {
        _points++;
        _pointsNumberText.text = _points.ToString();
    }
}
