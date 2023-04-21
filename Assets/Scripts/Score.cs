using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI scoreText;
    private float timer;
    private float score;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > .5f)
        {

            score += 1;

            //We only need to update the text if the score changed.
            scoreText.text = score.ToString("0");

            //Reset the timer to 0.
            timer = 0;
        }
    }
}
