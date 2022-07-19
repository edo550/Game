using UnityEngine;
using TMPro;

public class DialogueUI_2 : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;

    // Start is called before the first frame update
    private void Start()
    {
        FindObjectOfType<audioManager>().TypeWriter();
        GetComponent<TypewriterEffect>().Run("L'astronauta e' missione con l'obiettivo di esplorare nuovi pianeti alla ricerca di pianeti abitabili per consentire la sopravvivenza dell'umanita'.\n" +
           "Adesso, secondo i dati ci troviamo nel pianeta di classe M denominato Edmund. " +
           "L'esploratore e' rimasto bloccato in questo pianeta, a causa di una perdita di carburante, " +
           "devi aiutarlo a farlo ritornare in orbita il prima possibile. \n" +
           "Ricordarti di raccogliere il carburante.", textLabel);
    }
}

