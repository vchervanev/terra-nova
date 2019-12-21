using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int score;
    Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
        textComponent.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score += Mathf.RoundToInt(Time.smoothDeltaTime * 50);
        textComponent.text = score.ToString();
    }

    public void OnHit()
    {
        score += 1000;
    }
}
