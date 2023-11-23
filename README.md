# Алгоритм программы

## Условие:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
### 1. Запуск программы
Происходит путем вызова метода `PromptArr()`.

### 2. Ввод данных
* Метод `PromptArr()` принимает на вход целочисленное значение длины массива. Если введено некорректное значение, выбрасывает исключение:

```
Console.WriteLine($"Processing failed: {e.Message}");
Console.WriteLine("(Вы ввели в поле значения длины массива неверное значение!)");
```

* Если значение длины массива правильное, метод церез цикл заполняет массив значениями, предлагая каждый раз ввести новое значение пользователю с клавиатуры, пока массив не будет заполнен.

* После заполнения массива `arr` внутри этого метода идет вызов другого метода: 
`ShowArrResult(arr)`
где передаваемый в параметрах `arr` - это массив, заполненный данными пользователя.

### 3. Обработка данных
* Метод `ShowArrResult(string[] arr)`, ответственный за вывод данных, в начале выполнения обращается к основному методу вычисления, передавая массив `arr`, обратно получая уже отсортированный массив: 

`string[] newArr = GetArrResult(arr);`

* Метод `GetArrResult(arr)`, ответственный за вычисления, получает на вход массив `arr`. 
* Далее создает новый массив `newArr`.
* Массив `arr` перебирается через цикл `foreach`, элементы, длина которых меньше, либо равна 3 символам, последовательно добавляются в `newArr`.
* Массив `newArr` изначально имеет нулевую длину, перед добавление каждого нового найденного элемента из `arr` длину `newArr` увеличиваем на 1 через встроенный метод `Array.Resize()`.
* После завершения цикла метод `GetArrResult(arr)` возвращает массив `newArr`.

### 4. Вывод данных
* Метод `ShowArrResult(string[] arr)`, получив из метода `GetArrResult(arr)` массив `newArr`, через цикл `for` выодит вначале пользовательский массив `arr`.
* Далее через цикл `for` выводит результирующий массив `newArr`.
* Получается запись вида:
```
[Hello, 2, world, :-)] → [2, :-)]
[1234, 1567, -2, computer science] → [-2]
[Russia, Denmark, Kazan] → []
```