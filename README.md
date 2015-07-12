#Четвёртое задание

Определить является ли введенная пользователем строка палиндромом.
Палиндром — число (например, 404), буквосочетание, слово (например, топот)
или текст (а роза упала на лапу Азора), одинаково читающееся в обоих
направлениях. 

#Ход решения
Априори методом Regex.Replace во введённой записи были убраны абсолютно все пробелы, затем был создан массив символов
типа char, чтобы считать введённую строку по одному символу. Метотом ToCharArray текст конвертируется из строкового формата в символьный.
Теперь методом Array.Reverse переворачиваем символы в обратном порядке. Переводим символьный массив в строку и сравниваем её с первоначальной.

#Консольное окно
![](https://pp.vk.me/c622831/v622831465/3d5d4/ZJfz1I4z_j0.jpg " ")
![](https://pp.vk.me/c622831/v622831465/3d5dc/tHJ65kEwYzk.jpg " ")
![](https://pp.vk.me/c622831/v622831465/3d5e4/SEcjFjtn_B4.jpg " ")
![](https://pp.vk.me/c622831/v622831465/3d5ec/8l5HMp4u_n8.jpg " ")