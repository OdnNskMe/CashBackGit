using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBackBaseLibrary
{
    class ModelDB
    {
        public class Client
        {
            public int ClientId { get; set; }
            public string ClientFIO { get; set; }
            public DateTime ClientDateBorn { get; set; }            
            public bool ClientGender { get; set; }
            public bool ClientRetired { get; set; } //Статус пенсии
            public string ClientBorn { get; set; }
            public Address ClientAddress { get; set; }
            public List<DebtInform> ClientDebtInform { get; set; }

        }
        public class Address
        {
            public int AddressId { get; set; }
            public int Index { get; set; }
            public string Region { get; set; }//область
            public string District { get; set; }//район
            public string Settlement { get; set; }//поселение деревня, село, город
            public string SettlementName { get; set; } //название населенного пункта
            public string AttributeStreet { get; set; }//бульвар, проспект, переулок, улица
            public string StreetName { get; set; }//название улиц/бульвар
            public int NumberHouse { get; set; }
            public int SecondNumberHouse { get; set; }
            public int NumberApartment { get; set; }
        }
        public class DebtInform
        {
            public int DebtId { get; set; }
            public string NumberContract { get; set; }
            public string NameCreditor { get; set; }
            public decimal SummDebtGiven { get; set; } //выданного
            public decimal SummDebtRemainder { get; set; } //основного долга
            public decimal SummPercent { get; set; } //процентов
            public decimal SummDebtAll { get; set; }//иска
            public int PercentCredit { get; set; }
            public DateTime StartCredit { get; set; }//выдача кредита
            public DateTime EndCredit { get; set; }//окончание кредита
            public DateTime DebtCretit { get; set; }//выход на просрочку
            public Magistrate MagistrateInfo { get; set; }
            public decimal MagistrateTax { get; set; } //пошлина
            public OrderProcessInform OrderInfo { get; set; }
        }
        public class Magistrate
        {
            public int MagistrateId { get; set; }
            public string MagistrateName { get; set; }
            public Address MagistrateAddress { get; set; }            
            public BankAccount MagistrateBankAccount { get; set; }
        }

        public class BankAccount
        {
            public int BankAccountId { get; set; }
            public string NameForPay { get; set; }
            public int KPP { get; set; }
            public int INN { get; set; }
            public int OKTMO { get; set; }
            public int NumberAccount { get; set; }
            public int BIC { get; set; }
            public int KBK { get; set; }
        }
        public class OrderProcessInform
        {
            public int ProcessId { get; set; }
            public DateTime StatementDateSend { get; set; }
            public bool StatementStatus{ get; set; }
            public string OrderNumber { get; set; }
            public DateTime OrderDate { get; set; }
            public bool OrderStatusActual { get; set; }
            public DateTime OrderDateActual { get; set; }//дата вступления в силу
            public DateTime OrderDateSendDebtСoll { get; set; } //дата отправки на взыскание в службу или банк
            public DebtCollectionInform Debt { get; set; }

        }
        public class DebtCollectionInform
        {
            public int DebtCollectionId { get; set; }
            public DebtCollection DebtColl { get; set; }
            public string DebtCollNumber { get; set; }
            public DateTime DebtCollDate { get; set; }
            public List<CashBack> Cash { get; set; }

        }

        public class DebtCollection //ФССП
        {
            public int DebtCollectionId { get; set; }
            public string DebtCollectionName { get; set; }
            public Address DebtCollectionAddress { get; set; }
        }

        public class CashBack
        {
            public int CashId { get; set; }
            public DateTime CashDate { get; set; }
            public decimal CashSumm { get; set; }
        }

        public class Documents
        {
            public int DocumentId { get; set; }
            public Client ClientID { get; set; }
            public DebtInform DebtInformID { get; set; }
            public string DocumentName { get; set; }
            public string DocumentType { get; set; }
            public byte[] Document { get; set; }
        }

        public class Managers
        {
            public int ManagerId { get; set;  }
        }


    }
}
