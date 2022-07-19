using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;

    // Start is called before the first frame update
    private void Start()
    {
        FindObjectOfType<audioManager>().TypeWriter();
        GetComponent<TypewriterEffect>().Run("Nemmeno questo pianeta era adatto. " +
            "Siamo arrivati all'ultimo, se questo andasse male la missione sarebbe un totale fallimento.\n" +
            "Questo pianeta e' simile alla Terra, aria respirabile e acqua in grande quantita'. " +    
            "A questo punto riponiamo tutta le spetanze su questo pianeta. " +
            "Se il pianeta risultasse abitabile la missione sarebbe un successo.\n" +
            "Le speranze dell'umanita' sono nelle tue mani...", textLabel);
    }


}
