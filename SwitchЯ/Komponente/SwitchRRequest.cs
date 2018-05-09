using Newtonsoft.Json;
using SwitchRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SwitchRComponents
{
    class SwitchRRequest
    {
        /// <summary>
        /// Get upit koji šalje na zadani URL. 
        /// </summary>
        /// <param name="url">URL na koji šalje upit.</param>
        /// <param name="Tip">Tip podataka koji se očekuje kao odgovor od servera.</param>
        /// <returns></returns>
        public object Get(string url, object Tip)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsStringAsync().Result;

                if (Tip.GetType() == typeof(korisnici))
                {

                    Tip = JsonConvert.DeserializeObject<korisnici>(dataObjects);
                    return Tip;

                }
                else if (Tip.GetType() == typeof(List<korisnici>))
                {
                    Tip = JsonConvert.DeserializeObject<List<korisnici>>(dataObjects);
                    return Tip;
                }
                else if (Tip.GetType() == typeof(List<uredaji>))
                {
                    Tip = JsonConvert.DeserializeObject <List<uredaji>>(dataObjects);
                    return Tip;
                }
                else if (Tip.GetType() == typeof(List<recepti>))
                {
                    Tip = JsonConvert.DeserializeObject<List<recepti>>(dataObjects);
                    return Tip;
                }
                else if (Tip.GetType() == typeof(List<tipovi_evidnecije>))
                {
                    Tip = JsonConvert.DeserializeObject<List<tipovi_evidnecije>>(dataObjects);
                    return Tip;
                }
                else if (Tip.GetType() == typeof(List<evidencija>))
                {
                    Tip = JsonConvert.DeserializeObject<List<evidencija>>(dataObjects);
                    return Tip;
                }
                else
                {
                    return null;
                }

                return dataObjects;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Post upit koji šalje na server.
        /// </summary>
        /// <param name="url">URL server na koji šalje.</param>
        /// <param name="Tip">Tip odgovora koji očekuje od servera, i podaci koji se šalju u tijelu upita.</param>
        /// <returns></returns>
        public object Post(string url, object Tip)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string json = "";
            json = JsonConvert.SerializeObject(Tip);
           
         
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            // List data response.
            HttpResponseMessage response = client.PostAsync(url, body).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsStringAsync().Result;

                if (Tip.GetType() == typeof(korisnici))
                {

                    Tip = JsonConvert.DeserializeObject<korisnici>(dataObjects);
                    return Tip;

                }
                else
                {
                    return null;
                }

                return dataObjects;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Put upit na zadani server.
        /// </summary>
        /// <param name="url">URL server na koji šalje.</param>
        /// <param name="Tip">Tip odgovora koji očekuje od servera, i podaci koji se šalju u tijelu upita.</param>
        /// <returns></returns>
        public object Put(string url, object Tip)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string json = "";
            if (Tip.GetType() == typeof(korisnici))
            {
                (Tip as korisnici).recepti = null;
                (Tip as korisnici).uredaj_korisnici = null;
               
                json = JsonConvert.SerializeObject(Tip);
            }

            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            // List data response.
            HttpResponseMessage response = client.PutAsync(url, body).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsStringAsync().Result;

                if (Tip.GetType() == typeof(korisnici))
                {

                    Tip = JsonConvert.DeserializeObject<korisnici>(dataObjects);
                    return Tip;

                }
                else
                {
                    return null;
                }

                return dataObjects;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Delete upit koji šalje na server.
        /// </summary>
        /// <param name="url">URL na koji šalje upit.</param>
        /// <returns></returns>
        public string Delete(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

           
            // List data response.
            HttpResponseMessage response = client.DeleteAsync(url).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsStringAsync().Result;

                return dataObjects;
            }
            else
            {
                return null;
            }
        }
    }
}
