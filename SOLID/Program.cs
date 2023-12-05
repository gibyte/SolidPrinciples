﻿/*
На примере реализации игры «Угадай число» продемонстрировать практическое применение SOLID принципов.
Программа рандомно генерирует число, пользователь должен угадать это число.
При каждом вводе числа программа пишет больше или меньше отгадываемого.
Кол-во попыток отгадывания и диапазон чисел должен задаваться из настроек.
В отчёте написать, что именно сделано по каждому принципу.
 */

using SOLID;

class Solid
{
    static void Main(string[] args)
    {
        IEnumerable<Game> games = new List<Game>()
        {
            new GameRandomValue()
        };
        GameManager gameManager = new GameManager(games);
        gameManager.PlayGames();

    }
}