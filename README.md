# CheerfulWaterCarrier
Приложения для работы с заказами
## Web приложение для просмотра, ввода и редактирования следующих сущностей:

Сотрудники:
* Фамилия : string
* Имя : string
*  Отчество : string
*  Дата рождения : datetime
*  Пол : enum
*  Подразделение :  Ссылка на подразделение

Подразделения:
* Название : string
* Руководитель : Ссылка на сотрудника

Заказы:
* Номер : int
* Название товара : string
* Сотрудник : Ссылка на сотрудника
	
*Для одного заказа возможно указать несколько тегов, также один тег может быть указан у множества заказов.