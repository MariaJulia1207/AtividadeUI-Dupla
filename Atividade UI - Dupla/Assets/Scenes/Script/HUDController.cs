using TMPro;
using UnityEngine;
public class HUDController : MonoBehaviour
{
    public TextMeshProUGUI relogioTexto;
    private float tempo = 100;
    void Update()
    {
        // Atualiza tempo
        tempo -= Time.deltaTime;
        relogioTexto.text = tempo.ToString("F1"); // ex: Tempo: 10.3
    }
}