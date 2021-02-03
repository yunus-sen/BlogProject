# BlogProject
Blog project with onion architecture in .net core
katmanlı mimaride  .net core web projesidir.
projede code first yaklaşımı ile oluşturulmuş olup kendi localinizde calışması icin :
- data katmanı ->Concreate->EntityFramword->Context icinde BlogProjectContex de  connection string de servera kendini local cihaz server adresinizi vermelisiniz.
- db yi oluşturmak icin :

context clasımın bulundugu katmanda Powershell ac


dotnet tool install --global dotnet-ef komutunu calıştır ve .net core  makina na kur

kurulu ise dotnet ef  yazdıgunda başarılı bir kurulum yaptıgına dair geri dönüş alırsın.
ardından aşagıdaki komutları sırası ile yaz

****************************
****************************
Yeni bir Migration eklemek için:
dotnet ef migrations add InitialCreate
****************************
****************************
Tüm konfigürasyon ve ayarlar ile veritabanımızı oluşturmak için:
dotnet ef database update
****************************
