using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HumanaCRUD.Data;
using HumanaCRUD.Entity;

namespace HumanaCRUD.Controller
{
    public class PatientController
    {
        const string APIurl = "https://stu3.test.pyrohealth.net/fhir/Patient/";
        public async Task<Patient> GetPatientAsync(string id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/fhir+json");
                var response = await client.GetAsync(APIurl + id).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Patient>(responseBody);
            }
        }

        public async Task<Patient> PostAsync(Patient patient)
        {
            string JSONresult = JsonConvert.SerializeObject(patient);

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/fhir+json");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/fhir+json; charset=utf-8");
                var response = await client.PostAsync(APIurl,
                     new StringContent(JSONresult, Encoding.UTF8, "application/fhir+json")).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Patient>(responseBody);
            }
        }

        public async Task<BunblePatient> GetBundlePatientsAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/fhir+json");
                var response = await client.GetAsync(APIurl + "?active=true").ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BunblePatient>(responseBody);
            }
        }

    }
}
