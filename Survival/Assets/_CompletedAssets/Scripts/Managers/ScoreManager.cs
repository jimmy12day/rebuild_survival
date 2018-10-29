using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class ScoreManager : MonoBehaviour
    {
        public static int score;        // The player's score.
        public Text tips;

        Text text;                      // Reference to the Text component.


        void Awake ()
        {
            // Set up the reference.
            text = GetComponent <Text> ();

            // Reset the score.
            score = 0;
        }

        int a = 1000;

        void Update ()
        {
            // Set the displayed text to be the word "Score" followed by the score value.
            text.text = "Score: " + score;
            if (score >= a)
            {
                changeText(2 * a);
                //a = 2 * a;
            }
            if(score >= 2 * a)
            {
                a = 2 * a;
            }
        }

        void changeText(int goal)
        {
            tips.text = "Next goal: " + goal;
        }

    }
}