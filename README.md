# Создание прирложения при помощи системы контроля версий

В процессе данной лабораторной работы создано приложение, выполняющее ряд функций.
Проект создавался несколькими людьми одновременно так как целью работы являлось изучение предназначения и различные способы организаций систем контроля версий.

Первым шагом стало создание локального репозитория при помощи команды
```
git init
```
В результате добавления в проект нужных файлов и их редактирования создана форма приложения с элементом TabControl, во вкладках которого каждый из участников в дальнейшем сделал свою часть работы.
Затем добавлен первый коммит
```
git commit -m "Start"
```
И сделан "пуш" в предварительно созданный пустой удаленный репозиторий.
```
git push origin main
```
Далее каждый из участников самостоятельно начал работать в самостоятельно созданной ветке.
```
git branch
```

## Данные о пробежках

![image](https://github.com/underratedpoet/GitTest/assets/103249547/1e3d315b-e009-465d-b3d0-92508b35749d)

По заданию, пользователь открывает файл с данными о пробежках за каждый день в течение
месяца (длительность бега в минутах, пройденное расстояние в км, максимальная скорость,
минимальная скорость, средняя скорость, средний пульс). Вывести эту информацию на экран
в удобном формате. По двум любым параметрам построить графики. Вычислить сумму
пройденных км за все выходные дни.
