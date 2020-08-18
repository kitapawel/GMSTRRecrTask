using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TemporaryTextDisplay : MonoBehaviour
{
    bool countdownPending = false;
    [SerializeField]
    TextMeshProUGUI textMeshPro;

    public void OnButtonPressed()
    {
        StartCoroutine("DisplayText");
    }

    IEnumerator DisplayText()
    {
        if (!countdownPending)
        {
            countdownPending = true;
            textMeshPro.text = "This text will disappear in 3...";
            yield return new WaitForSeconds(1f);
            textMeshPro.text = "This text will disappear in 2...";
            yield return new WaitForSeconds(1f);
            textMeshPro.text = "This text will disappear in 1...";
            yield return new WaitForSeconds(1f);
            textMeshPro.text = "";
            countdownPending = false;
        }

    }

}
