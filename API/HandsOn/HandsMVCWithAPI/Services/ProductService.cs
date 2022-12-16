using HandsMVCWithAPI.Contracts;
using HandsMVCWithAPI.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HandsMVCWithAPI.Services
{
    public class ProductService : IProductContract
    {
        private string api_url = "http://localhost:5284/";
        public  void AddProduct(Product product) //Add new Product
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(api_url);
                //serialzie product details to json form.
                var contentData = new StringContent(JsonConvert.SerializeObject(product),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =  client.PostAsync("api/Product/AddProduct", contentData).Result;
                
            }
        }

        public void DeleteProduct(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(api_url); //assign api addess 
              
              
                HttpResponseMessage response = client.DeleteAsync("api/Product/DeleteProduct/" + id).Result;
              
            }
        }

        public void EditProduct(Product product)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(api_url);
                //serialzie product details to json form.
                var contentData = new StringContent(JsonConvert.SerializeObject(product),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/Product/EditProduct", contentData).Result;

            }
        }

        public Product GetProduct(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(api_url); //assign api addess 
                //set the media format to json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Product/GetProduct/" + id).Result;
                Product product = JsonConvert.DeserializeObject<Product>(response.Content.ReadAsStringAsync().Result);
                return product;
            }
        }

        public List<Product> GetProducts() //Get All Products
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(api_url); //assign api addess 
                //set the media format to json
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/Product/GetAllProducts").Result;
                List<Product> list = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }
       
    }
}
