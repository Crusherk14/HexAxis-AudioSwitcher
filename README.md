# [HexAxis] AudioSwitcher
##Краткое описание
![alt tag](http://s017.radikal.ru/i439/1512/53/0b97db9fed47.png)
HexAxis AudioSwitcher делает переключение между различными звуковыми каналами быстрым и интуитивно понятным.
Данный проект включает в себя программное обеспечение, позволяющее пользователю взаимодействовать с устройством, а также программу для микроконтроллера Arduino, отвечающего за переключение аудио-каналов.

##Пользовательский интерфейс
![alt tag](http://i056.radikal.ru/1512/fd/60bd228f9390.png)
Пользовательский интерфейс HexAxis AudioSwitcher может быть запущен на практически любом стационарном компьютере, использующим операционную систему Windows (XP/Vista/7/8/8.1/10). Его основной задачей является взаимодействие с пользователем, а также поддержание стабильного подключения с устройством посредством его поиска, периодической синхронизации и восстановления потерянного подключения. Уникальной особенностью данного продукта является интеллектуальное переключение между подключенными устройствами ввода и вывода звукового сигнала, позволяющее с лёгкостью переключаться между различными профилями звука всего несколькими нажатиями. Благодаря системе экстренного восстановления, система будет продолжать свою работу даже после потери соединения с пользовательским интерфейсом, используя заданный по умолчанию профиль.

Программное обеспечение, находящееся в директории "/User Interface" написано на языке программирования C# в среде разработки Microsoft Visual Studio Community 2015 (соответствующий файл проекта .sln располагается в директории "/Project/Software/PC").

##Arduino
![alt tag](http://s017.radikal.ru/i405/1512/0d/0435e5d3b688.jpg)
Программное обеспечение для микроконтроллера обеспечивает не только слаженную работу с пользовательским интерфейсом, но и автономную работу в режиме ожидания. В качестве основного рабочего микроконтроллера был выбран Arduino Nano с чипом ATmega328, подключающимся посредством USB-интерфейса. Переключение между звуковыми каналами обеспечивают маломощные низковольтные реле AXICOM-V23079, срабатывающие от 5V, что позволило подключить их напрямую к ножкам микропроцессора.
![alt tag](http://s018.radikal.ru/i512/1512/8f/f9d009fd8ef8.png)

Аппаратная часть регулярно посылает синхранизационные команды пользовательскому интерфейсу посредством Serial-подключения. В случае отсутствия ответа на запрос, устройство перейдёт в режим ожидания, по истичении которого будет произведено переключение на профиль по умолчанию.

Код для микропроцессора написан на языке программирования Wiring в среде разработки Arduino IDE (соответствующий файл проекта .ino располагается в директории "/Project/Software/Arduino").
