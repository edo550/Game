using UnityEngine;
using TMPro;

public class DialogueUI_1 : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;

    // Start is called before the first frame update
    private void Start()
    {
        FindObjectOfType<audioManager>().TypeWriter();
        GetComponent<TypewriterEffect>().Run("Fiu', per un pelo.\n" +
            "Adesso che siamo riusciti ad andare via da quel mondo di sola acqua ci aspetta il prossimo pianeta. " +
            "Questo e' il secondo dei tre pianeti da esplorare, i dati non promettono bene. " +
            "A quanto pare le temperature sembrano davvero troppo elevate e quindi non adatte alla vita umana.\n" +
            "Vedremo...", textLabel);
    }


}
