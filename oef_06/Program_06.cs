using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_06
{
    class Program_06
    {
        static void Main(string[] args)
        {

            BankAccount[] bAccount = new BankAccount[10];

            //============================================================================================init all accounts
            for (int i = 0; i < bAccount.Length; i++)
            {
                bAccount[i] = new BankAccount();
                bAccount[i].Name = $"Joske_{i}";
                bAccount[i].BankAccountNumber = $"{i}{i}{i}-{i}{i}{i}{i}-{i}{i}{i}";
                bAccount[i].PayInFunds(i * 100);
            }


            //-------------------------------------------------------- tonen van alle accounts
            Console.WriteLine("de initiale waarde van alle accounts:");
            foreach (var item in bAccount)
                Console.WriteLine(item);
            Console.WriteLine("-------------------------------------------------\n");


            //===================================================================================== enkele stortingen doen

            bAccount[2].PayInFunds(10000);
            bAccount[4].PayInFunds(20000);


            //-------------------------------------------------------- tonen van alle accounts
            Console.WriteLine("de  waardes van alle accounts na enkele stortingen:");
            foreach (var item in bAccount)
                Console.WriteLine(item);
            Console.WriteLine("-------------------------------------------------\n");


            //=======================================================================================enkele afhalingen doen
            int aftehalenBedrag = 10;
            int effectiefAfgehaald = bAccount[7].WithDrawFunds(aftehalenBedrag);
            if(effectiefAfgehaald == -1)
                Console.WriteLine($"rekening is geblokkeerd");
            else if ( effectiefAfgehaald != aftehalenBedrag)
                Console.WriteLine($"saldo ontoereikend, er is maar {effectiefAfgehaald} van je rekening gegaan");

            aftehalenBedrag = 50;
            effectiefAfgehaald = bAccount[8].WithDrawFunds(aftehalenBedrag);
            if (effectiefAfgehaald == -1)
                Console.WriteLine($"rekening is geblokkeerd");
            else if (effectiefAfgehaald != aftehalenBedrag)
                Console.WriteLine($"saldo ontoereikend, er is maar {effectiefAfgehaald} van je rekening gegaan");

            aftehalenBedrag = 1000;
            effectiefAfgehaald = bAccount[9].WithDrawFunds(aftehalenBedrag);
            if (effectiefAfgehaald == -1)
                Console.WriteLine($"rekening is geblokkeerd");
            else if (effectiefAfgehaald != aftehalenBedrag)
                Console.WriteLine($"saldo ontoereikend, er is maar {effectiefAfgehaald} van je rekening gegaan");


            //-------------------------------------------------------- tonen van alle accounts
            Console.WriteLine("de  waardes van alle accounts na enkele afhalingen:");
            foreach (var item in bAccount)
                Console.WriteLine(item);
            Console.WriteLine("-------------------------------------------------\n");



            //===============================================================================een storting tss accounts doen

            //joske_4 stort 2000 naar joske_3
            Console.WriteLine("voor de storting");
            Console.WriteLine(bAccount[3]);
            Console.WriteLine(bAccount[4]);
            bAccount[3].PayInFunds(bAccount[4].WithDrawFunds(2000));
            Console.WriteLine("na de storting");
            Console.WriteLine(bAccount[3]);
            Console.WriteLine(bAccount[4]);


            Console.WriteLine("-------------------------------------------------\n");



            //==================================================================================enkele rekeningen blokkeren

            bAccount[0].ChangeState(BankAccountState.Blocked);
            bAccount[1].ChangeState(BankAccountState.Blocked);
            bAccount[2].ChangeState(BankAccountState.Blocked);
            bAccount[3].ChangeState(BankAccountState.Blocked);
            bAccount[4].ChangeState(BankAccountState.Blocked);

            //-------------------------------------------------------- tonen van alle accounts
            Console.WriteLine("enkele rekeningen geblokkeerd:");
            foreach (var item in bAccount)
                Console.WriteLine(item);
            Console.WriteLine("-------------------------------------------------\n");


            //=========================================================== overschrijving proberen doen van geblokte rek
            int bedragOvergezet = bAccount[2].PayInFunds(10000);
            if (bedragOvergezet == -1)
                Console.WriteLine("!!!!!!!!!!!!!!!!!! rekening geblokkeerd !!!!!!!!!!!!!!!!!!!!");

            Console.WriteLine(bAccount[2]);


           
            ////-------------------------------------------------------- tonen van alle accounts
            //Console.WriteLine("enkele rekeningen geblokkeerd:");
            //foreach (var item in bAccount)
            //    Console.WriteLine(item);
            //Console.WriteLine("-------------------------------------------------\n");




            Console.ReadKey();
        }
    }
}
