using TMPro;
using UnityEngine;

public class TestDevMessage : MonoBehaviour
{
    public Associate associate;

    private TextMeshProUGUI ugui;

    private void Awake() {
        ugui = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        ugui.text = associate.LogMessage;
    }
}
