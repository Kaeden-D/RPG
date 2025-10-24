using NUnit;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeaderInfo : MonoBehaviourPun
{

    [SerializeField]
    public TextMeshProUGUI nameText;
    public Image bar;
    private float maxValue;

    public void Initialize(string text, int maxVal)
    {

        nameText.text = text;
        maxValue = maxVal;
        bar.fillAmount = 1.0f;

    }

    [PunRPC]
    void UpdateHealthBar(int value)
    {

        bar.fillAmount = (float)value / maxValue;

    }

}
