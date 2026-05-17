using UnityEngine;

public class PainelInterativo : MonoBehaviour
{
    [Tooltip("Arraste o OBJETO TELÃO da Hierarchy para cá")]
    public MeshRenderer renderizadorDoTelao;

    [Tooltip("Escolha a cor do telão ligado (Ex: Branco ou Azul Claro)")]
    public Color corLigado = Color.white;

    [Tooltip("Escolha a cor do telão desligado (Ex: Preto)")]
    public Color corDesligado = Color.black;

    void Start()
    {
        if (renderizadorDoTelao != null)
        {
            renderizadorDoTelao.material.color = corDesligado;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && renderizadorDoTelao != null)
        {
            renderizadorDoTelao.material.color = corLigado; // Acende a tela
            Debug.Log("Interação: O membro se aproximou. Telão ACENDEU.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && renderizadorDoTelao != null)
        {
            renderizadorDoTelao.material.color = corDesligado; // Apaga a tela
            Debug.Log("Interação: O membro se afastou. Telão APAGOU.");
        }
    }
}