using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Exercises
{
    internal class Exercise01
    {
        /*
         * Napisz system do obsługi "call-center". System powinien pozwalać na wykonywanie połączęń z klientami,
         * odbieranie połączeń od klientów oraz przekierowywanie połączeń. System powinien zostać napisany w sposób uniwersalny.
         * Wiemy, że telefony na których pracują pracownicy różnią się znaczącą w zależności o lokalizacji biura.
         * Zagwarantuj, że system będzie działał w każdej lokalizacji i niezależnie od rodzaju telefonu.
         */

        internal interface IPhone
        {
            void Call(string phoneNumber);

            void Answer();

            void Redirect(string phoneNumber);
        }

        internal class AndroidPhone : IPhone
        {
            private readonly int _androidVersion;

            public AndroidPhone(int androidVersion)
            {
                _androidVersion = androidVersion;
            }

            public void Answer()
            {
                Console.WriteLine("Answer AndroidPhone");
            }

            public void Call(string phoneNumber)
            {
                Console.WriteLine("Call AndroidPhone");
            }

            public void Redirect(string phoneNumber)
            {
                Console.WriteLine("Redirect AndroidPhone");
            }
        }

        internal class IPhonePhone : IPhone
        {
            private readonly bool _isFaceId;

            public IPhonePhone(bool isFaceId)
            {
                _isFaceId = isFaceId;
            }

            public void Answer()
            {
                Console.WriteLine("Answer IPhonePhone");
            }

            public void Call(string phoneNumber)
            {
                Console.WriteLine("Call IPhonePhone");
            }

            public void Redirect(string phoneNumber)
            {
                Console.WriteLine("Redirect IPhonePhone");
            }
        }

        internal class SkypePhone : IPhone
        {
            public void Answer()
            {
                Console.WriteLine("Answer SkypePhone");
            }

            public void Call(string phoneNumber)
            {
                Console.WriteLine("Call SkypePhone");
            }

            public void Redirect(string phoneNumber)
            {
                Console.WriteLine("Redirect SkypePhone");
            }
        }

        internal class CallService 
        {
            private readonly IPhone _phone;

            public CallService(IPhone phone)
            {
                _phone = phone;
            }

            public void GenerateKpi()
            {
                _phone.Call("123123123");
            }

            public void AnswerClients()
            {
                _phone.Answer();
            }

            public void RedirectCallsToBoss()
            {
                _phone.Redirect("0700BOSS");
            }
        }

        internal interface IPhoneCreator
        {
            IPhone Create();

            bool ShouldBeUsed(string cityName);
        }

        internal class AndroidCreator : IPhoneCreator
        {
            public IPhone Create()
            {
                return new AndroidPhone(2);
            }

            public bool ShouldBeUsed(string cityName)
            {
                return cityName == "Gdansk";
            }
        }

        internal class IPhonePhoneCreator : IPhoneCreator
        {
            public IPhone Create()
            {
                return new IPhonePhone(true);
            }

            public bool ShouldBeUsed(string cityName)
            {
                return cityName == "Poznan";
            }
        }

        internal class SkypeCreator : IPhoneCreator
        {
            public IPhone Create()
            {
                return new SkypePhone();
            }

            public bool ShouldBeUsed(string cityName)
            {
                return cityName == "Warszawa";
            }
        }

        internal class Client
        {
            private readonly IEnumerable<IPhoneCreator> phoneCreators;

            public Client(IEnumerable<IPhoneCreator> phoneCreators)
            {
                this.phoneCreators = phoneCreators;
            }

            public void Main()
            {
                IPhone phone;

                var creator = GetPhoneCreator();
                
                phone = creator.Create();

                var callService = new CallService(phone);
            }

            private IPhoneCreator GetPhoneCreator()
            {
                string city = Console.ReadLine();

                return phoneCreators.FirstOrDefault(p => p.ShouldBeUsed(city)) ?? new SkypeCreator();
            }
        }
    }
}
