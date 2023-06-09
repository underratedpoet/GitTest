# Создание приложения при помощи системы контроля версий

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
После окончания работы над собственной частью проекта происходило слияние веток. Слияние проходило несколько раз как с fast-forward, так и без.
```
git merge <branchname> --ff
git merge <branchname> --no-ff
```
## Данные о пробежках

![image](https://github.com/underratedpoet/GitTest/assets/103249547/a20f1e40-a2d2-4a30-98ef-55591e5088aa)

По заданию, пользователь открывает файл с данными о пробежках за каждый день в течение
месяца (длительность бега в минутах, пройденное расстояние в км, максимальная скорость,
минимальная скорость, средняя скорость, средний пульс). Вывести эту информацию нужно на экран
в удобном формате, по двум любым параметрам построить графики, вычислить сумму
пройденных км за все выходные дни.

Создан класс Workout, содержащий информацию об одной пробежке: средний пульс, пройденное расстояние, скорость и тд. Этот класс также хранит данные о дне недели, в которое проводилось занятие. При помощи сериализации создан json-файл с информацией о группе экземпляров этого класса, сами экземпляры расположены в файле по возрастанию даты.
Создан класс WorkoutFacade, являющийся подобием фасада для класса Workout. Он загружает и хранит список экземпляров Workout, имеет функции для поиска конкретного экземпляра, а также вычисляет и хранит значения, основанные на данных по всем занятиям, например общее количество пройденных километров, средний пульс по всем занятиям и тп.

![image](https://github.com/underratedpoet/GitTest/assets/103249547/9f5b187f-bb10-4f7e-b2ba-c61a3de27ead)

Для отображения данных на форме создан ряд элементов управления типа TextBox, две кнопки и два элемента PictureBox. По нажатию на одну из кнопок в текстовые поля вписываются вычисленные WorkoutFacade данные, а в элементах PictureBox при помощи класса Graphics создан график по параметрам: средний пульс и продолжительность занятия.
Вторая кнопка позволяет получить данные по каждому из занятий, если есть данные для отображения. При нажатии на нее открывается форма, где можно выбрать конкретную дату и получить по ней информацию.

## Температура
![image](https://github.com/underratedpoet/GitTest/assets/132668342/a7a40cc4-7335-4494-aea4-1583b0213215)

По заданию, пользователь открывает файл с данными о температуре в городе за каждый день в
течение месяца (максимальная за день, минимальная за день, средняя за день). Вывести эту
информацию на экран в удобном формате. Также по этим данным построить графики.
Минимальную температуру окрасить в синий цвет, максимальную в красный. Вычислить в
какой день перепад температуры был самый сильный.

Был создан класс Temp, содержащий данные о дате и температурах: максимальной, минимальной и средней. В нем также содержатся методы чтения из файла данных, рисования графика по этим данным, взаимодействия с интерфейсом (заполнение textBox) и поиска максимального падения температуры

![image](https://github.com/underratedpoet/GitTest/assets/132668342/5320b78f-97d9-4e80-8c3f-2d1fa27c2b13)

## Жилье
## Преступность
