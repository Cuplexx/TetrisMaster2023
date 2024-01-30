using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class pointsco : MonoBehaviour
{
    public int myPoints = 0;

    private TextMeshProUGUI pointsCounter;

    public static pointsco pointsInstance;
    private void Awake()
    {
        if (pointsInstance == null)
        {
            pointsInstance = this;
        }
    }
    public void Start()
    {
        pointsCounter = GetComponent<TextMeshProUGUI>();
    }
    public void ScorePoints(int points)
    {
        myPoints += points;
    }

    public void UpdatePoints()
    {
        pointsCounter.text = "" + myPoints;
    }

    void Update()
    {

    }
}