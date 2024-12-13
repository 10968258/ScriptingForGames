using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using TMPro;
using System.Globalization;
using UnityEngine.SocialPlatforms.Impl;

[RequireComponent(typeof(TextMeshProUGUI))]

public class Simpletextmeshprobehaviour : MonoBehaviour
{

    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;

    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        UpdateWithIntData();
    }

    public void UpdateWithIntData()
    {
        textObj.text = "Score: " + dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
