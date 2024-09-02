using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EscapeTimer : MonoBehaviour
{
    public float highScore;
    public float escapeTime;
    public TextMeshProUGUI hishScoreText;
    public TextMeshProUGUI escapeTimeText;
    float m_Timer;
    bool m_IsStop;
    public void setHighScore(){
        PlayerPrefs.SetFloat("HighScore", m_Timer);
        m_IsStop = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_IsStop = false;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetFloat("HighScore");
            hishScoreText.text = "High Score:" + highScore.ToString("F2") + "s";
        } else {
            hishScoreText.text = "No record";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_IsStop)
        {
            m_Timer += Time.deltaTime;
        }
        escapeTimeText.text = "Escape Time:" + m_Timer.ToString("F2") + "s";
    }
}
