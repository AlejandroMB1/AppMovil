using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DataBaseServices.Services.Handler
{
    class MemoryDataHandler
    {
        public async Task GetData(string key)
        {
            try
            {
                var secureValue = await SecureStorage.GetAsync(key);
                if (secureValue != null)
                {
                    Application.Current.Properties[key] = secureValue;
                }
            }
            catch (Exception)
            {

            }

        }

        public async Task SaveData(string key, object value)
        {
            try
            {
                var stringValue = value.ToString();
                await SecureStorage.SetAsync(key, stringValue);
                Application.Current.Properties[key] = stringValue;
            }

            catch (Exception)
            {

            }
        }

        public void DeleteData(string key)
        {
            Application.Current.Properties[key] = null;
            SecureStorage.Remove(key);
        }
    }
}
