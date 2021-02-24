using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public 	TextMeshProUGUI Text;
	public int	Score;


    // Update is called once per frame
    void Update()
    {
        Text.SetText(Score.ToString());
    }
}
