//Scusate ma volevo provarlo ...

using UnityEngine;

public class CambioMaterial : MonoBehaviour
{
    public Material[] material = new Material[9];

    void Start()
    {
        //Cerco tutti gli oggetti con un componente MeshRenderer attivi nella scena
        MeshRenderer[] meshRenderers = FindObjectsOfType<MeshRenderer>();

        //Per ogni elemento cambio il material con uno randomico di un array
        foreach (MeshRenderer meshRenderer in meshRenderers)
        {
            meshRenderer.material = material[Random.Range(0, material.Length)];
        }
    }
}
