public class BankTransferConfig
{
    public string lang { get; set; }
    public class Transfer
    {
        public string threshold { get; set; }
        public string low_fee { get; set; }
        public string high_fee { get; set;}
    }
    public Transfer transfer { get; set; }
    public string methods { get; set; }
    public class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }
    public Confirmation confirmation { get; set; }

    public void ReadJSON(string jsonString)
    {
        BankTransferConfig config = new BankTransferConfig();
        lang = config.lang;
        transfer = config.transfer;
        methods = config.methods;
        confirmation = config.confirmation;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string json = "{\"lang\": \"CONFIG1\", \"transfer\": {\"threshold\": \"CONFIG2\", \"low_fee\": \"CONFIG3\", \"high_fee\": \"CONFIG4\"}, \"methods\": \"CONFIG5\", \"confirmation\": {\"en\": \"CONFIG6\", \"id\": \"CONFIG7\"}}";
        BankTransferConfig config = new BankTransferConfig();
        config.ReadJSON(json);

        Console.WriteLine("1. Please insert the amount of money to transfer: ");
        Console.WriteLine("2. Masukan jumlah uang yang akan di-transfer: ");

    }
}