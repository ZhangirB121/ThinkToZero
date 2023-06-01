using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Plates;

public class FivePlates : MonoBehaviour
{
    private WallOpen wallOpen;
    public int[] solution = { 1, 2, 3, 4, 5 };

    [SerializeField] private bool openTrigger = false;

    private static int[] input = new int[5];
    private int currentPlateIndex = 0;

    public PlateData[] plates; // Массив ссылок на плиты

    private void Start()
    {
        wallOpen = GetComponentInChildren<WallOpen>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlateData plateData = other.GetComponent<PlateData>();
        if (plateData != null && openTrigger)
        {
            int digit = plateData.GetDigit();
            plateData.PressPlate();

            input[currentPlateIndex] = digit; // Сохраняем значение digit в соответствующем индексе массива input
            Debug.Log("Нажата плита " + digit);
            Debug.Log("Массив input: " + string.Join(", ", input)); // Вывод всего массива input

            if (currentPlateIndex < input.Length - 1)
            {
                currentPlateIndex++;
            }
            else
            {
                if (CheckSolution())
                {
                    OpenWall();
                }
                else
                {
                    ResetSequence();
                }
            }
        }
    }

    private bool CheckSolution()
    {
        for (int i = 0; i < solution.Length; i++)
        {
            if (solution[i] != input[i])
            {
                return false;
            }
        }

        return true;
    }

    private void ResetSequence()
    {
        Debug.Log("Wrong plate! Resetting sequence.");

        ResetInput();
    }

    private void ResetInput()
    {
        for (int i = 0; i < input.Length; i++)
        {
            plates[i].DisablePlate(); // Вызываем метод DisablePlate для каждой плиты
            input[i] = 0;
        }
        currentPlateIndex = 0;
    }

    private void OpenWall()
    {
        Debug.Log("Correct");
        wallOpen.OpenWall();
    }
}
