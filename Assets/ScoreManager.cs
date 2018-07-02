using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Random = UnityEngine.Random;
using System.Collections.Generic;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.

    TextMeshProUGUI text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<TextMeshProUGUI>();

        // Reset the score.
         score = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Total Points Collected: " + score;
    }

}
