using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace Modul8_1302210087
{
    internal class BankTransferConfig
    {
        public void ReadJSON()
        {
            string json = File.ReadAllText(@"C:\Users\LENOVO\source\repos\Modul8_1302210087\Modul8_1302210087\bank_transfer_config.json");
            dynamic jsonGif = JsonConvert.DeserializeObject(json);

            if (jsonGif.lang = "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer: ");
            }
            else
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            }

            if (jsonGif.transfer.threshold <= 25000000)
            {
            
            }
        }
    }
}
