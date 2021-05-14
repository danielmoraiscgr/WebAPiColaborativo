using System;
namespace WebAPiColaborativo.Data
{
    public class DbContext
    {
        public string CaminhoBanco()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"db.json";
        }
    }
}
