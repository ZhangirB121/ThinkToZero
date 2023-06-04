using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using RPG.Control; 
 
public class leverOnlyAibek : MonoBehaviour, IRaycastable 
{ 
    bool virado = false; 
    bool podeVirar = true; 
 
    public GameObject zhangirLoh; 
    public Material KukaOn; 
    public Material KukaOff; 
 
    public AibekPuzzle aibekPuzzle; // Ссылка на класс AibekPuzzle 
 
    public CursorType GetCursorType() 
    { 
        return CursorType.Lever; 
    } 
 
    public bool HandleRaycast(PlayerController callingController) 
    { 
        return true; 
    } 
 
    IEnumerator mudar() 
    { 
        yield return new WaitForSeconds(0.875f); 
        podeVirar = true; 
        virado = !virado; 
 
        if (virado) 
        { 
            zhangirLoh.GetComponent<Renderer>().material = KukaOn; 
            aibekPuzzle.LeverActivated(gameObject); // Сообщаем об активации рычага в AibekPuzzle 
        } 
        else 
        { 
            zhangirLoh.GetComponent<Renderer>().material = KukaOff; 
            // No need to call LeverDeactivated here 
        } 
    } 
 
    private void OnMouseDown() 
    { 
        if (podeVirar) 
        { 
            podeVirar = false; 
            if (!virado) 
            { 
                GetComponent<Animation>().Play("Cube.001| Subir"); 
                StartCoroutine(mudar()); 
            } 
            else 
            { 
                GetComponent<Animation>().Play("Cube.001|Descer"); 
                StartCoroutine(mudar()); 
            } 
        } 
    } 
}