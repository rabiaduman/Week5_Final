
using Car_Plant;

List<Car> carList = new List<Car>(); //Arabalar için liste oluşturuldu

while (true)
{
    q1:  Console.Write("Araba üretmek istiyor musunuz? (e/h)"); //Bu soruya geçersiz bir yanıt verilirse kod akışı tekrar bu satıra (q1) gelecek
    char answer1 = Convert.ToChar(Console.ReadLine().ToLower());

    if (answer1 == 'e')
    {
        q3: //Kullanıcı başka araba üretmek istiyorsa tekrar tekrar bu satıra gelebilmek için (q3)
        Console.Write("Arabanın markası: ");
        string carBrand = Console.ReadLine();
        Console.Write("Arabanın modeli: ");
        string carModel = Console.ReadLine();
        Console.Write("Arabanın rengi: ");
        string carColor = Console.ReadLine();
        Console.Write("Arabanın şasi numarası: ");
        string vin = Console.ReadLine();
        int carDoor;

        q2: //Kullanıcı kapı sayısını yanlış formatta girerse tekrar soruyu sorabilmek için(q2)
        try
        {
            Console.Write("Arabanın kapı sayısı: ");
            carDoor = Convert.ToInt32(Console.ReadLine()); //Hatalı giriş yapma olasılığı olan kod satırı
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Geçersiz giriş yaptınız!"); // Hata durumunda gösterilen mesaj
            goto q2;
        }

        Car newCar = new Car() //nesne oluşturuluyor
        {
            CarBrand = carBrand,
            CarModel = carModel,
            CarColor = carColor,
            VIN = vin,
            CarDoor = carDoor
        };
        
        carList.Add(newCar); // Listeye ekleniyor

        Console.WriteLine("Başka araba üretmek istiyor musunuz? (e/h)");
        char answer2 = Convert.ToChar(Console.ReadLine().ToLower());

        if (answer2 == 'e')
            goto q3;
        else if (answer2 == 'h')
        {
            foreach (var car in carList) //Listedeki tüm araçlar yazdırılıyor
            {
                Console.WriteLine("---- ARABALAR ----");
                Console.WriteLine("Marka: " + car.CarBrand + "      Şasi No: " + car.VIN);
            }
            break;

        }


    }
    else if (answer1 == 'h')
        break;
    else
    {
        Console.WriteLine("Geçersiz yanıt!");
        goto q1;
    }

        
   
}
