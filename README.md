 # Итоговая контрольная работа по основному блоку

## Задача

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание алгоритма

Программа, которая будет формировать массив из строк, длина которых меньше, либо равна 3 символам, должна быть написана отдельной функцией.

Данная функция имеет название *CreateNewArray*. Она будет принимает на вход два массива, один - наш исходный массив, второй - уже преобразованный. Возвращает данная функция ничего не будет

Вводим переменную *count* для сохранения необходимых по условию значений в новый массив. Далее циклом *for* просматриваем весь массив и в случае если наше условие верно, то найденное значение записыается в новый массив и так до тех пор пока массив не закончится.

На печать массив выводится с помощью функции *PrintArray*.

Далее проверяем верно ли отрабатывает наша программа, вводим некий массив с различнвыми строчными значениями, а также новый массив, в который будут попадать нужные нам данные.