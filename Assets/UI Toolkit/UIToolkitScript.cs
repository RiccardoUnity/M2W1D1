//Scusate ma volevo provarlo ...

using UnityEngine;
using UnityEngine.UIElements;

public class UIToolkitScript : MonoBehaviour
{
    private UIDocument document;
    private VisualElement root;
    private Button spawn;

    public GameObject protagonista;
    public Transform origin;

    void Start()
    {
        //Associo il componente
        document = GetComponent<UIDocument>();
        //Estraggo il visual element che contiene tutto il documento
        root = document.rootVisualElement;
        //Cerco nel visual element il primo pulsante con nome Spawn
        spawn = root.Q<Button>("Spawn");
        //Associo un'azione al pulsante
        spawn.clicked += SpawnNuovaSfera;
    }

    private void SpawnNuovaSfera()
    {
        //Spawno l'oggetto nella trasformazione di origin
        Instantiate(protagonista, origin.position, origin.rotation);
        Debug.Log("La sfera è stata spawnata");
    }
}
