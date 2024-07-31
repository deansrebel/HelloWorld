using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    // private int _max = 10000; // public не приветсвуется, но так можно изменять числа в Юнити
   // private int _min = 500;

    [SerializeField] private int _max = 1000; // остаются приватными, но можно в юнити все ранво менять
    [SerializeField] private int _min = 500;

    private int _guess;

    private void Start()
    {
        Debug.Log($"Привет! Я Magic Numbers. Загадай число от {_min} до {_max}");
       
        CalculateGuessAndLog();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            //Debug.Log($"[{Time.frameCount}] GetKeyDown DownArrow");
            
            _max = _guess;
            CalculateGuessAndLog();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log($"[{Time.frameCount}] GetKeyDown UpArrow");

            _min = _guess;
            CalculateGuessAndLog();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Ура! Твое число отгадано и равно {_guess}!");
        }
    }
    private void CalculateGuessAndLog()
    {
        // подсчитываю новый guess и вывожу log в консоль
        _guess = (_max + _min) / 2;
        Debug.Log($"Твое число равно: {_guess}?");
    }
}

// bool isPressed = Input.GetKeyDown(KeyCode.DownArrow); // кнопка нажата. когда надо что-то сделать по нажатию
// bool isPressed = Input.GetKeyUp(KeyCode.DownArrow); // кнопку отпустили. нужен сам момент отпусскания
// //bool isPressed = Input.GetKey(KeyCode.DownArrow); // держим кнопку
        