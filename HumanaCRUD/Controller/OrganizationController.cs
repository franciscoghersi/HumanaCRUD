using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HumanaCRUD.Data;
using HumanaCRUD.Entity;

namespace HumanaCRUD.Controller
{
    public class OrganizationController
    {
        const string APIurl = "https://stu3.test.pyrohealth.net/fhir/Organization/";
        public async Task<Organization> GetOrganizationAsync(string id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/fhir+json");
                var response = await client.GetAsync(APIurl + id).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Organization>(responseBody);
            }
        }

        public async Task<Patient> PostAsync(Organization organization)
        {
            string JSONresult = JsonConvert.SerializeObject(organization);

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

        public async Task<BundleOrganization> GetBundleOrganizationAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/fhir+json");
                var response = await client.GetAsync(APIurl + "?active=true").ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BundleOrganization>(responseBody);
            }
        }
        public async Task<bool> DeleteOrganizationAsync(string id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/fhir+json");
                var response = await client.DeleteAsync(APIurl + id).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
        }

    }
}
