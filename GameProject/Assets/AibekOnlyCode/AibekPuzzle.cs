using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class AibekPuzzle : MonoBehaviour 
{ 
    public GameObject[] levers; // Массив ссылок на все рычаги 
    public Entryopen entryOpener; // Ссылка на класс Entryopen 
 
    private int activatedLeversCount = 0; // Количество активированных рычагов 
    private int expectedLeverIndex = 0; // Ожидаемый индекс текущего рычага 
    private bool puzzleSolved = false; // Флаг решения головоломки 
 
    // Вызывается при активации рычага 
    public void LeverActivated(GameObject lever) 
    { 
        // Проверяем, является ли активированный рычаг ожидаемым рычагом 
        if (IsCorrectLever(lever, expectedLeverIndex)) 
        { 
            activatedLeversCount++; 
            expectedLeverIndex++; 
 
            // Проверяем условия для открытия двери 
            if (activatedLeversCount == 2 && !puzzleSolved) 
            { 
                OpenDoorIfPuzzleSolved(); // Попытка открытия двери, если головоломка решена 
            } 
        } 
        else 
        { 
            ResetPuzzle(); // Сброс головоломки, если последовательность нарушена 
        } 
    } 
 
    // Проверяет, является ли рычаг правильным и имеет ли ожидаемый индекс 
    private bool IsCorrectLever(GameObject lever, int leverIndex) 
    { 
        if (leverIndex < levers.Length) 
        { 
            return lever == levers[leverIndex]; 
        } 
        return false; 
    } 
 
    // Попытка открытия двери, если головоломка решена 
    private void OpenDoorIfPuzzleSolved() 
    { 
        if (!puzzleSolved && expectedLeverIndex == 2) 
        { 
            entryOpener.Open(); // Вызываем метод Open() для открытия двери 
            puzzleSolved = true; // Устанавливаем флаг решения головоломки 
        } 
    } 
 
    // Сброс головоломки 
    private void ResetPuzzle() 
    { 
        activatedLeversCount = 0; 
        expectedLeverIndex = 0; 
    } 
}