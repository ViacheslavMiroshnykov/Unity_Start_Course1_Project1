using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.WriteLine("Привет! Какой терминал вы хотите взломать сегодня?");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Введите 1 - городскуя библиотека");
        Terminal.WriteLine("Введите 2 - полицейский участов");
        Terminal.WriteLine("Введите 3 - космический корабль");
        Terminal.WriteLine("Введите ваш выбор:");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
