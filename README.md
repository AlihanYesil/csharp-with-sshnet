# csharp-with-sshnet
c#-consoleApp with - Ssh.Net library usage

1- Öncelikle SSH.NET kütüphanesini projenize eklemelisiniz.
   Bunun için NuGet Paket Yöneticisi'ni veya projenizin dosya sistemine manuel olarak referans ekleyebilirsiniz.

2- SSH sunucusuna bağlanmak için bir SshClient örneği oluşturun.
   Bu örnek, bağlantı yapmak istediğiniz sunucunun IP adresi veya alan adı, kullanıcı adı ve şifre gibi bilgileri içerir.
   
3- SshClient örneği oluşturulduktan sonra, Connect yöntemini kullanarak sunucuya bağlanabilirsiniz.


4- Bağlandıktan sonra, sunucuda çalıştırmak istediğiniz komutları CreateCommand yöntemiyle oluşturabilirsiniz.
   Daha sonra, komutu Execute yöntemiyle çalıştırabilirsiniz.
  
5- İşlemler tamamlandıktan sonra, sunucudan çıkış yapmak için Disconnect yöntemini kullanabilirsiniz.

# Note
 CreateCommand ile oluşturulan komutlar bir değişkene atanabilir ve sonuçları bu değişkende depolanır. Sonuçları konsola yazdırmak için Console.WriteLine kullanılalabilir.

Bu işlemler SSH.NET kütüphanesini kullanarak C# dilinde gerçekleştirilmiştir. bununla birlikte,  bir sunucu üzerinde SSH ile haberleşme işlemini gerçekleştirebilirsiniz.
