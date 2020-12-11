Proje içerisinde manuel olarak eklenmiş dataların tablo yapısı aşağıdaki gibidir.


<b>tbPersonnel</b>

| PersonnelId   | IDNumber      |PersonnelTypeId| Name          | SurName       | DaysWorked    |OvertimeWorkedHours     |
| ------------- | ------------- | ------------- | ------------- | ------------- | ------------- | -------------          |
| 1             | 123456        | 1             | Name1         | Surname1      | 22            | 0                      |
| 2             | 234567        | 2             | Name2         | Surname2      | 20            | 0                      |
| 3             | 345678        | 3             | Name3         | Surname3      | 22            | 10                     |
| 4             | 456789        | 4             | Name4         | Surname4      | 22            | 10                     |

<b>tbSalaryType</b>

| SalaryTypeId  |SalaryTypeText             |SalaryTypeValue|
| ------------- | -------------             | ------------- |
| 1             | Sabit Aylık Maaş          | 500           |
| 2             | Günlük Ücret              | 20            |
| 3             | Mesai Saati Ücreti        | 5             |


Personellerin sahip olduğu TC Kimlik numarası sadece kendilerine ait olan uniq bir değerdir. TC Kimlik Numarası üzerinden gerçekleştireceğimiz sorgular ile personel ile ilgili gerekli bilgilere ulaşabiliriz. API Servisi ile ilgili detaylı bilgi aşağıdaki gibidir.

<b>URL   :</b> /api/personnel/getpersonnelinformation 

<b>Method:</b> GET 

<b>URI Parameters</b>

| Name                 |Type           | Additional information |
| -------------        | ------------- | -------------          |
| identificationNumber | integer       | Required               |
