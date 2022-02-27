using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingAndChoesionApp
{
    public class GetterSetterElevatorTest
    {
        private static GetterSetterElevator getGetterSetterElevator = new GetterSetterElevator();

        public static void Main(string[] args)
        {
            // Peki getter setter ekleyince ne değişti? Semantice göre iyilişme var mı?
            // Tabi ki yok.Burada da bilginin anlamını yine clientin bilmesi gerekiyor. Get sette de o bilgi aktarımı alımı devam ediyor.
            // Kapıyı açık tutarak yine bir yere gidebiliriz.
            // 1-Set getler bizi sadece sintaktik ve tipsel değişimlerden korunmuş olduk.
            // 2-Sınırlarla ilgili olmadık değerler geçmenin getirdiği sıkıntılardan korurlar.
            // Yani ağırlığa float değer atamama gibi koruma sağlayabiliriz.
            // tip, isim değişimlerini becerebilirim
            // max min değerler ile koruma sağlayabilirim.
            // Ama semantic sıkıntıda yardımcı olmazlar.
            getGetterSetterElevator.DoorOpen = true;
            getGetterSetterElevator.DoorOpen = false;

            getGetterSetterElevator.CurrentFloor = getGetterSetterElevator.CurrentFloor + 1;

            getGetterSetterElevator.CurrentFloor = 7;
            getGetterSetterElevator.DoorOpen = true;
            getGetterSetterElevator.DoorOpen = false;
            getGetterSetterElevator.CurrentFloor = 1;
            getGetterSetterElevator.DoorOpen = true;

            getGetterSetterElevator.CurrentFloor = getGetterSetterElevator.CurrentFloor + 1;
        }
    }
}
